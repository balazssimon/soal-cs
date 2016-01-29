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
    internal class XsdReader : XmlReader
    {
        public const string XsdNamespace = "http://www.w3.org/2001/XMLSchema";
        private XNamespace xsd;
        private XNamespace tns;
        private List<XElement> definedElements;

        public XsdReader(SoalImporter importer, XDocument document, string uri)
            : base(importer, document, uri)
        {
        }

        public override void ImportPhase1()
        {
            xsd = XsdReader.XsdNamespace;
            XAttribute tnsAttr = this.Document.Root.Attribute("targetNamespace");
            if (tnsAttr == null)
            {
                this.Importer.Diagnostics.AddError("The attribute 'targetNamespace' is missing from the root node of the XML.", this.Uri, this.GetTextSpan(this.Document.Root));
                return;
            }
            tns = tnsAttr.Value;
            this.Namespace = this.Importer.CreateNamespace(this, tnsAttr.Value, null, null);
            definedElements = new List<XElement>();
            foreach (var elem in this.Document.Root.Elements())
            {
                if (elem.Name.Namespace == xsd)
                {
                    if (elem.Name.LocalName == "element")
                    {
                        //this.ImportPhase1Element(elem);
                    }
                    else if (elem.Name.LocalName == "simpleType")
                    {
                        this.ImportPhase1SimpleType(elem, null, false);
                    }
                    else if (elem.Name.LocalName == "complexType")
                    {
                        this.ImportPhase1ComplexType(elem, null, false);
                    }
                    else
                    {
                        this.Importer.Diagnostics.AddError("Unexpected element.", this.Uri, this.GetTextSpan(elem));
                    }
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Unexpected element.", this.Uri, this.GetTextSpan(elem));
                }
            }
        }

        public override void ImportPhase2()
        {
            if (tns == null) return;
            foreach (var elem in this.Document.Root.Elements())
            {
                if (elem.Name.Namespace == xsd)
                {
                    if (elem.Name.LocalName == "element")
                    {
                        this.ImportPhase2Element(elem);
                    }
                    else if (elem.Name.LocalName == "simpleType")
                    {
                        //this.ImportPhase2SimpleType(elem, null);
                    }
                    else if (elem.Name.LocalName == "complexType")
                    {
                        //this.ImportPhase2ComplexType(elem, null);
                    }
                }
            }
        }

        public override void ImportPhase3()
        {
            if (tns == null) return;
            foreach (var elem in definedElements)
            {
                if (elem.Name.LocalName == "simpleType")
                {
                    //this.ImportPhase3SimpleType(elem, null);
                }
                else if (elem.Name.LocalName == "complexType")
                {
                    ModelObject mo = this.Importer.GetObject(elem);
                    Struct st = mo as Struct;
                    this.ImportPhase3ComplexType(st, elem);
                }
            }
        }

        private string GetUniqueName(string name, bool allowRename)
        {
            if (allowRename && this.Importer.Resolve(this.Uri, name) != null)
            {
                int counter = 0;
                while (this.Importer.Resolve(this.Uri, name + counter) != null)
                {
                    ++counter;
                }
                return name + counter;
            }
            return name;
        }

        private SoalType ImportPhase1SimpleType(XElement elem, string name, bool allowRename)
        {
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            if (nameAttr != null)
            {
                name = nameAttr.Value;
            }
            if (name == null)
            {
                this.Importer.Diagnostics.AddError("The simpleType has no name.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            XElement restriction = elem.Element(xsd + "restriction");
            if (restriction != null)
            {
                XAttribute baseAttr = restriction.Attribute("base");
                if (baseAttr != null)
                {
                    string baseValue = baseAttr.Value;
                    string[] parts = baseValue.Split(':');
                    bool stringBased = false;
                    if (parts.Length == 2)
                    {
                        XNamespace baseNs = restriction.GetNamespaceOfPrefix(parts[0]);
                        if (baseNs == xsd && parts[1] == "string")
                        {
                            stringBased = true;
                        }
                    }
                    else if (parts.Length == 1)
                    {
                        XNamespace baseNs = restriction.GetDefaultNamespace();
                        if (baseNs == xsd && parts[0] == "string")
                        {
                            stringBased = true;
                        }
                    }
                    else
                    {
                        this.Importer.Diagnostics.AddError("Invalid base type: '" + baseValue + "'", this.Uri, this.GetTextSpan(baseAttr));
                        return null;
                    }
                    if (stringBased)
                    {
                        IEnumerable<XElement> enums = restriction.Elements(xsd + "enumeration");
                        if (enums.Any())
                        {
                            Enum enm = SoalFactory.Instance.CreateEnum();
                            name = this.GetUniqueName(name, allowRename);
                            if (this.Importer.RegisterObject(this, tns + name, elem, (ModelObject)enm, allowRename) != null)
                            {
                                this.definedElements.Add(elem);
                                enm.Name = name;
                                enm.Namespace = this.Namespace;
                                foreach (var enumValue in enums)
                                {
                                    XAttribute valueAttr = enumValue.Attribute("value");
                                    if (valueAttr != null)
                                    {
                                        string value = valueAttr.Value;
                                        EnumLiteral enmLit = SoalFactory.Instance.CreateEnumLiteral();
                                        enmLit.Name = value;
                                        enm.EnumLiterals.Add(enmLit);
                                    }
                                    else
                                    {
                                        this.Importer.Diagnostics.AddError("The enumeration has no 'value' attribute.", this.Uri, this.GetTextSpan(restriction));
                                        return null;
                                    }
                                }
                                return enm;
                            }
                            else
                            {
                                ModelContext.Current.RemoveInstance((ModelObject)enm);
                            }
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddWarning("The importer of this element is not implemented.", this.Uri, this.GetTextSpan(elem));
                            return null;
                        }
                    }
                }
                else
                {
                    this.Importer.Diagnostics.AddError("The restriction has no 'base' attribute.", this.Uri, this.GetTextSpan(restriction));
                    return null;
                }
            }
            else
            {
                this.Importer.Diagnostics.AddWarning("The importer of this element is not implemented.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            return null;
        }

        private SoalType ImportPhase1ComplexType(XElement elem, string name, bool allowRename)
        {
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            if (nameAttr != null)
            {
                name = nameAttr.Value;
            }
            if (name == null)
            {
                this.Importer.Diagnostics.AddError("The complexType has no name.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            Struct st = SoalFactory.Instance.CreateStruct();
            name = this.GetUniqueName(name, allowRename);
            if (this.Importer.RegisterObject(this, tns + name, elem, (ModelObject)st, allowRename) != null)
            {
                this.definedElements.Add(elem);
                st.Name = name;
                st.Namespace = this.Namespace;
                XElement sequenceElem = elem.Element(xsd + "sequence");
                XElement choiceElem = elem.Element(xsd + "choice");
                XElement allElem = elem.Element(xsd + "all");
                XElement complexElem = null;
                if (sequenceElem != null)
                {
                    complexElem = sequenceElem;
                }
                else if (choiceElem != null)
                {
                    complexElem = choiceElem;
                }
                else if (allElem != null)
                {
                    complexElem = allElem;
                }
                else
                {
                    this.Importer.Diagnostics.AddError("The complexType has invalid content.", this.Uri, this.GetTextSpan(elem));
                    return null;
                }
                return st;
            }
            else
            {
                ModelContext.Current.RemoveInstance((ModelObject)st);
            }
            return null;
        }

        private SoalType ImportPhase2Element(XElement elem)
        {
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            string name = null;
            if (nameAttr != null)
            {
                name = nameAttr.Value;
            }
            if (name == null)
            {
                this.Importer.Diagnostics.AddError("The element has no name.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            if (typeAttr == null)
            {
                XElement simpleType = elem.Element(xsd + "simpleType");
                XElement complexType = elem.Element(xsd + "complexType");
                if (simpleType != null)
                {
                    return this.ImportPhase1SimpleType(simpleType, name, true);
                }
                else if (complexType != null)
                {
                    return this.ImportPhase1ComplexType(complexType, name, true);
                }
                else
                {
                    this.Importer.Diagnostics.AddError("The element has no type.", this.Uri, this.GetTextSpan(elem));
                    return null;
                }
            }
            else
            {
                string typeValue = typeAttr.Value;
                string[] parts = typeValue.Split(':');
                if (parts.Length == 2)
                {
                    XNamespace baseNs = elem.GetNamespaceOfPrefix(parts[0]);
                    SoalType type = this.Importer.Resolve(baseNs.NamespaceName, parts[1]) as SoalType;
                    if (type == null)
                    {
                        this.Importer.Diagnostics.AddError("Could not resolve type '" + typeValue + "'.", this.Uri, this.GetTextSpan(typeAttr));
                    }
                    return type;
                }
                else if (parts.Length == 1)
                {
                    XNamespace baseNs = elem.GetDefaultNamespace();
                    SoalType type = this.Importer.Resolve(baseNs.NamespaceName, parts[0]) as SoalType;
                    if (type == null)
                    {
                        this.Importer.Diagnostics.AddError("Could not resolve type '" + typeValue + "'.", this.Uri, this.GetTextSpan(typeAttr));
                    }
                    return type;
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Invalid type reference: '" + typeValue + "'", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
            }
        }

        private SoalType ImportPhase3ComplexType(Struct st, XElement elem)
        {
            XElement sequenceElem = elem.Element(xsd + "sequence");
            XElement choiceElem = elem.Element(xsd + "choice");
            XElement allElem = elem.Element(xsd + "all");
            XElement complexElem = null;
            if (sequenceElem != null)
            {
                complexElem = sequenceElem;
            }
            else if (choiceElem != null)
            {
                complexElem = choiceElem;
                this.Importer.Diagnostics.AddWarning("The 'choice' type is not yet supported by SOAL. It will be parsed as 'sequence'.", this.Uri, this.GetTextSpan(choiceElem));
            }
            else if (allElem != null)
            {
                complexElem = allElem;
                this.Importer.Diagnostics.AddWarning("The 'all' type is not yet supported by SOAL. It will be parsed as 'sequence'.", this.Uri, this.GetTextSpan(allElem));
            }
            else
            {
                return null;
            }
            foreach (var child in complexElem.Elements())
            {
                if (child.Name.Namespace == xsd)
                {
                    if (child.Name.LocalName == "element")
                    {
                        Property prop = this.ImportPhase3Element(st, child);
                        st.Properties.Add(prop);
                    }
                }
            }
            return st;
        }

        private Property ImportPhase3Element(Struct st, XElement elem)
        {
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            string name = null;
            if (nameAttr != null)
            {
                name = nameAttr.Value;
            }
            if (name == null)
            {
                this.Importer.Diagnostics.AddError("The element has no name.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            SoalType type = null;
            if (typeAttr == null)
            {
                XElement simpleType = elem.Element(xsd + "simpleType");
                XElement complexType = elem.Element(xsd + "complexType");
                if (simpleType != null)
                {
                    type = this.ImportPhase1SimpleType(simpleType, name, true);
                }
                else if (complexType != null)
                {
                    type = this.ImportPhase1ComplexType(complexType, name, true);
                    Struct childSt = type as Struct;
                    if (childSt != null)
                    {
                        type = this.ImportPhase3ComplexType(childSt, complexType);
                    }
                }
                else
                {
                    this.Importer.Diagnostics.AddError("The element has no type.", this.Uri, this.GetTextSpan(elem));
                    return null;
                }
            }
            else
            {
                string typeValue = typeAttr.Value;
                string[] parts = typeValue.Split(':');
                if (parts.Length == 2)
                {
                    XNamespace baseNs = elem.GetNamespaceOfPrefix(parts[0]);
                    type = this.Importer.Resolve(baseNs.NamespaceName, parts[1]) as SoalType;
                }
                else if (parts.Length == 1)
                {
                    XNamespace baseNs = elem.GetDefaultNamespace();
                    type = this.Importer.Resolve(baseNs.NamespaceName, parts[0]) as SoalType;
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Invalid type reference: '" + typeValue + "'", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
                if (type == null)
                {
                    this.Importer.Diagnostics.AddError("Could not resolve type '" + typeValue + "'.", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
            }
            XAttribute nillableAttr = elem.Attribute("nillable");
            XAttribute minOccursAttr = elem.Attribute("minOccurs");
            XAttribute maxOccursAttr = elem.Attribute("maxOccurs");
            bool nillable = false;
            int minOccurs = 1;
            int maxOccurs = 1;
            if (nillableAttr != null)
            {
                nillable = nillableAttr.Value == "1" || nillableAttr.Value.ToLower() == "true";
            }
            if (minOccursAttr != null)
            {
                if (!int.TryParse(minOccursAttr.Value, out minOccurs))
                {
                    minOccurs = 1;
                }
            }
            if (maxOccursAttr != null)
            {
                if (maxOccursAttr.Value.ToLower() == "unbounded")
                {
                    maxOccurs = -1;
                }
                else if (!int.TryParse(maxOccursAttr.Value, out maxOccurs))
                {
                    maxOccurs = 1;
                }
            }
            Property prop = SoalFactory.Instance.CreateProperty();
            prop.Name = name;
            if (maxOccurs < 0 || maxOccurs > 1)
            {
                ArrayType array = SoalFactory.Instance.CreateArrayType();
                array.InnerType = type;
                type = array;
            }
            if (type is PrimitiveType)
            {
                if (nillable && type != SoalInstance.Object && type != SoalInstance.String)
                {
                    NullableType nullable = SoalFactory.Instance.CreateNullableType();
                    nullable.InnerType = type;
                    type = nullable;
                }
                else if (!nillable && (type == SoalInstance.Object || type == SoalInstance.String))
                {
                    NonNullableType nonNull = SoalFactory.Instance.CreateNonNullableType();
                    nonNull.InnerType = type;
                    type = nonNull;
                }
            }
            else
            {
                if (!nillable)
                {
                    NonNullableType nonNull = SoalFactory.Instance.CreateNonNullableType();
                    nonNull.InnerType = type;
                    type = nonNull;
                }
            }
            prop.Type = type;
            prop.Parent = st;
            return prop;
        }
    }
}