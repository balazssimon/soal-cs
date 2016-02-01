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
        where TXObject : XObject
    {
        private string name;
        private SoalImporter importer;
        private Dictionary<XObject, TObject> objectsByElement = new Dictionary<XObject, TObject>();
        private Dictionary<XName, TObject> objectsByName = new Dictionary<XName, TObject>();
        private Dictionary<TObject, TXObject> elementsByObject = new Dictionary<TObject, TXObject>();

        public ObjectStorage(string name, SoalImporter importer)
        {
            this.name = name;
            this.importer = importer;
        }

        internal object Register(XmlReader reader, XName xname, TXObject xobj, TObject obj)
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
            /*TXObject oldXObject = null;
            if (this.elementsByObject.TryGetValue(obj, out oldXObject))
            {
                this.importer.Diagnostics.AddError("The object is alredy registered to " + this.name + " '" + xname + "'.", reader.Uri, SoalImporter.GetTextSpan(xobj));
                return null;
            }*/
            this.objectsByName.Add(xname, obj);
            this.objectsByElement.Add(xobj, obj);
            if (!this.elementsByObject.ContainsKey(obj))
            {
                this.elementsByObject.Add(obj, xobj);
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

        internal TObject Get(XObject xobj)
        {
            if (xobj == null) return null;
            TObject result = null;
            this.objectsByElement.TryGetValue(xobj, out result);
            return result;
        }

        internal TXObject GetX(XName xname)
        {
            if (xname == null) return null;
            TObject obj = null;
            if (xname != null)
            {
                this.objectsByName.TryGetValue(xname, out obj);
            }
            TXObject xobj = null;
            if (obj != null)
            {
                this.elementsByObject.TryGetValue(obj, out xobj);
            }
            return xobj;
        }

    }

    public class SoalImporter
    {
        private int namespaceCounter;
        private ArrayType byteArray;
        private Dictionary<string, HashSet<XmlReader>> readers = new Dictionary<string, HashSet<XmlReader>>();
        private Dictionary<string, Namespace> namespaces = new Dictionary<string, Namespace>();
        private Dictionary<SoalType, SoalType> replacementTypes = new Dictionary<SoalType, SoalType>();
        private Dictionary<SoalType, SoalType> exceptionTypes = new Dictionary<SoalType, SoalType>();
        private HashSet<SoalType> typesToRemove = new HashSet<SoalType>();
        private Dictionary<XName, WsdlMessage> messagesByName = new Dictionary<XName, WsdlMessage>();

        public ModelCompilerDiagnostics Diagnostics { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdTypes { get; private set; }
        internal ObjectStorage<SoalType, XElement> XsdElements { get; private set; }
        internal ObjectStorage<WsdlMessage, XElement> WsdlMessages { get; private set; }

        private SoalImporter(ModelCompilerDiagnostics diagnostics)
        {
            this.Diagnostics = diagnostics;
            this.namespaceCounter = 0;
            this.byteArray = SoalFactory.Instance.CreateArrayType();
            this.byteArray.InnerType = SoalInstance.Byte;
            this.XsdTypes = new ObjectStorage<SoalType, XElement>("type", this);
            this.XsdElements = new ObjectStorage<SoalType, XElement>("element", this);
            this.WsdlMessages = new ObjectStorage<WsdlMessage, XElement>("message", this);
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
            ImportPhase2(importer);
            ImportPhase3(importer);
            ImportPhase4(importer);
            ImportPhase5(importer);
            ImportPhase6(importer);
            ImportPhase7(importer);
            foreach (var type in importer.typesToRemove)
            {
                Declaration decl = type as Declaration;
                if (decl != null)
                {
                    decl.Namespace = null;
                    ModelContext.Current.RemoveInstance((ModelObject)decl);
                }
            }
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

        private static void ImportPhase2(SoalImporter importer)
        {
            foreach (var reader in importer.readers)
            {
                foreach (var r in reader.Value)
                {
                    r.ImportPhase2();
                }
            }
        }

        private static void ImportPhase3(SoalImporter importer)
        {
            foreach (var reader in importer.readers)
            {
                foreach (var r in reader.Value)
                {
                    r.ImportPhase3();
                }
            }
        }

        private static void ImportPhase4(SoalImporter importer)
        {
            foreach (var reader in importer.readers)
            {
                foreach (var r in reader.Value)
                {
                    r.ImportPhase4();
                }
            }
        }

        private static void ImportPhase5(SoalImporter importer)
        {
            foreach (var reader in importer.readers)
            {
                foreach (var r in reader.Value)
                {
                    r.ImportPhase5();
                }
            }
        }

        private static void ImportPhase6(SoalImporter importer)
        {
            foreach (var reader in importer.readers)
            {
                foreach (var r in reader.Value)
                {
                    r.ImportPhase6();
                }
            }
        }

        private static void ImportPhase7(SoalImporter importer)
        {
            foreach (var reader in importer.readers)
            {
                foreach (var r in reader.Value)
                {
                    r.ImportPhase7();
                }
            }
        }


        internal static TextSpan GetTextSpan(XObject xobj)
        {
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
            Uri uri;
            if (Uri.TryCreate(relativeUri, UriKind.Absolute, out uri))
            {
                this.ImportFile(uri.AbsoluteUri);
                return;
            }
            else
            {
                string baseUriStr = currentUri.Substring(0, currentUri.LastIndexOf('/') + 1);
                Uri baseUri;
                if (Uri.TryCreate(baseUriStr, UriKind.Absolute, out baseUri))
                {
                    if (Uri.TryCreate(baseUri, relativeUri, out uri))
                    {
                        this.ImportFile(uri.AbsoluteUri);
                        return;
                    }
                    else
                    {
                        this.Diagnostics.AddError("Invalid relative URI in import '" + relativeUri + "'.", currentUri, new TextSpan());
                        return;
                    }
                }
                else
                {
                    if (Path.IsPathRooted(relativeUri))
                    {
                        this.ImportFile(relativeUri);
                        return;
                    }
                    else
                    {
                        string absoluteUri = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(currentUri), relativeUri));
                        this.ImportFile(absoluteUri);
                        return;
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
                IEnumerable<ModelObject> nextScope = ModelCompilerContext.Current.ResolutionProvider.Resolve(currentScope, ResolveKind.Name, names[0], new ResolutionInfo(), ResolveFlags.Children);
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

        internal void RegisterReplacementType(SoalType from, SoalType to)
        {
            if (!replacementTypes.ContainsKey(from))
            {
                this.replacementTypes.Add(from, to);
                this.typesToRemove.Add(from);
            }
        }

        internal void RegisterExceptionType(SoalType from, SoalType to)
        {
            if (!exceptionTypes.ContainsKey(from))
            {
                this.exceptionTypes.Add(from, to);
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

        internal SoalType GetExceptionType(SoalType original)
        {
            SoalType result = null;
            this.exceptionTypes.TryGetValue(original, out result);
            return result;
        }

        internal SoalType ResolveXsdPrimitiveType(string uri, string name)
        {
            if (uri == XsdReader.XsdNamespace)
            {
                switch (name)
                {
                    case "any": return SoalInstance.Object;
                    case "string": return SoalInstance.String;
                    case "int": return SoalInstance.Int;
                    case "long": return SoalInstance.Long;
                    case "float": return SoalInstance.Float;
                    case "double": return SoalInstance.Double;
                    case "byte": return SoalInstance.Byte;
                    case "base64Binary": return this.byteArray;
                    case "bool": return SoalInstance.Bool;
                    case "time": return SoalInstance.Time;
                    case "date": return SoalInstance.Date;
                    case "dateTime": return SoalInstance.DateTime;
                    case "duration": return SoalInstance.TimeSpan;
                    default:
                        break;
                }
            }
            return null;
        }

        internal SoalType ResolveXsdType(string uri, string name)
        {
            if (uri == XsdReader.XsdNamespace)
            {
                return this.ResolveXsdPrimitiveType(uri, name);
            }
            Namespace ns = this.GetNamespace(uri);
            if (ns != null)
            {
                IEnumerable<ModelObject> results = ModelCompilerContext.Current.ResolutionProvider.Resolve(new ModelObject[] { (ModelObject)ns }, ResolveKind.NameOrType, name, new ResolutionInfo(), ResolveFlags.Children);
                ModelObject result = results.FirstOrDefault();
                SoalType type = result as SoalType;
                return this.ResolveXsdReplacementType(type);
            }
            return null;
        }

        internal SoalType ResolveXsdReplacementType(SoalType type)
        {
            SoalType replacementType;
            if (type != null && this.replacementTypes.TryGetValue(type, out replacementType))
            {
                return replacementType;
            }
            return type;
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
                reader.ImportPhase1();
            }
            else if (root.Name.LocalName == "definitions" && root.Name.NamespaceName == WsdlReader.WsdlNamespace)
            {
                WsdlReader reader = new WsdlReader(this, root, uri);
                this.RegisterReader(uri, reader);
                reader.ImportPhase1();
            }
            else
            {
                this.Diagnostics.AddError("Unknown XML data.", uri, GetTextSpan(root));
                return;
            }
        }
    }
}
