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
            foreach (var elem in this.Root.Elements())
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
                    SoalType mo = this.Importer.XsdTypes.Get(elem);
                    Struct st = mo as Struct;
                    this.ImportPhase3ComplexType(st, elem);
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
                            name = this.GetUniqueName(name, allowRename);
                            if (allowRename || this.Importer.XsdTypes.Register(this, tns + name, elem, enm) != null)
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
            if (allowRename || this.Importer.XsdTypes.Register(this, tns + name, elem, st) != null)
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
                    List<XElement> children = sequenceElem.Elements(xsd + "element").ToList();
                    if (children.Count == 1)
                    {
                        XElement child = children[0];
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
                            ModelContext.Current.RemoveInstance((ModelObject)st);
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
                    result = this.ImportPhase1SimpleType(simpleType, name, true);
                }
                else if (complexType != null)
                {
                    result = this.ImportPhase1ComplexType(complexType, name, true);
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
                result = this.Importer.ResolveXsdType(typeRef.NamespaceName, typeRef.LocalName) as SoalType;
                if (result == null)
                {
                    this.Importer.Diagnostics.AddError("Could not resolve type '" + typeAttr.Value + "'.", this.Uri, this.GetTextSpan(typeAttr));
                    return null;
                }
            }
            if (result != null)
            {
                this.Importer.XsdElements.Register(this, tns + name, elem, result);
            }
            return result;
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
            else
            {
                return null;
            }
            SoalType rt = this.Importer.GetReplacementType(st);
            foreach (var child in complexElem.Elements())
            {
                if (child.Name.Namespace == xsd)
                {
                    if (child.Name.LocalName == "element")
                    {
                        Property prop = this.ImportPhase3Element(st, rt, child);
                        st.Properties.Add(prop);
                    }
                }
            }
            return st;
        }

        private Property ImportPhase3Element(Struct st, SoalType rt, XElement elem)
        {
            // TODO: replacement type
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
            if (rt != null)
            {
                if (rt is ArrayType)
                {
                    ((ArrayType)rt).InnerType = type;
                }
                else
                {
                    this.Importer.Diagnostics.AddError("Invalid replacement type: '" + rt + "'", this.Uri, this.GetTextSpan(elem));
                    return null;
                }
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
            prop.Parent = st;
            return prop;
        }
    }
}