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
    internal enum XsdTypeKind
    {
        Type,
        Element,
        Attribute
    }

    internal class XsdReader : XmlReader
    {
        public const string XsdNamespace = "http://www.w3.org/2001/XMLSchema";
        private XNamespace xsd;
        private XNamespace tns;
        private List<XElement> definedElements;

        public XsdReader(SoalImporter importer, XElement root, string uri)
            : base(importer, root, uri)
        {
        }

        public override void ImportPhase1()
        {
            xsd = XsdReader.XsdNamespace;
            XAttribute tnsAttr = this.Root.Attribute("targetNamespace");
            if (tnsAttr != null)
            {
                tns = tnsAttr.Value;
                this.Namespace = this.Importer.CreateNamespace(this, tnsAttr.Value, null, null);
            }
            else
            {
                tns = string.Empty;
                this.Namespace = this.Importer.CreateNamespace(this, string.Empty, null, null);
            }
            definedElements = new List<XElement>();
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.Namespace == xsd)
                {
                    if (elem.Name.LocalName == "import")
                    {
                        XAttribute locAttribute = elem.Attribute("schemaLocation");
                        if (locAttribute != null)
                        {
                            string location = locAttribute.Value;
                            this.Importer.ImportRelativeFile(this.Uri, location);
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Attribute 'schemaLocation' is missing from import.", this.Uri, this.GetTextSpan(elem));
                        }
                    }
                    else if (elem.Name.LocalName == "element")
                    {
                        //this.ImportPhase3Element(elem);
                    }
                    else if (elem.Name.LocalName == "attribute")
                    {
                        //this.ImportPhase3Attribute(elem);
                    }
                    else if (elem.Name.LocalName == "simpleType")
                    {
                        this.ImportPhase1SimpleType(elem, null, XsdTypeKind.Type, null, true);
                    }
                    else if (elem.Name.LocalName == "complexType")
                    {
                        this.ImportPhase1ComplexType(elem, null, XsdTypeKind.Type, null, true);
                    }
                    else
                    {
                        //this.Importer.Diagnostics.AddError("Unexpected element.", this.Uri, this.GetTextSpan(elem));
                    }
                }
                else
                {
                    //this.Importer.Diagnostics.AddError("Unexpected element.", this.Uri, this.GetTextSpan(elem));
                }
            }
        }

        public override void ImportPhase2()
        {
            if (tns == null) return;
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.Namespace == xsd)
                {
                    if (elem.Name.LocalName == "element")
                    {
                        //this.ImportPhase3Element(elem);
                    }
                    else if (elem.Name.LocalName == "attribute")
                    {
                        //this.ImportPhase3Attribute(elem);
                    }
                    else if (elem.Name.LocalName == "simpleType")
                    {
                        PrimitiveType type = this.Importer.XsdTypes.Get(elem) as PrimitiveType;
                        if (type != null)
                        {
                            this.ImportPhase2SimpleType(type, elem);
                        }
                    }
                    else if (elem.Name.LocalName == "complexType")
                    {
                        Struct type = this.Importer.XsdTypes.Get(elem) as Struct;
                        if (type != null)
                        {
                            this.ImportPhase2ComplexType(type, elem);
                        }
                    }
                }
            }
        }

        public override void ImportPhase3()
        {
            if (tns == null) return;
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.Namespace == xsd)
                {
                    if (elem.Name.LocalName == "element")
                    {
                        this.ImportPhase3Element(elem);
                    }
                    else if (elem.Name.LocalName == "attribute")
                    {
                        this.ImportPhase3Attribute(elem);
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

        public override void ImportPhase4()
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
                    SoalType mo = this.Importer.XsdTypes.Get(elem);
                    Struct st = mo as Struct;
                    if (st != null)
                    {
                        this.ImportPhase4ComplexType(st, elem);
                    }
                }
                else if (elem.Name.LocalName == "element")
                {
                    SoalType mo = this.Importer.XsdElements.Get(elem);
                    Struct st = mo as Struct;
                    if (st != null)
                    {
                        this.ImportPhase4Element(st, elem);
                    }
                }
            }
        }

        private string GetUniqueName(string name, bool allowRename)
        {
            if (allowRename && this.Importer.ResolveXsdType(this.Uri, name) != null)
            {
                int counter = 0;
                while (this.Importer.ResolveXsdType(this.Uri, name + counter) != null)
                {
                    ++counter;
                }
                return name + counter;
            }
            return name;
        }

        private SoalType ImportPhase1SimpleType(XElement elem, string name, XsdTypeKind kind, XElement parentElem, bool register)
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
                    XName baseRef = this.GetXName(restriction, baseAttr.Value);
                    if (baseRef == null)
                    {
                        this.Importer.Diagnostics.AddError("Invalid base type: '" + baseAttr.Value + "'", this.Uri, this.GetTextSpan(baseAttr));
                        return null;
                    }
                    bool stringBased = baseRef.Namespace == xsd && baseRef.LocalName == "string";
                    if (stringBased)
                    {
                        IEnumerable<XElement> enums = restriction.Elements(xsd + "enumeration");
                        if (enums.Any())
                        {
                            Enum enm = SoalFactory.Instance.CreateEnum();
                            //name = this.GetUniqueName(name, element);
                            if (!register || (kind == XsdTypeKind.Type && this.Importer.XsdTypes.Register(this, tns + name, elem, enm) != null) ||
                                (kind == XsdTypeKind.Element && this.Importer.XsdElements.Register(this, tns + name, parentElem, enm) != null) ||
                                (kind == XsdTypeKind.Attribute && this.Importer.XsdAttributes.Register(this, tns + name, parentElem, enm) != null))
                            {
                                if (register)
                                {
                                    if (kind == XsdTypeKind.Type)
                                    {
                                        this.definedElements.Add(elem);
                                    }
                                    else
                                    {
                                        this.definedElements.Add(parentElem);
                                    }
                                }
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
                    }
                }
                else
                {
                    this.Importer.Diagnostics.AddWarning("The restriction has no 'base' attribute.", this.Uri, this.GetTextSpan(restriction));
                }
            }
            else
            {
                this.Importer.Diagnostics.AddWarning("The importer of this element is not implemented.", this.Uri, this.GetTextSpan(elem));
            }
            if (register)
            {
                PrimitiveType type = SoalFactory.Instance.CreatePrimitiveType();
                type.Name = name;
                type.Namespace = this.Namespace;
                switch (kind)
                {
                    case XsdTypeKind.Type:
                        return this.Importer.XsdTypes.Register(this, tns + name, elem, type);
                    case XsdTypeKind.Element:
                        return this.Importer.XsdElements.Register(this, tns + name, parentElem, type);
                    case XsdTypeKind.Attribute:
                        return this.Importer.XsdAttributes.Register(this, tns + name, parentElem, type);
                    default:
                        break;
                }
            }
            return null;
        }

        private SoalType ImportPhase1ComplexType(XElement elem, string name, XsdTypeKind kind, XElement parentElem, bool register)
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
            //name = this.GetUniqueName(name, element);
            if (!register || (kind == XsdTypeKind.Type && this.Importer.XsdTypes.Register(this, tns + name, elem, st) != null) ||
                (kind == XsdTypeKind.Element && this.Importer.XsdElements.Register(this, tns + name, parentElem, st) != null) ||
                (kind == XsdTypeKind.Attribute && this.Importer.XsdAttributes.Register(this, tns + name, parentElem, st) != null))
            {
                if (register)
                {
                    if (kind == XsdTypeKind.Type)
                    {
                        this.definedElements.Add(elem);
                    }
                    else
                    {
                        this.definedElements.Add(parentElem);
                    }
                }
                st.Name = name;
                st.Namespace = this.Namespace;
                XElement sequenceElem = elem.Element(xsd + "sequence");
                XElement choiceElem = elem.Element(xsd + "choice");
                XElement allElem = elem.Element(xsd + "all");
                XElement complexElem = null;
                if (sequenceElem != null)
                {
                    complexElem = sequenceElem;
                    List<XElement> children = sequenceElem.Elements(xsd + "element").ToList();
                    if (children.Count == 1)
                    {
                        XElement child = children[0];
                        XAttribute refAttr = child.Attribute("ref");
                        if (refAttr == null)
                        {
                            XAttribute nillableAttr = child.Attribute("nillable");
                            XAttribute minOccursAttr = child.Attribute("minOccurs");
                            XAttribute maxOccursAttr = child.Attribute("maxOccurs");
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
                            if (maxOccurs < 0 || maxOccurs > 1)
                            {
                                ArrayType array = SoalFactory.Instance.CreateArrayType();
                                this.Importer.RegisterReplacementType(st, array);
                            }
                        }
                    }
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
                    //this.Importer.Diagnostics.AddError("The complexType has invalid content.", this.Uri, this.GetTextSpan(elem));
                    //return null;
                }
                return st;
            }
            else
            {
                ModelContext.Current.RemoveInstance((ModelObject)st);
            }
            return null;
        }

        private SoalType ImportPhase2SimpleType(PrimitiveType pt, XElement elem)
        {
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            XElement restriction = elem.Element(xsd + "restriction");
            if (restriction != null)
            {
                XAttribute baseAttr = restriction.Attribute("base");
                if (baseAttr != null)
                {
                    XName baseRef = this.GetXName(restriction, baseAttr.Value);
                    if (baseRef == null)
                    {
                        return null;
                    }
                    SoalType type = this.Importer.ResolveXsdType(baseRef.NamespaceName, baseRef.LocalName);
                    bool stringBased = type == SoalInstance.String; //baseRef.Namespace == xsd && baseRef.LocalName == "string";
                    if (stringBased)
                    {
                        IEnumerable<XElement> enums = restriction.Elements(xsd + "enumeration");
                        if (!enums.Any())
                        {
                            if (type != null)
                            {
                                this.Importer.RegisterReplacementType(pt, type);
                                return type;
                            }
                            else
                            {
                                this.Importer.Diagnostics.AddError("Could not resolve type '" + baseAttr.Value + "'.", this.Uri, this.GetTextSpan(baseAttr));
                                return null;
                            }
                        }
                    }
                    else
                    {
                        if (type != null)
                        {
                            this.Importer.RegisterReplacementType(pt, type);
                            return type;
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Could not resolve type '" + baseAttr.Value + "'.", this.Uri, this.GetTextSpan(baseAttr));
                            return null;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
            return null;
        }

        private SoalType ImportPhase2ComplexType(Struct st, XElement elem)
        {
            if (st == null)
            {
                this.Importer.Diagnostics.AddError("Type is missing for the element.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            XElement complexContentElem = elem.Element(xsd + "complexContent");
            XElement simpleContentElem = elem.Element(xsd + "simpleContent");
            if (complexContentElem != null)
            {
                XElement restrictionElem = complexContentElem.Element(xsd + "restriction");
                XElement extensionElem = complexContentElem.Element(xsd + "extension");
                if (restrictionElem != null)
                {
                    XAttribute baseRef = restrictionElem.Attribute("base");
                    if (baseRef != null)
                    {
                        XName baseRefName = this.GetXName(restrictionElem, baseRef.Value);
                        SoalType type = this.Importer.ResolveXsdType(baseRefName.NamespaceName, baseRefName.LocalName);
                        if (type != null)
                        {
                            this.Importer.RegisterReplacementType(st, type);
                            return type;
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Could not resolve type '" + baseRef.Value + "'.", this.Uri, this.GetTextSpan(baseRef));
                            return null;
                        }
                    }
                    else
                    {
                        this.Importer.Diagnostics.AddError("The restriction has no 'base' attribute.", this.Uri, this.GetTextSpan(restrictionElem));
                        return null;
                    }
                }
                else if (extensionElem != null)
                {
                    XAttribute baseRef = extensionElem.Attribute("base");
                    if (baseRef != null)
                    {
                        XName baseRefName = this.GetXName(extensionElem, baseRef.Value);
                        SoalType type = this.Importer.ResolveXsdType(baseRefName.NamespaceName, baseRefName.LocalName);
                        if (type != null)
                        {
                            st.BaseType = type as Struct;
                            elem = extensionElem;
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Could not resolve type '" + baseRef.Value + "'.", this.Uri, this.GetTextSpan(baseRef));
                            return null;
                        }
                    }
                    else
                    {
                        this.Importer.Diagnostics.AddError("The extension has no 'base' attribute.", this.Uri, this.GetTextSpan(extensionElem));
                        return null;
                    }
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Unsupported complex content.", this.Uri, this.GetTextSpan(complexContentElem));
                }
            }
            else if (simpleContentElem != null)
            {
                XElement restrictionElem = simpleContentElem.Element(xsd + "restriction");
                XElement extensionElem = simpleContentElem.Element(xsd + "extension");
                if (restrictionElem != null)
                {
                    XAttribute baseRef = restrictionElem.Attribute("base");
                    if (baseRef != null)
                    {
                        XName baseRefName = this.GetXName(restrictionElem, baseRef.Value);
                        SoalType type = this.Importer.ResolveXsdType(baseRefName.NamespaceName, baseRefName.LocalName);
                        if (type != null)
                        {
                            this.Importer.RegisterReplacementType(st, type);
                            return type;
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Could not resolve type '" + baseRef.Value + "'.", this.Uri, this.GetTextSpan(baseRef));
                            return null;
                        }
                    }
                    else
                    {
                        this.Importer.Diagnostics.AddError("The restriction has no 'base' attribute.", this.Uri, this.GetTextSpan(restrictionElem));
                        return null;
                    }
                }
                else if (extensionElem != null)
                {
                    XAttribute baseRef = extensionElem.Attribute("base");
                    if (baseRef != null)
                    {
                        XName baseRefName = this.GetXName(extensionElem, baseRef.Value);
                        SoalType type = this.Importer.ResolveXsdType(baseRefName.NamespaceName, baseRefName.LocalName);
                        if (type != null)
                        {
                            this.Importer.RegisterReplacementType(st, type);
                            this.Importer.Diagnostics.AddWarning("Simple content extension is not supported.", this.Uri, this.GetTextSpan(extensionElem));
                            return type;
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("Could not resolve type '" + baseRef.Value + "'.", this.Uri, this.GetTextSpan(baseRef));
                            return null;
                        }
                    }
                    else
                    {
                        this.Importer.Diagnostics.AddError("The extension has no 'base' attribute.", this.Uri, this.GetTextSpan(extensionElem));
                        return null;
                    }
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Unsupported simple content.", this.Uri, this.GetTextSpan(complexContentElem));
                }
            }
            return st;
        }

        private SoalType ImportPhase3Element(XElement elem)
        {
            SoalType result = null;
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
                    result = this.ImportPhase1SimpleType(simpleType, name, XsdTypeKind.Element, elem, true);
                }
                else if (complexType != null)
                {
                    result = this.ImportPhase1ComplexType(complexType, name, XsdTypeKind.Element, elem, true);
                }
                else
                {
                    this.Importer.Diagnostics.AddError("The element has no type.", this.Uri, this.GetTextSpan(elem));
                    return null;
                }
            }
            else
            {
                XName typeRef = this.GetXName(elem, typeAttr.Value);
                if (typeRef == null)
                {
                    this.Importer.Diagnostics.AddError("Invalid type reference: '" + typeAttr.Value + "'", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
                result = this.Importer.XsdTypes.Get(typeRef) as SoalType;
                if (result == null)
                {
                    result = this.Importer.ResolveXsdPrimitiveType(typeRef.NamespaceName, typeRef.LocalName);
                }
                if (result == null)
                {
                    this.Importer.Diagnostics.AddError("Could not resolve type '" + typeAttr.Value + "'.", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
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
                if (maxOccurs < 0 || maxOccurs > 1)
                {
                    ArrayType array = SoalFactory.Instance.CreateArrayType();
                    array.InnerType = result;
                    result = array;
                }
                this.Importer.XsdElements.Register(this, tns + name, elem, result);
            }
            return result;
        }

        private SoalType ImportPhase3Attribute(XElement elem)
        {
            SoalType result = null;
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            string name = null;
            if (nameAttr != null)
            {
                name = nameAttr.Value;
            }
            if (name == null)
            {
                this.Importer.Diagnostics.AddError("The attribute has no name.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            if (typeAttr == null)
            {
                XElement simpleType = elem.Element(xsd + "simpleType");
                XElement complexType = elem.Element(xsd + "complexType");
                if (simpleType != null)
                {
                    result = this.ImportPhase1SimpleType(simpleType, name, XsdTypeKind.Attribute, elem, true);
                }
                else if (complexType != null)
                {
                    result = this.ImportPhase1ComplexType(complexType, name, XsdTypeKind.Attribute, elem, true);
                }
                else
                {
                    this.Importer.Diagnostics.AddError("The attribute has no type.", this.Uri, this.GetTextSpan(elem));
                    return null;
                }
            }
            else
            {
                XName typeRef = this.GetXName(elem, typeAttr.Value);
                if (typeRef == null)
                {
                    this.Importer.Diagnostics.AddError("Invalid type reference: '" + typeAttr.Value + "'", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
                result = this.Importer.XsdTypes.Get(typeRef) as SoalType;
                if (result == null)
                {
                    result = this.Importer.ResolveXsdPrimitiveType(typeRef.NamespaceName, typeRef.LocalName);
                }
                if (result != null)
                {
                    this.Importer.XsdAttributes.Register(this, tns + name, elem, result);
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Could not resolve type '" + typeAttr.Value + "'.", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
            }
            return result;
        }

        private SoalType ImportPhase4Element(Struct st, XElement elem)
        {
            SoalType result = st;
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
                }
                else if (complexType != null)
                {
                    this.ImportPhase4ComplexType(st, complexType);
                }
                else
                {
                }
            }
            return result;
        }

        private SoalType ImportPhase4ComplexType(Struct st, XElement elem)
        {
            if (st == null)
            {
                this.Importer.Diagnostics.AddError("Type is missing for the element.", this.Uri, this.GetTextSpan(elem));
                return null;
            }
            string name = st.Name;
            XElement complexContentElem = elem.Element(xsd + "complexContent");
            XElement simpleContentElem = elem.Element(xsd + "simpleContent");
            if (complexContentElem != null)
            {
                XElement restrictionElem = complexContentElem.Element(xsd + "restriction");
                XElement extensionElem = complexContentElem.Element(xsd + "extension");
                if (restrictionElem != null)
                {
                    return st;
                }
                else if (extensionElem != null)
                {
                    XAttribute baseRef = extensionElem.Attribute("base");
                    if (baseRef != null)
                    {
                        XName baseRefName = this.GetXName(extensionElem, baseRef.Value);
                        SoalType type = this.Importer.ResolveXsdType(baseRefName.NamespaceName, baseRefName.LocalName);
                        if (type != null)
                        {
                            elem = extensionElem;
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    // nop
                }
            }
            else if (simpleContentElem != null)
            {
                XElement restrictionElem = simpleContentElem.Element(xsd + "restriction");
                XElement extensionElem = simpleContentElem.Element(xsd + "extension");
                if (restrictionElem != null)
                {
                    return null;
                }
                else if (extensionElem != null)
                {
                    return null;
                }
                else
                {
                    return null;
                }
            }
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
                Annotation choiceAnnot = SoalFactory.Instance.CreateAnnotation();
                choiceAnnot.Name = SoalAnnotations.Choice;
                st.Annotations.Add(choiceAnnot);
            }
            else if (allElem != null)
            {
                complexElem = allElem;
                Annotation allAnnot = SoalFactory.Instance.CreateAnnotation();
                allAnnot.Name = SoalAnnotations.All;
                st.Annotations.Add(allAnnot);
            }
            SoalType rt = this.Importer.ResolveXsdReplacementType(st);
            if (complexElem != null)
            {
                foreach (var child in complexElem.Elements())
                {
                    if (child.Name.Namespace == xsd)
                    {
                        if (child.Name.LocalName == "element")
                        {
                            Property prop = this.ImportPhase4ElementProperty(st, rt, child, false);
                            st.Properties.Add(prop);
                        }
                    }
                }
            }
            foreach (var child in elem.Elements())
            {
                if (child.Name.Namespace == xsd)
                {
                    if (child.Name.LocalName == "attribute")
                    {
                        Property prop = this.ImportPhase4ElementProperty(st, rt, child, true);
                        st.Properties.Add(prop);
                    }
                }
            }
            return st;
        }

        private Property ImportPhase4ElementProperty(Struct st, SoalType rt, XElement elem, bool attribute)
        {
            XAttribute refAttr = elem.Attribute("ref");
            XAttribute nameAttr = elem.Attribute("name");
            XAttribute typeAttr = elem.Attribute("type");
            string name = null;
            SoalType type = null;
            if (refAttr != null)
            {
                XName refName = this.GetXName(elem, refAttr.Value);
                XElement originalElem = null;
                if (refName != null)
                {
                    if (attribute)
                    {
                        originalElem = this.Importer.XsdAttributes.GetX(refName);
                    }
                    else
                    {
                        originalElem = this.Importer.XsdElements.GetX(refName);
                    }
                }
                if (originalElem != null)
                {
                    name = refName.LocalName;
                    if (attribute)
                    {
                        type = this.Importer.XsdAttributes.Get(refName);
                    }
                    else
                    {
                        type = this.Importer.XsdElements.Get(refName);
                    }
                    if (type == null)
                    {
                        this.Importer.Diagnostics.AddError("Could not resolve type '" + refAttr.Value + "'.", this.Uri, this.GetTextSpan(refAttr));
                        return null;
                    }
                }
                else
                { 
                    this.Importer.Diagnostics.AddError("Could not resolve the reference.", this.Uri, this.GetTextSpan(refAttr));
                    return null;
                }
            }
            else
            {
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
                        type = this.ImportPhase1SimpleType(simpleType, name, attribute ? XsdTypeKind.Attribute : XsdTypeKind.Element, elem, false);
                    }
                    else if (complexType != null)
                    {
                        type = this.ImportPhase1ComplexType(complexType, name, attribute ? XsdTypeKind.Attribute : XsdTypeKind.Element, elem, false);
                        Struct childSt = type as Struct;
                        if (childSt != null)
                        {
                            type = this.ImportPhase4ComplexType(childSt, complexType);
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
                    XName typeRef = this.GetXName(elem, typeAttr.Value);
                    if (typeRef == null)
                    {
                        this.Importer.Diagnostics.AddError("Invalid type reference: '" + typeAttr.Value + "'", this.Uri, this.GetTextSpan(typeAttr));
                        return null;
                    }
                    type = this.Importer.ResolveXsdType(typeRef.NamespaceName, typeRef.LocalName) as SoalType;
                    if (type == null)
                    {
                        this.Importer.Diagnostics.AddError("Could not resolve type '" + typeAttr.Value + "'.", this.Uri, this.GetTextSpan(typeAttr));
                        return null;
                    }
                }
            }
            type = this.Importer.ResolveXsdReplacementType(type);
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
            Property prop = SoalFactory.Instance.CreateProperty();
            prop.Name = name;
            if (rt != null && rt is ArrayType)
            {
                ((ArrayType)rt).InnerType = type;
                Annotation noWrap = SoalFactory.Instance.CreateAnnotation();
                noWrap.Name = SoalAnnotations.NoWrap;
                prop.Annotations.Add(noWrap);
                prop.Type = rt;
            }
            else
            {
                if (maxOccurs < 0 || maxOccurs > 1)
                {
                    ArrayType array = SoalFactory.Instance.CreateArrayType();
                    array.InnerType = type;
                    type = array;
                    Annotation noWrap = SoalFactory.Instance.CreateAnnotation();
                    noWrap.Name = SoalAnnotations.NoWrap;
                    prop.Annotations.Add(noWrap);
                }
                prop.Type = type;
            }
            if (minOccurs == 0 && maxOccurs == 1)
            {
                Annotation optional = SoalFactory.Instance.CreateAnnotation();
                optional.Name = SoalAnnotations.Optional;
                prop.Annotations.Add(optional);
            }
            if (attribute)
            {
                Annotation attr = SoalFactory.Instance.CreateAnnotation();
                attr.Name = SoalAnnotations.Attribute;
                prop.Annotations.Add(attr);
                XAttribute useAttr = elem.Attribute("use");
                if (useAttr != null && useAttr.Value == "required")
                {
                    Annotation req = SoalFactory.Instance.CreateAnnotation();
                    req.Name = SoalAnnotations.Required;
                    prop.Annotations.Add(req);
                }
            }
            prop.Parent = st;
            return prop;
        }
    }
}