﻿using MetaDslx.Core;
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
    public class SoalImporter
    {
        private int namespaceCounter;
        private ArrayType byteArray;
        private Dictionary<string, XmlReader> readers = new Dictionary<string, XmlReader>();
        private Dictionary<string, Namespace> namespaces = new Dictionary<string, Namespace>();
        private Dictionary<XObject, ModelObject> objectsByElement = new Dictionary<XObject, ModelObject>();
        private Dictionary<XName, ModelObject> objectsByName = new Dictionary<XName, ModelObject>();
        private Dictionary<ModelObject, XObject> elementsByObject = new Dictionary<ModelObject, XObject>();

        public ModelCompilerDiagnostics Diagnostics { get; private set; }

        private SoalImporter(ModelCompilerDiagnostics diagnostics)
        {
            this.Diagnostics = diagnostics;
            this.namespaceCounter = 0;
            this.byteArray = SoalFactory.Instance.CreateArrayType();
            this.byteArray.InnerType = SoalInstance.Byte;
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
            foreach (var reader in importer.readers)
            {
                reader.Value.ImportPhase2();
            }
            foreach (var reader in importer.readers)
            {
                reader.Value.ImportPhase3();
            }
        }

        internal static TextSpan GetTextSpan(XObject xobj)
        {
            IXmlLineInfo info = xobj;
            return new TextSpan(info.LineNumber, info.LinePosition, info.LineNumber, info.LinePosition);
        }

        internal void ImportFile(string uri)
        {
            XDocument doc = XDocument.Load(uri, LoadOptions.SetBaseUri | LoadOptions.SetLineInfo);
            this.ImportXml(doc, uri);
        }

        internal void ImportRelativeFile(string currentUri, string relativeUri)
        {
            this.ImportFile(relativeUri);
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

        internal ModelObject RegisterObject(XmlReader reader, XName xname, XObject xobj, ModelObject obj, bool allowRename)
        {
            ModelObject oldObject = null;
            if (this.objectsByName.TryGetValue(xname, out oldObject))
            {
                if (!allowRename)
                {
                    XObject oldElem = this.elementsByObject[oldObject];
                    this.Diagnostics.AddError("Object '" + xname + "' is already imported from '" + oldElem.BaseUri + "' at '" + GetTextSpan(oldElem) + "'.", reader.Uri, GetTextSpan(xobj));
                }
                return null;
            }
            if (this.objectsByElement.TryGetValue(xobj, out oldObject))
            {
                XObject oldElem = this.elementsByObject[oldObject];
                this.Diagnostics.AddError("Object '" + xname + "' has already a type assigned to it.", reader.Uri, GetTextSpan(xobj));
                return null;
            }
            this.objectsByName.Add(xname, obj);
            this.objectsByElement.Add(xobj, obj);
            this.elementsByObject.Add(obj, xobj);
            return obj;
        }

        internal ModelObject GetObject(XName xname)
        {
            ModelObject result = null;
            this.objectsByName.TryGetValue(xname, out result);
            return result;
        }

        internal ModelObject GetObject(XObject xobj)
        {
            ModelObject result = null;
            this.objectsByElement.TryGetValue(xobj, out result);
            return result;
        }

        internal ModelObject Resolve(string uri, string name)
        {
            if (uri == XsdReader.XsdNamespace)
            {
                switch (name)
                {
                    case "any": return (ModelObject)SoalInstance.Object;
                    case "string": return (ModelObject)SoalInstance.String;
                    case "int": return (ModelObject)SoalInstance.Int;
                    case "long": return (ModelObject)SoalInstance.Long;
                    case "float": return (ModelObject)SoalInstance.Float;
                    case "double": return (ModelObject)SoalInstance.Double;
                    case "byte": return (ModelObject)SoalInstance.Byte;
                    case "base64Binary": return (ModelObject)this.byteArray;
                    case "bool": return (ModelObject)SoalInstance.Bool;
                    case "time": return (ModelObject)SoalInstance.Time;
                    case "date": return (ModelObject)SoalInstance.Date;
                    case "dateTime": return (ModelObject)SoalInstance.DateTime;
                    case "duration": return (ModelObject)SoalInstance.TimeSpan;
                    default:
                        break;
                }
                return null;
            }
            Namespace ns = this.GetNamespace(uri);
            if (ns != null)
            {
                IEnumerable<ModelObject> results = ModelCompilerContext.Current.ResolutionProvider.Resolve(new ModelObject[] { (ModelObject)ns }, ResolveKind.NameOrType, name, new ResolutionInfo(), ResolveFlags.Children);
                return results.FirstOrDefault();
            }
            return null;
        }

        private void ImportXml(XDocument doc, string uri)
        {
            if (readers.ContainsKey(uri)) return;
            if (doc.Root.Name.LocalName == "schema" && doc.Root.Name.NamespaceName == XsdReader.XsdNamespace)
            {
                XsdReader reader = new XsdReader(this, doc, uri);
                readers.Add(uri, reader);
                reader.ImportPhase1();
            }
            else if (doc.Root.Name.LocalName == "definitions" && doc.Root.Name.NamespaceName == WsdlReader.WsdlNamespace)
            {
                WsdlReader reader = new WsdlReader(this, doc, uri);
                readers.Add(uri, reader);
                reader.ImportPhase1();
            }
            else
            {
                this.Diagnostics.AddError("Unknown file format.", uri, new TextSpan());
            }
        }
    }
}