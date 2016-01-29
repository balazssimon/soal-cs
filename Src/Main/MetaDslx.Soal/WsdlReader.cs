using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MetaDslx.Soal
{
    internal class WsdlReader : XmlReader
    {
        public const string WsdlNamespace = "http://schemas.xmlsoap.org/wsdl/";
        private XNamespace xsd;
        private XNamespace wsdl;
        private XNamespace tns;

        public WsdlReader(SoalImporter importer, XDocument document, string uri)
            : base(importer, document, uri)
        {
        }

        public override void ImportPhase1()
        {
            xsd = XsdReader.XsdNamespace;
            wsdl = WsdlReader.WsdlNamespace;
            XAttribute tnsAttr = this.Document.Root.Attribute("targetNamespace");
            if (tnsAttr == null)
            {
                this.Importer.Diagnostics.AddError("The attribute 'targetNamespace' is missing from the root node of the XML.", this.Uri, this.GetTextSpan(this.Document.Root));
                return;
            }
            tns = tnsAttr.Value;
            this.Namespace = this.Importer.CreateNamespace(this, tnsAttr.Value, null, null);
            foreach (var elem in this.Document.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "types")
                    {

                    }
                }
                else
                {
                    // ignore
                }
            }
        }

        public override void ImportPhase2()
        {

        }

        public override void ImportPhase3()
        {

        }
    }
}
