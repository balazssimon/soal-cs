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
        public XDocument Document { get; private set; }
        public SoalImporter Importer { get; private set; }
        public Namespace Namespace { get; protected set; }

        public XmlReader(SoalImporter importer, XDocument document, string uri)
        {
            this.Importer = importer;
            this.Document = document;
            this.Uri = uri;
        }

        public TextSpan GetTextSpan(XObject xobj)
        {
            return SoalImporter.GetTextSpan(xobj);
        }

        public abstract void ImportPhase1();
        public abstract void ImportPhase2();
        public abstract void ImportPhase3();
    }
}
