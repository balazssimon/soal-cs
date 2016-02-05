using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace MetaDslx.Soal
{
    internal abstract class XmlReader
    {
        public string Uri { get; private set; }
        public XElement Root { get; private set; }
        public SoalImporter Importer { get; private set; }
        public Namespace Namespace { get; protected set; }

        public XmlReader(SoalImporter importer, XElement root, string uri)
        {
            this.Importer = importer;
            this.Root = root;
            this.Uri = uri;
        }

        public TextSpan GetTextSpan(XObject xobj)
        {
            return SoalImporter.GetTextSpan(xobj);
        }

        public XName GetXName(XElement elem, string reference)
        {
            string[] parts = reference.Split(':');
            if (parts.Length == 2)
            {
                XNamespace ns = elem.GetNamespaceOfPrefix(parts[0]);
                if (ns != null)
                {
                    return ns + parts[1];
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Invalid namespace prefix: " + parts[0], this.Uri, this.GetTextSpan(elem));
                    return null;
                }
            }
            else if (parts.Length == 1)
            {
                XNamespace ns = elem.GetDefaultNamespace();
                return ns + parts[0];
            }
            else
            {
                return null;
            }
        }

        protected void CopyAnnotation(string name, AnnotatedElement from, AnnotatedElement to)
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

        protected void CopyAnnotations(AnnotatedElement from, AnnotatedElement to)
        {
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

        public abstract void CollectImportedFiles();

        public virtual void LoadXsdFile()
        {
        }

        public virtual void LoadWsdlFile()
        {
        }
    }
}
