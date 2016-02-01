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
                return ns + parts[1];
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

        // XSD types:
        public virtual void ImportPhase1()
        {
        }

        // XSD simple type restriction base:
        public virtual void ImportPhase2()
        {
        }

        // XSD elements:
        public virtual void ImportPhase3()
        {
        }

        // XSD type structure:
        public virtual void ImportPhase4()
        {
        }

        // WSDL messages and policies:
        public virtual void ImportPhase5()
        {
        }

        // WSDL portTypes:
        public virtual void ImportPhase6()
        {
        }

        // WSDL bindings:
        public virtual void ImportPhase7()
        {
        }

        // WSDL services:
        public virtual void ImportPhase8()
        {
        }
    }
}
