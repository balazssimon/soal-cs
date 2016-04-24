using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MetaDslx.Soal
{
    internal class ObjectStorage<TObject, TXObject> 
        where TObject : class
        where TXObject : XElement
    {
        private string name;
        private SoalImporter importer;
        private Dictionary<TXObject, TObject> objectsByElement = new Dictionary<TXObject, TObject>();
        private Dictionary<XName, TObject> objectsByName = new Dictionary<XName, TObject>();
        private Dictionary<XName, TXObject> elementsByName = new Dictionary<XName, TXObject>();
        private Dictionary<TObject, TXObject> elementsByObject = new Dictionary<TObject, TXObject>();

        public ObjectStorage(string name, SoalImporter importer)
        {
            this.name = name;
            this.importer = importer;
        }

        internal TObject Register(XmlReader reader, XName xname, TXObject xobj, TObject obj, bool allowReverse = true)
        {
            TObject oldObject = null;
            if (this.objectsByName.TryGetValue(xname, out oldObject))
            {
                TXObject oldElem = this.elementsByObject[oldObject];
                this.importer.Diagnostics.AddError("The "+this.name+" '" + xname + "' is already imported from '" + oldElem.BaseUri + "' at '" + SoalImporter.GetTextSpan(oldElem) + "'.", reader.Uri, SoalImporter.GetTextSpan(xobj));
                return null;
            }
            if (this.objectsByElement.TryGetValue(xobj, out oldObject))
            {
                TXObject oldElem = this.elementsByObject[oldObject];
                this.importer.Diagnostics.AddError("The " + this.name + " '" + xname + "' has already an object assigned to it.", reader.Uri, SoalImporter.GetTextSpan(xobj));
                return null;
            }
            TXObject oldXObject = null;
            if (this.elementsByName.TryGetValue(xname, out oldXObject))
            {
                this.importer.Diagnostics.AddError("The " + this.name + " '" + xname + "' is already registered to '" + oldXObject.BaseUri + "' at '" + SoalImporter.GetTextSpan(oldXObject) + "'.", reader.Uri, SoalImporter.GetTextSpan(xobj));
                return null;
            }
            this.objectsByName.Add(xname, obj);
            this.objectsByElement.Add(xobj, obj);
            this.elementsByName.Add(xname, xobj);
            if (allowReverse)
            {
                if (this.elementsByObject.TryGetValue(obj, out oldXObject))
                {
                    this.importer.Diagnostics.AddError("The object is alredy registered to " + this.name + " in '" + oldXObject.BaseUri + "' at '" + SoalImporter.GetTextSpan(oldXObject) + "'.", reader.Uri, SoalImporter.GetTextSpan(xobj));
                    return null;
                }
                if (!this.elementsByObject.ContainsKey(obj))
                {
                    this.elementsByObject.Add(obj, xobj);
                }
            }
            return obj;
        }

        internal TObject Get(XName xname)
        {
            if (xname == null) return null;
            TObject result = null;
            this.objectsByName.TryGetValue(xname, out result);
            return result;
        }

        internal TObject Get(TXObject xobj)
        {
            if (xobj == null) return null;
            TObject result = null;
            this.objectsByElement.TryGetValue(xobj, out result);
            return result;
        }

        internal TXObject GetX(XName xname)
        {
            if (xname == null) return null;
            TXObject result = null;
            this.elementsByName.TryGetValue(xname, out result);
            return result;
        }

        internal TXObject GetX(TObject obj)
        {
            if (obj == null) return null;
            TXObject result = null;
            this.elementsByObject.TryGetValue(obj, out result);
            return result;
        }
    }

    public class SoalImporter
    {
        private int namespaceCounter;
        private ArrayType byteArray;
        private Dictionary<string, HashSet<XmlReader>> readers = new Dictionary<string, HashSet<XmlReader>>();
        private Dictionary<string, Namespace> namespaces = new Dictionary<string, Namespace>();
        private Dictionary<SoalType, SoalType> replacementTypes = new Dictionary<SoalType, SoalType>();
        private Dictionary<ModelObject, SoalType> originalTypes = new Dictionary<ModelObject, SoalType>();
        private HashSet<SoalType> rootTypes = new HashSet<SoalType>();
        private HashSet<SoalType> typesToRemove = new HashSet<SoalType>();
        private Dictionary<XName, WsdlMessage> messagesByName = new Dictionary<XName, WsdlMessage>();
        private Dictionary<SoalType, int> referenceCounter = new Dictionary<SoalType, int>();

        public ModelCompilerDiagnostics Diagnostics { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdTypes { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdElements { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdAttributes { get; private set; }
        //internal ObjectStorage<SoalType, XElement> XsdGroups { get; private set; }
        //internal ObjectStorage<SoalType, XElement> XsdAttributeGroups { get; private set; }
        internal ObjectStorage<SoalType, XElement> WsdlTypes { get; private set; }
        internal ObjectStorage<SoalType, XElement> WsdlElements { get; private set; }
        internal ObjectStorage<WsdlMessage, XElement> WsdlMessages { get; private set; }
        internal ObjectStorage<Interface, XElement> WsdlPortTypes { get; private set; }
        internal ObjectStorage<Binding, XElement> WsdlBindings { get; private set; }
        internal ObjectStorage<Endpoint, XElement> WsdlServices { get; private set; }
        internal ObjectStorage<Binding, XElement> WsdlPolicies { get; private set; }

        private SoalImporter(ModelCompilerDiagnostics diagnostics)
        {
            this.Diagnostics = diagnostics;
            this.namespaceCounter = 0;
            this.byteArray = SoalFactory.Instance.CreateArrayType();
            this.byteArray.InnerType = SoalInstance.Byte;
            this.XsdTypes = new ObjectStorage<SoalType, XElement>("type", this);
            this.XsdElements = new ObjectStorage<SoalType, XElement>("element", this);
            this.XsdAttributes = new ObjectStorage<SoalType, XElement>("attribute", this);
            //this.XsdGroups = new ObjectStorage<SoalType, XElement>("group", this);
            //this.XsdAttributeGroups = new ObjectStorage<SoalType, XElement>("attributeGroup", this);
            this.WsdlTypes = new ObjectStorage<SoalType, XElement>("type", this);
            this.WsdlElements = new ObjectStorage<SoalType, XElement>("element", this);
            this.WsdlMessages = new ObjectStorage<WsdlMessage, XElement>("message", this);
            this.WsdlPortTypes = new ObjectStorage<Interface, XElement>("portType", this);
            this.WsdlBindings = new ObjectStorage<Binding, XElement>("binding", this);
            this.WsdlServices = new ObjectStorage<Endpoint, XElement>("service", this);
            this.WsdlPolicies = new ObjectStorage<Binding, XElement>("policy", this);
        }

        public static void Import(string uri, ModelCompilerDiagnostics diagnostics = null)
        {
            ModelContext.RequireContext();
            if (diagnostics == null)
            {
                diagnostics = ModelCompilerContext.Current.Diagnostics;
            }
            SoalImporter importer = new SoalImporter(diagnostics);
            importer.ImportFile(uri);
            if (importer.Diagnostics.HasErrors()) return;
            LoadImportedFiles(importer);
            if (importer.Diagnostics.HasErrors()) return;
            RemoveTypes(importer);
            foreach (var fileUri in importer.readers.Keys)
            {
                if (!importer.Diagnostics.GetMessages(true).Any(m => m.FileName == fileUri && m.Severity == Severity.Error))
                {
                    importer.Diagnostics.AddInfo("File successfully imported.", fileUri, new TextSpan());
                }
                else
                {
                    importer.Diagnostics.AddError("Could not import file.", fileUri, new TextSpan());
                }
            }
        }

        private static void LoadImportedFiles(SoalImporter importer)
        {
            for (int i = 0; i < XsdReader.PhaseCount; i++)
            {
                foreach (var reader in importer.readers)
                {
                    foreach (var r in reader.Value)
                    {
                        r.LoadXsdFile(i);
                    }
                }
            }
            importer.CheckXsdTypes();
            for (int i = 0; i < WsdlReader.PhaseCount; i++)
            {
                foreach (var reader in importer.readers)
                {
                    foreach (var r in reader.Value)
                    {
                        r.LoadWsdlFile(i);
                    }
                }
            }
        }

        private static void RemoveTypes(SoalImporter importer)
        {
            foreach (var type in importer.typesToRemove)
            {
                Declaration decl = type as Declaration;
                if (decl != null)
                {
                    /*if (importer.rootTypes.Contains(type))
                    {
                        SoalType finalType = importer.GetReplacementType(type);
                        int finalCount = 0;
                        importer.referenceCounter.TryGetValue(type, out finalCount);
                        int count = 0;
                        importer.referenceCounter.TryGetValue(type, out count);
                        if (finalCount > 0 && count <= 0)
                        {
                            decl.Namespace = null;
                            ModelContext.Current.RemoveInstance((ModelObject)decl);
                        }
                    }
                    else*/
                    {
                        /*SoalType finalType = importer.GetReplacementType(type);
                        int finalCount = 0;
                        importer.referenceCounter.TryGetValue(type, out finalCount);*/
                        int count = 0;
                        importer.referenceCounter.TryGetValue(type, out count);
                        if (/*finalCount > 0 && */count <= 0)
                        {
                            decl.Namespace = null;
                            ModelContext.Current.RemoveInstance((ModelObject)decl);
                        }
                    }
                }
            }
        }

        internal void AddRootType(SoalType type)
        {
            if (type == null) return;
            this.rootTypes.Add(type);
        }

        internal void Reference(SoalType type)
        {
            if (type == null) return;
            int count = 0;
            if (this.referenceCounter.TryGetValue(type, out count))
            {
                ++count;
            }
            else
            {
                count = 1;
            }
            this.referenceCounter[type] = count;
        }
        /*
        internal void UnReference(SoalType type)
        {
            int count = 0;
            if (this.referenceCounter.TryGetValue(type, out count))
            {
                --count;
            }
            else
            {
                count = 0;
            }
            this.referenceCounter[type] = count;
        }
        */
        internal static TextSpan GetTextSpan(XObject xobj)
        {
            if (xobj == null) return new TextSpan();
            IXmlLineInfo info = xobj;
            return new TextSpan(info.LineNumber, info.LinePosition, info.LineNumber, info.LinePosition);
        }

        internal void ImportFile(string fileUri)
        {
            try
            {
                XDocument doc;
                Uri uri;
                string absoluteUri;
                if (Uri.TryCreate(fileUri, UriKind.Absolute, out uri))
                {
                    absoluteUri = uri.AbsoluteUri;
                }
                else
                {
                    string fullPath = Path.GetFullPath(fileUri);
                    if (Uri.TryCreate(fullPath, UriKind.Absolute, out uri))
                    {
                        absoluteUri = uri.AbsoluteUri;
                    }
                    else
                    {
                        absoluteUri = fullPath;
                    }
                }
                doc = XDocument.Load(absoluteUri, LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
                this.ImportXmlDocument(doc, absoluteUri);
            }
            catch(System.Exception ex)
            {
                this.Diagnostics.AddError("Could not import file: "+ex.Message, fileUri, new TextSpan());
            }
        }

        internal void ImportRelativeFile(string currentUri, string relativeUri)
        {
            string importUri = this.GetAbsoluteFileUri(currentUri, relativeUri);
            if (importUri != null)
            {
                this.ImportFile(relativeUri);
            }
            else
            {
                this.Diagnostics.AddError("Invalid relative URI in import '" + relativeUri + "'.", currentUri, new TextSpan());
            }
        }

        internal string GetAbsoluteFileUri(string currentUri, string relativeUri)
        {
            Uri uri;
            if (Uri.TryCreate(relativeUri, UriKind.Absolute, out uri))
            {
                return uri.AbsoluteUri;
            }
            else
            {
                string baseUriStr = currentUri.Substring(0, currentUri.LastIndexOf('/') + 1);
                Uri baseUri;
                if (Uri.TryCreate(baseUriStr, UriKind.Absolute, out baseUri))
                {
                    if (Uri.TryCreate(baseUri, relativeUri, out uri))
                    {
                        return uri.AbsoluteUri;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    if (Path.IsPathRooted(relativeUri))
                    {
                        return relativeUri;
                    }
                    else
                    {
                        string absoluteUri = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(currentUri), relativeUri));
                        return absoluteUri;
                    }
                }
            }
        }

        internal Namespace CreateNamespace(XmlReader reader, string uri, string prefix, string qualifiedName)
        {
            if (qualifiedName == null)
            {
                qualifiedName = "Ns" + (++this.namespaceCounter);
            }
            Namespace result = this.GetNamespace(uri);
            if (result != null)
            {
                if (result.Uri != uri)
                {
                    this.Diagnostics.AddWarning("Namespace '" + result.FullName + "' has conflicting URIs: '" + result.FullName + "' and '" + uri + "'", reader.Uri, new TextSpan());
                }
                return result;
            }
            string[] names = qualifiedName.Split('.');
            int i = 0;
            IEnumerable<ModelObject> currentScope = new ModelObject[] { ModelCompilerContext.Current.GlobalScope };
            while (i < names.Length)
            {
                ResolutionInfo ri = new ResolutionInfo();
                ri.Scopes.Add((ModelObject)currentScope);
                ri.Kind = ResolveKind.Name;
                ri.QualifiedNameNodes.Add(names[0]);
                ri.Location = ResolutionLocation.Children;
                var nextScope = ModelCompilerContext.Current.ResolutionProvider.Resolve(ri).ResolvedObjects;
                if (nextScope.Any())
                {
                    currentScope = nextScope;
                    ++i;
                }
                else
                {
                    ModelObject parentNs = currentScope.FirstOrDefault();
                    while(i < names.Length)
                    {
                        Namespace ns = SoalFactory.Instance.CreateNamespace();
                        ns.Name = names[i];
                        ++i;
                        if (i == names.Length)
                        {
                            ns.Prefix = prefix;
                            ns.Uri = uri;
                            result = ns;
                            this.namespaces.Add(uri, ns);
                        }
                    }
                }
            }
            return result;
        }

        internal Namespace GetNamespace(string uri)
        {
            Namespace result = null;
            this.namespaces.TryGetValue(uri, out result);
            return result;
        }

        internal void RegisterOriginalType(ModelObject obj, SoalType type)
        {
            if (obj == null) return;
            if (type == null) return;
            if (!originalTypes.ContainsKey(obj))
            {
                this.originalTypes.Add(obj, type);
            }
        }

        internal void RegisterReplacementType(SoalType from, SoalType to)
        {
            if (from == null) return;
            if (to == null) return;
            if (!replacementTypes.ContainsKey(from))
            {
                this.replacementTypes.Add(from, to);
                this.typesToRemove.Add(from);
            }
        }

        internal void RemoveType(SoalType type)
        {
            this.typesToRemove.Add(type);
        }

        internal SoalType GetReplacementType(SoalType original)
        {
            SoalType result = null;
            this.replacementTypes.TryGetValue(original, out result);
            return result;
        }

        internal SoalType ResolveXsdPrimitiveType(XName name)
        {
            if (name.NamespaceName == XsdReader.XsdNamespace)
            {
                switch (name.LocalName)
                {
                    case "any": return SoalInstance.Object;
                    case "anySimpleType": return SoalInstance.Object;
                    case "string": return SoalInstance.String;
                    case "anyURI": return SoalInstance.String;
                    case "QName": return SoalInstance.String;
                    case "NOTATION": return SoalInstance.String;
                    case "normalizedString": return SoalInstance.String;
                    case "token": return SoalInstance.String;
                    case "language": return SoalInstance.String;
                    case "Name": return SoalInstance.String;
                    case "NCName": return SoalInstance.String;
                    case "NMTOKEN": return SoalInstance.String;
                    case "NMTOKENS": return SoalInstance.String;
                    case "ID": return SoalInstance.String;
                    case "IDREF": return SoalInstance.String;
                    case "IDREFS": return SoalInstance.String;
                    case "ENTITY": return SoalInstance.String;
                    case "ENTITIES": return SoalInstance.String;
                    case "integer": return SoalInstance.Int;
                    case "nonPositiveInteger": return SoalInstance.Int;
                    case "negativeInteger": return SoalInstance.Int;
                    case "int": return SoalInstance.Int;
                    case "short": return SoalInstance.Int;
                    case "nonNegativeInteger": return SoalInstance.Int;
                    case "positiveInteger": return SoalInstance.Int;
                    case "unsignedInt": return SoalInstance.Int;
                    case "unsignedShort": return SoalInstance.Int;
                    case "long": return SoalInstance.Long;
                    case "unsignedLong": return SoalInstance.Int;
                    case "float": return SoalInstance.Float;
                    case "double": return SoalInstance.Double;
                    case "decimal": return SoalInstance.Double;
                    case "byte": return SoalInstance.Byte;
                    case "unsignedByte": return SoalInstance.Byte;
                    case "base64Binary": return this.byteArray;
                    case "hexBinary": return this.byteArray;
                    case "bool": return SoalInstance.Bool;
                    case "boolean": return SoalInstance.Bool;
                    case "time": return SoalInstance.Time;
                    case "date": return SoalInstance.Date;
                    case "dateTime": return SoalInstance.DateTime;
                    case "duration": return SoalInstance.TimeSpan;
                    case "gDay": return SoalInstance.Date;
                    case "gMonth": return SoalInstance.Date;
                    case "gMonthDay": return SoalInstance.Date;
                    case "gYear": return SoalInstance.Date;
                    case "gYearMonth": return SoalInstance.Date;
                    default:
                        break;
                }
            }
            return null;
        }

        internal SoalType ResolveXsdType(XName name)
        {
            SoalType result = null;
            if (name.NamespaceName == XsdReader.XsdNamespace)
            {
                result = this.ResolveXsdPrimitiveType(name);
                if (result != null) return result;
            }
            Namespace ns = this.GetNamespace(name.NamespaceName);
            if (ns != null)
            {
                ResolutionInfo ri = new ResolutionInfo();
                ri.Scopes.Add((ModelObject)ns);
                ri.Kind = ResolveKind.NameOrType;
                ri.QualifiedNameNodes.Add(name.LocalName);
                ri.Location = ResolutionLocation.Children;
                IEnumerable<ModelObject> results = ModelCompilerContext.Current.ResolutionProvider.Resolve(ri).ResolvedObjects;
                ModelObject mo = results.FirstOrDefault();
                SoalType type = mo as SoalType;
                return this.ResolveXsdReplacementType(type);
            }
            return null;
        }

        internal SoalType ResolveXsdReplacementType(SoalType type)
        {
            while (true)
            {
                SoalType replacementType = null;
                if (type != null && this.replacementTypes.TryGetValue(type, out replacementType))
                {
                    type = replacementType;
                }
                if (replacementType == null) return type;
            }
        }

        private void RegisterReader(string uri, XmlReader reader)
        {
            HashSet<XmlReader> rs;
            if (!this.readers.TryGetValue(uri, out rs))
            {
                rs = new HashSet<XmlReader>();
                this.readers.Add(uri, rs);
            }
            rs.Add(reader);
        }

        internal void ImportXmlDocument(XDocument doc, string uri)
        {
            if (readers.ContainsKey(uri)) return;
            this.ImportXml(doc.Root, uri);
        }

        internal void ImportXml(XElement root, string uri)
        {
            if (root.Name.LocalName == "schema" && root.Name.NamespaceName == XsdReader.XsdNamespace)
            {
                XsdReader reader = new XsdReader(this, root, uri);
                this.RegisterReader(uri, reader);
                reader.CollectImportedFiles();
            }
            else if (root.Name.LocalName == "definitions" && root.Name.NamespaceName == WsdlReader.WsdlNamespace)
            {
                WsdlReader reader = new WsdlReader(this, root, uri);
                this.RegisterReader(uri, reader);
                reader.CollectImportedFiles();
            }
            else
            {
                this.Diagnostics.AddError("Unknown XML data.", uri, GetTextSpan(root));
                return;
            }
        }

        private void CheckXsdTypes()
        {
            var types = ModelContext.Current.Instances.OfType<Struct>().ToList();
            foreach (var type in types)
            {
                foreach (var prop in type.Properties)
                {
                    if (prop.Type == null || prop.Type.GetCoreType() == null)
                    {
                        XElement elem = this.XsdTypes.GetX(type);
                        string uri = "";
                        if (elem != null)
                        {
                            uri = elem.BaseUri;
                        }
                        this.Diagnostics.AddError("The property '" + type.Name + "." + prop.Name + "' has no type.", uri, SoalImporter.GetTextSpan(elem));
                    }
                    else
                    {
                        SoalType originalType = null;
                        if (this.originalTypes.TryGetValue((ModelObject)prop, out originalType))
                        {
                            if (originalType is AnnotatedElement && ((AnnotatedElement)originalType).HasAnnotation(SoalAnnotations.Restriction))
                            {
                                SoalImporter.CopyAnnotation(SoalAnnotations.Restriction, ((AnnotatedElement)originalType), prop);
                            }
                            if (originalType is Struct)
                            {
                                object wrapped = ((Struct)originalType).GetAnnotationPropertyValue(SoalAnnotations.Type, SoalAnnotationProperties.Wrapped) ?? false;
                                if ((bool)wrapped)
                                {
                                    SoalImporter.CopyAnnotationProperty(SoalAnnotations.Type, SoalAnnotationProperties.Wrapped, ((AnnotatedElement)originalType), SoalAnnotations.Element, SoalAnnotationProperties.Wrapped, prop);
                                    SoalImporter.CopyAnnotationProperty(SoalAnnotations.Type, SoalAnnotationProperties.Items, ((AnnotatedElement)originalType), SoalAnnotations.Element, SoalAnnotationProperties.Items, prop);
                                    SoalImporter.CopyAnnotationProperty(SoalAnnotations.Type, SoalAnnotationProperties.Sap, ((AnnotatedElement)originalType), SoalAnnotations.Element, SoalAnnotationProperties.Sap, prop);
                                }
                            }
                        }
                    }

                }
            }
        }

        internal static Annotation CloneAnnotation(Annotation annot)
        {
            Annotation toAnnot = SoalFactory.Instance.CreateAnnotation();
            toAnnot.Name = annot.Name;
            foreach (var annotProp in annot.Properties)
            {
                AnnotationProperty toAnnotProp = SoalFactory.Instance.CreateAnnotationProperty();
                toAnnotProp.Name = annotProp.Name;
                toAnnotProp.Value = annotProp.Value;
                toAnnot.Properties.Add(toAnnotProp);
            }
            return toAnnot;
        }

        internal static void CopyAnnotationProperty(string annotationName, string propertyName, AnnotatedElement from, AnnotatedElement to)
        {
            foreach (var annot in from.Annotations)
            {
                if (annot.Name == annotationName)
                {
                    AnnotationProperty annotProp = annot.GetProperty(propertyName);
                    if (annotProp != null)
                    {
                        to.SetAnnotationPropertyValue(annotationName, propertyName, annotProp.Value);
                    }
                }
            }
        }

        internal static void CopyAnnotationProperty(string annotationName, string propertyName, AnnotatedElement from, string targetAnnotationName, string targetPropertyName, AnnotatedElement to)
        {
            foreach (var annot in from.Annotations)
            {
                if (annot.Name == annotationName)
                {
                    AnnotationProperty annotProp = annot.GetProperty(propertyName);
                    if (annotProp != null)
                    {
                        to.SetAnnotationPropertyValue(targetAnnotationName, targetPropertyName, annotProp.Value);
                    }
                }
            }
        }

        internal static void CopyAnnotation(string name, AnnotatedElement from, AnnotatedElement to)
        {
            foreach (var annot in from.Annotations)
            {
                if (annot.Name == name)
                {
                    Annotation toAnnot = SoalFactory.Instance.CreateAnnotation();
                    toAnnot.Name = annot.Name;
                    to.Annotations.Add(toAnnot);
                    foreach (var annotProp in annot.Properties)
                    {
                        AnnotationProperty toAnnotProp = SoalFactory.Instance.CreateAnnotationProperty();
                        toAnnotProp.Name = annotProp.Name;
                        toAnnotProp.Value = annotProp.Value;
                        toAnnot.Properties.Add(toAnnotProp);
                    }
                }
            }
        }

        internal static void CopyAnnotations(AnnotatedElement from, AnnotatedElement to)
        {
            if (from == null) return;
            if (to == null) return;
            foreach (var annot in from.Annotations)
            {
                Annotation toAnnot = SoalFactory.Instance.CreateAnnotation();
                toAnnot.Name = annot.Name;
                to.Annotations.Add(toAnnot);
                foreach (var annotProp in annot.Properties)
                {
                    AnnotationProperty toAnnotProp = SoalFactory.Instance.CreateAnnotationProperty();
                    toAnnotProp.Name = annotProp.Name;
                    toAnnotProp.Value = annotProp.Value;
                    toAnnot.Properties.Add(toAnnotProp);
                }
            }
        }

    }
}
