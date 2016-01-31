using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MetaDslx.Soal
{
    internal class WsdlMessagePart
    {
        public string Name { get; set; }
        public SoalType Type { get; set; }
    }

    internal class WsdlMessage
    {
        public string Name { get; set; }
        public List<WsdlMessagePart> Parts { get; private set; }

        public WsdlMessage()
        {
            this.Parts = new List<WsdlMessagePart>();
        }
    }



    internal class WsdlReader : XmlReader
    {
        public const string WsdlNamespace = "http://schemas.xmlsoap.org/wsdl/";
        public const string WspNamespace = "http://www.w3.org/ns/ws-policy";
        private XNamespace xsd;
        private XNamespace wsdl;
        private XNamespace tns;

        public WsdlReader(SoalImporter importer, XElement root, string uri)
            : base(importer, root, uri)
        {
        }

        public override void ImportPhase1()
        {
            xsd = XsdReader.XsdNamespace;
            wsdl = WsdlReader.WsdlNamespace;
            XAttribute tnsAttr = this.Root.Attribute("targetNamespace");
            if (tnsAttr == null)
            {
                this.Importer.Diagnostics.AddError("The attribute 'targetNamespace' is missing from the root node of the XML.", this.Uri, this.GetTextSpan(this.Root));
                return;
            }
            tns = tnsAttr.Value;
            this.Namespace = this.Importer.CreateNamespace(this, tnsAttr.Value, null, null);
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "import")
                    {
                        XAttribute locAttribute = elem.Attribute("location");
                        if (locAttribute != null)
                        {
                            string location = locAttribute.Value;
                            this.Importer.ImportRelativeFile(this.Uri, location);
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Attribute 'location' is missing from import.", this.Uri, this.GetTextSpan(elem));
                        }
                    }
                    else if (elem.Name.LocalName == "types")
                    {
                        foreach (var schema in elem.Elements(xsd + "schema"))
                        {
                            this.Importer.ImportXml(schema, this.Uri);
                        }
                    }
                }
                else
                {
                    // ignore
                }
            }
        }

        public override void ImportPhase4()
        {
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "message")
                    {
                        XAttribute nameAttr = elem.Attribute("name");
                        if (nameAttr != null)
                        {
                            WsdlMessage msg = new WsdlMessage();
                            msg.Name = nameAttr.Value;
                            if (this.Importer.WsdlMessages.Register(this, tns + msg.Name, elem, msg) != null)
                            {
                                foreach (var partElem in elem.Elements(wsdl+"part"))
                                {
                                    SoalType partType = null;
                                    XAttribute partNameAttr = partElem.Attribute("name");
                                    XAttribute partXsdTypeAttr = partElem.Attribute("type");
                                    XAttribute partXsdElemAttr = partElem.Attribute("element");
                                    if (partNameAttr != null)
                                    {
                                        if (partXsdElemAttr != null)
                                        {
                                            partType = this.Importer.XsdElements.Get(this.GetXName(partElem, partXsdElemAttr.Value));
                                        }
                                        else if (partXsdTypeAttr != null)
                                        {
                                            XName typeRefName = this.GetXName(partElem, partXsdTypeAttr.Value);
                                            if (typeRefName != null)
                                            {
                                                partType = this.Importer.ResolveXsdType(typeRefName.NamespaceName, typeRefName.LocalName);
                                            }
                                        }
                                        if (partType == null)
                                        {
                                            this.Importer.Diagnostics.AddError("Could not resolve the type of the message part.", this.Uri, this.GetTextSpan(partElem));
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        this.Importer.Diagnostics.AddError("Message part has no 'name' attribute.", this.Uri, this.GetTextSpan(partElem));
                                        continue;
                                    }
                                    WsdlMessagePart part = new WsdlMessagePart();
                                    part.Name = partNameAttr.Value;
                                    part.Type = partType;
                                    msg.Parts.Add(part);
                                }
                            }
                            if (msg.Parts.Count != 1)
                            {
                                this.Importer.Diagnostics.AddWarning("The message must have exactly one part (TODO).", this.Uri, this.GetTextSpan(elem));
                                continue;
                            }
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Message has no 'name' attribute.", this.Uri, this.GetTextSpan(elem));
                            continue;
                        }
                    }
                }
                if (elem.Name.NamespaceName == WsdlReader.WspNamespace)
                {
                    if (elem.Name.LocalName == "Policy")
                    {
                        // TODO
                    }
                }
            }
        }

        public override void ImportPhase5()
        {
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "portType")
                    {
                    }
                }
            }
        }

        public override void ImportPhase6()
        {
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "binding")
                    {
                    }
                }
            }
        }

        public override void ImportPhase7()
        {
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "service")
                    {
                    }
                }
            }
        }
    }
}
