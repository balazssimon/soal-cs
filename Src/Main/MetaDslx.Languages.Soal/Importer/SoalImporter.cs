using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.Soal.Importer;
using MetaDslx.Languages.Soal.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MetaDslx.Languages.Soal
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

        internal TObject Register(Importer.XmlReader reader, XName xname, TXObject xobj, TObject obj, bool allowReverse = true)
        {
            TObject oldObject = null;
            if (this.objectsByName.TryGetValue(xname, out oldObject))
            {
                TXObject oldElem = this.elementsByObject[oldObject];
                this.importer.AddError("The "+this.name+" '" + xname + "' is already imported from '" + oldElem.BaseUri + "' at '" + SoalImporter.GetLinePositionSpan(oldElem) + "'.", reader.Uri, SoalImporter.GetLinePositionSpan(xobj));
                return null;
            }
            if (this.objectsByElement.TryGetValue(xobj, out oldObject))
            {
                TXObject oldElem = this.elementsByObject[oldObject];
                this.importer.AddError("The " + this.name + " '" + xname + "' has already an object assigned to it.", reader.Uri, SoalImporter.GetLinePositionSpan(xobj));
                return null;
            }
            TXObject oldXObject = null;
            if (this.elementsByName.TryGetValue(xname, out oldXObject))
            {
                this.importer.AddError("The " + this.name + " '" + xname + "' is already registered to '" + oldXObject.BaseUri + "' at '" + SoalImporter.GetLinePositionSpan(oldXObject) + "'.", reader.Uri, SoalImporter.GetLinePositionSpan(xobj));
                return null;
            }
            this.objectsByName.Add(xname, obj);
            this.objectsByElement.Add(xobj, obj);
            this.elementsByName.Add(xname, xobj);
            if (allowReverse)
            {
                if (this.elementsByObject.TryGetValue(obj, out oldXObject))
                {
                    this.importer.AddError("The object is alredy registered to " + this.name + " in '" + oldXObject.BaseUri + "' at '" + SoalImporter.GetLinePositionSpan(oldXObject) + "'.", reader.Uri, SoalImporter.GetLinePositionSpan(xobj));
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
        private Dictionary<string, HashSet<Importer.XmlReader>> readers = new Dictionary<string, HashSet<Importer.XmlReader>>();
        private Dictionary<string, Namespace> namespaces = new Dictionary<string, Namespace>();
        private Dictionary<SoalType, SoalType> replacementTypes = new Dictionary<SoalType, SoalType>();
        private Dictionary<IModelObject, SoalType> originalTypes = new Dictionary<IModelObject, SoalType>();
        private HashSet<SoalType> rootTypes = new HashSet<SoalType>();
        private HashSet<SoalType> typesToRemove = new HashSet<SoalType>();
        private Dictionary<XName, WsdlMessage> messagesByName = new Dictionary<XName, WsdlMessage>();
        private Dictionary<SoalType, int> referenceCounter = new Dictionary<SoalType, int>();

        internal DiagnosticBag Diagnostics { get; private set; }
        internal Model SoalModel { get; private set; }
        internal Model Model { get; private set; }
        internal SoalModelFactory Factory { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdTypes { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdElements { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdAttributes { get; private set; }
        internal ObjectStorage<SoalType, XElement> WsdlTypes { get; private set; }
        internal ObjectStorage<SoalType, XElement> WsdlElements { get; private set; }
        internal ObjectStorage<WsdlMessage, XElement> WsdlMessages { get; private set; }
        internal ObjectStorage<Interface, XElement> WsdlPortTypes { get; private set; }
        internal ObjectStorage<Binding, XElement> WsdlBindings { get; private set; }
        internal ObjectStorage<Endpoint, XElement> WsdlServices { get; private set; }
        internal ObjectStorage<Binding, XElement> WsdlPolicies { get; private set; }

        private SoalImporter(DiagnosticBag diagnostics)
        {
            this.Diagnostics = diagnostics;
            this.namespaceCounter = 0;
            var group = new ModelGroup();
            group.AddReference(Symbols.Soal.MInstance.MModel);
            this.Model = group.CreateModel(name: "ImportedModel");
            this.Factory = new SoalModelFactory(this.Model);
            this.byteArray = this.Factory.ArrayType();
            this.byteArray.InnerType = Symbols.Soal.Byte;
            this.XsdTypes = new ObjectStorage<SoalType, XElement>("type", this);
            this.XsdElements = new ObjectStorage<SoalType, XElement>("element", this);
            this.XsdAttributes = new ObjectStorage<SoalType, XElement>("attribute", this);
            this.WsdlTypes = new ObjectStorage<SoalType, XElement>("type", this);
            this.WsdlElements = new ObjectStorage<SoalType, XElement>("element", this);
            this.WsdlMessages = new ObjectStorage<WsdlMessage, XElement>("message", this);
            this.WsdlPortTypes = new ObjectStorage<Interface, XElement>("portType", this);
            this.WsdlBindings = new ObjectStorage<Binding, XElement>("binding", this);
            this.WsdlServices = new ObjectStorage<Endpoint, XElement>("service", this);
            this.WsdlPolicies = new ObjectStorage<Binding, XElement>("policy", this);
        }

        public static Model Import(string uri, DiagnosticBag diagnostics = null)
        {
            SoalImporter importer = new SoalImporter(diagnostics);
            importer.ImportFile(uri);
            if (importer.Diagnostics.HasAnyErrors()) return importer.Model;
            LoadImportedFiles(importer);
            if (importer.Diagnostics.HasAnyErrors()) return importer.Model;
            RemoveTypes(importer);
            foreach (var fileUri in importer.readers.Keys)
            {
                if (!importer.Diagnostics.AsEnumerable().Any(d => d.Location.GetLineSpan().Path == fileUri && d.Severity == DiagnosticSeverity.Error))
                {
                    importer.AddInfo("File successfully imported.", fileUri, default);
                }
                else
                {
                    importer.AddError("Could not import file.", fileUri, default);
                }
            }
            return importer.Model;
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

        internal void AddError(string message, string fileUri, LinePositionSpan location)
        {
            this.Diagnostics.Add(Diagnostic.Create(SoalImporterErrorCode.ERR_SoalImport, Location.Create(fileUri, default, location), message));
        }

        internal void AddWarning(string message, string fileUri, LinePositionSpan location)
        {
            this.Diagnostics.Add(Diagnostic.Create(SoalImporterErrorCode.WRN_SoalImport, Location.Create(fileUri, default, location), message));
        }

        internal void AddInfo(string message, string fileUri, LinePositionSpan location)
        {
            this.Diagnostics.Add(Diagnostic.Create(SoalImporterErrorCode.INF_SoalImport, Location.Create(fileUri, default, location), message));
        }

        private static void RemoveTypes(SoalImporter importer)
        {
            foreach (var type in importer.typesToRemove)
            {
                Declaration decl = type as Declaration;
                if (decl != null)
                {
                    int count = 0;
                    importer.referenceCounter.TryGetValue(type, out count);
                    if (count <= 0)
                    {
                        if (decl is SoalType typeDecl && importer.rootTypes.Contains(typeDecl))
                        {
                            var sap = decl.GetAnnotationPropertyValue(SoalAnnotations.Type, SoalAnnotationProperties.Sap);
                            if (sap == null || !(bool)sap)
                            {
                                var typeAnnot = decl.Annotations.FirstOrDefault(a => a.Name == SoalAnnotations.Type);
                                if (typeAnnot != null)
                                {
                                    decl.Annotations.Remove(typeAnnot);
                                }
                            }
                            continue;
                        }
                        decl.Namespace = null;
                        importer.Model.DeleteObject(decl);
                    }
                }
            }
        }

        internal void AddRootType(SoalType type)
        {
            if (type == null) return;
            this.rootTypes.Add(type);
        }

        internal void RemoveRootType(SoalType type)
        {
            if (type == null) return;
            this.rootTypes.Remove(type);
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

        internal static LinePositionSpan GetLinePositionSpan(XObject xobj)
        {
            if (xobj == null) return new LinePositionSpan();
            IXmlLineInfo info = xobj;
            return new LinePositionSpan(new LinePosition(info.LineNumber, info.LinePosition), new LinePosition(info.LineNumber, info.LinePosition));
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
                this.AddError("Could not import file: "+ex.Message, fileUri, default);
            }
        }

        internal void ImportRelativeFile(string currentUri, string relativeUri)
        {
            string importUri = this.GetAbsoluteFileUri(currentUri, relativeUri);
            if (importUri != null)
            {
                this.ImportFile(importUri);
            }
            else
            {
                this.AddError("Invalid relative URI in import '" + relativeUri + "'.", currentUri, default);
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

        internal Namespace CreateNamespace(Importer.XmlReader reader, string uri, string prefix, string qualifiedName)
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
                    this.AddWarning("Namespace '" + result.FullName + "' has conflicting URIs: '" + result.FullName + "' and '" + uri + "'", reader.Uri, default);
                }
                return result;
            }
            string[] names = qualifiedName.Split('.');
            int i = 0;
            Namespace currentNs = null;
            while (i < names.Length)
            {
                var parentNs = currentNs;
                if (i == 0)
                {
                    Namespace rootNs = this.Model.Objects.OfType<Namespace>().FirstOrDefault(ns => ns.Name == names[0] && ns.Namespace == null);
                    currentNs = rootNs;
                }
                else
                {
                    currentNs = currentNs.Declarations.OfType<Namespace>().FirstOrDefault(ns => ns.Name == names[i]);
                }
                if (currentNs != null)
                {
                    ++i;
                    if (i == names.Length)
                    {
                        if (string.IsNullOrEmpty(currentNs.Prefix))
                        {
                            currentNs.Prefix = prefix;
                        }
                        this.namespaces.Add(uri, currentNs);
                        return currentNs;
                    }
                }
                else
                {
                    while(i < names.Length)
                    {
                        Namespace ns = this.Factory.Namespace();
                        ns.Name = names[i];
                        ns.Namespace = parentNs;
                        ++i;
                        if (i == names.Length)
                        {
                            ns.Prefix = prefix;
                            ns.Uri = uri;
                            result = ns;
                            this.namespaces.Add(uri, ns);
                            return result;
                        }
                        parentNs = ns;
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

        internal void RegisterOriginalType(IModelObject obj, SoalType type)
        {
            if (obj == null) return;
            if (type == null) return;
            if (!originalTypes.ContainsKey(obj))
            {
                this.originalTypes.Add(obj, type);
            }
        }

        internal SoalType GetOriginalType(IModelObject obj)
        {
            if (this.originalTypes.TryGetValue(obj, out SoalType result)) return result;
            else return null;
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

        internal void RemoveNamespace(Namespace ns)
        {
            this.Model.DeleteObject(ns);
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
                SoalType result = null;
                SoalType resultAs = null;
                switch (name.LocalName)
                {
                    case "any": result = Symbols.Soal.Object; break;
                    case "anySimpleType": result = Symbols.Soal.Object; break;
                    case "string": result = Symbols.Soal.String; break;
                    case "anyURI": result = Symbols.Soal.String; break;
                    case "QName": result = Symbols.Soal.String; break;
                    case "NOTATION": result = Symbols.Soal.String; break;
                    case "normalizedString": result = Symbols.Soal.String; break;
                    case "token": result = Symbols.Soal.String; break;
                    case "language": result = Symbols.Soal.String; break;
                    case "Name": result = Symbols.Soal.String; break;
                    case "NCName": result = Symbols.Soal.String; break;
                    case "NMTOKEN": result = Symbols.Soal.String; break;
                    case "NMTOKENS": result = Symbols.Soal.String; break;
                    case "ID": result = Symbols.Soal.String; break;
                    case "IDREF": result = Symbols.Soal.String; break;
                    case "IDREFS": result = Symbols.Soal.String; break;
                    case "ENTITY": result = Symbols.Soal.String; break;
                    case "ENTITIES": result = Symbols.Soal.String; break;
                    case "integer": result = Symbols.Soal.Int; break;
                    case "nonPositiveInteger": result = Symbols.Soal.Int; break;
                    case "negativeInteger": result = Symbols.Soal.Int; break;
                    case "int": result = Symbols.Soal.Int; break;
                    case "short": result = Symbols.Soal.Int; break;
                    case "nonNegativeInteger": result = Symbols.Soal.Int; break;
                    case "positiveInteger": result = Symbols.Soal.Int; break;
                    case "unsignedInt": result = Symbols.Soal.Int; break;
                    case "unsignedShort": result = Symbols.Soal.Int; break;
                    case "long": result = Symbols.Soal.Long; break;
                    case "unsignedLong": result = Symbols.Soal.Int; break;
                    case "float": result = Symbols.Soal.Float; break;
                    case "double": result = Symbols.Soal.Double; break;
                    case "decimal": result = Symbols.Soal.Double; break;
                    case "byte": result = Symbols.Soal.Byte; break;
                    case "unsignedByte": result = Symbols.Soal.Byte; break;
                    case "base64Binary": resultAs = this.byteArray; break;
                    case "hexBinary": resultAs = this.byteArray; break;
                    case "bool": result = Symbols.Soal.Bool; break;
                    case "boolean": result = Symbols.Soal.Bool; break;
                    case "time": result = Symbols.Soal.Time; break;
                    case "date": result = Symbols.Soal.Date; break;
                    case "dateTime": result = Symbols.Soal.DateTime; break;
                    case "duration": result = Symbols.Soal.TimeSpan; break;
                    case "gDay": result = Symbols.Soal.Date; break;
                    case "gMonth": result = Symbols.Soal.Date; break;
                    case "gMonthDay": result = Symbols.Soal.Date; break;
                    case "gYear": result = Symbols.Soal.Date; break;
                    case "gYearMonth": result = Symbols.Soal.Date; break;
                    default:
                        break;
                }
                if (resultAs == null && result != null)
                {
                    resultAs = result;
                }
                return resultAs;
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
                SoalType type = ns.Declarations.FirstOrDefault(d => d.Name == name.LocalName) as SoalType;
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

        private void RegisterReader(string uri, Importer.XmlReader reader)
        {
            HashSet<Importer.XmlReader> rs;
            if (!this.readers.TryGetValue(uri, out rs))
            {
                rs = new HashSet<Importer.XmlReader>();
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
                this.AddError("Unknown XML data.", uri, GetLinePositionSpan(root));
                return;
            }
        }

        private void CheckXsdTypes()
        {
            var types = this.Model.Objects.OfType<Struct>().ToList();
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
                        this.AddError("The property '" + type.Name + "." + prop.Name + "' has no type.", uri, SoalImporter.GetLinePositionSpan(elem));
                    }
                    else
                    {
                        SoalType originalType = null;
                        if (this.originalTypes.TryGetValue((IModelObject)prop, out originalType))
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
            var f = new SoalModelFactory(annot.MModel);
            Annotation toAnnot = f.Annotation();
            toAnnot.Name = annot.Name;
            foreach (var annotProp in annot.Properties)
            {
                AnnotationProperty toAnnotProp = f.AnnotationProperty();
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
                    AnnotationProperty annotProp = annot.Properties.FirstOrDefault(prop => prop.Name == propertyName);
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
                    AnnotationProperty annotProp = annot.Properties.FirstOrDefault(prop => prop.Name == propertyName);
                    if (annotProp != null)
                    {
                        to.SetAnnotationPropertyValue(targetAnnotationName, targetPropertyName, annotProp.Value);
                    }
                }
            }
        }

        internal static void CopyAnnotation(string name, AnnotatedElement from, AnnotatedElement to)
        {
            if (from == null) return;
            if (to == null) return;
            var f = new SoalModelFactory(to.MModel);
            foreach (var annot in from.Annotations)
            {
                if (annot.Name == name)
                {
                    Annotation toAnnot = f.Annotation();
                    toAnnot.Name = annot.Name;
                    to.Annotations.Add(toAnnot);
                    foreach (var annotProp in annot.Properties)
                    {
                        AnnotationProperty toAnnotProp = f.AnnotationProperty();
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
            var f = new SoalModelFactory(to.MModel);
            foreach (var annot in from.Annotations)
            {
                Annotation toAnnot = f.Annotation();
                toAnnot.Name = annot.Name;
                to.Annotations.Add(toAnnot);
                foreach (var annotProp in annot.Properties)
                {
                    AnnotationProperty toAnnotProp = f.AnnotationProperty();
                    toAnnotProp.Name = annotProp.Name;
                    toAnnotProp.Value = annotProp.Value;
                    toAnnot.Properties.Add(toAnnotProp);
                }
            }
        }

    }
}
