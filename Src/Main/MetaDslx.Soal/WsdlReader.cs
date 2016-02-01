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
        public SoalType ReplacementType { get; set; }
    }

    internal class WsdlMessage
    {
        public string Name { get; set; }
        public List<WsdlMessagePart> Parts { get; private set; }
        public bool Wrapped { get; set; }
        public bool Rpc { get; set; }
        public bool Document { get; set; }
        public string ElementName { get; set; }

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

        public override void ImportPhase5()
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
                                            msg.Document = true;
                                            XName partTypeElemName = this.GetXName(partElem, partXsdElemAttr.Value);
                                            if (msg.ElementName == null)
                                            {
                                                msg.ElementName = partTypeElemName.LocalName;
                                                msg.Wrapped = true;
                                            }
                                            else
                                            {
                                                msg.Wrapped = false;
                                            }
                                            partType = this.Importer.XsdElements.Get(this.GetXName(partElem, partXsdElemAttr.Value));
                                        }
                                        else if (partXsdTypeAttr != null)
                                        {
                                            msg.Rpc = true;
                                            XName typeRefName = this.GetXName(partElem, partXsdTypeAttr.Value);
                                            if (typeRefName != null)
                                            {
                                                //partType = this.Importer.ResolveXsdType(typeRefName.NamespaceName, typeRefName.LocalName);
                                                partType = this.Importer.XsdTypes.Get(typeRefName);
                                            }
                                            if (partType == null)
                                            {
                                                partType = this.Importer.ResolveXsdPrimitiveType(typeRefName.NamespaceName, typeRefName.LocalName);
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
                                    part.ReplacementType = this.Importer.ResolveXsdReplacementType(part.Type);
                                    msg.Parts.Add(part);
                                }
                            }
                            if (msg.Parts.Count != 1)
                            {
                                msg.Wrapped = false;
                            }
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("The message has no 'name' attribute.", this.Uri, this.GetTextSpan(elem));
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

        public override void ImportPhase6()
        {
            foreach (var elem in this.Root.Elements())
            {
                if (elem.Name.NamespaceName == WsdlReader.WsdlNamespace)
                {
                    if (elem.Name.LocalName == "portType")
                    {
                        XAttribute nameAttr = elem.Attribute("name");
                        if (nameAttr != null)
                        {
                            string name = nameAttr.Value;
                            Interface intf = SoalFactory.Instance.CreateInterface();
                            intf.Name = name;
                            intf.Namespace = this.Namespace;
                            int count = 0;
                            int rpc = 0;
                            int document = 0;
                            int wrapped = 0;
                            foreach (var opElem in elem.Elements(wsdl + "operation"))
                            {
                                XAttribute opNameAttr = opElem.Attribute("name");
                                if (opNameAttr != null)
                                {
                                    ++count;
                                    string opName = opNameAttr.Value;
                                    bool opRpc = false;
                                    bool opDocument = false;
                                    bool opWrapped = false;
                                    bool opNotWrapped = false;
                                    XElement inputElem = opElem.Element(wsdl + "input");
                                    XElement outputElem = opElem.Element(wsdl + "output");
                                    List<XElement> faultElems = opElem.Elements(wsdl + "fault").ToList();
                                    WsdlMessage inputMsg = null;
                                    WsdlMessage outputMsg = null;
                                    List<WsdlMessage> faultMsgs = new List<WsdlMessage>();
                                    if (inputElem != null)
                                    {
                                        XAttribute msgAttr = inputElem.Attribute("message");
                                        if (msgAttr != null)
                                        {
                                            inputMsg = this.Importer.WsdlMessages.Get(this.GetXName(inputElem, msgAttr.Value));
                                        }
                                        if (inputMsg != null)
                                        {
                                            if (inputMsg.Document) opDocument = true;
                                            if (inputMsg.Rpc) opRpc = true;
                                            if (inputMsg.Wrapped && inputMsg.ElementName == opName) opWrapped = true;
                                            else opNotWrapped = true;
                                        }
                                        else
                                        {
                                            this.Importer.Diagnostics.AddError("Could not resolve the input message.", this.Uri, this.GetTextSpan(inputElem));
                                            continue;
                                        }
                                    }
                                    if (outputElem != null)
                                    {
                                        XAttribute msgAttr = outputElem.Attribute("message");
                                        if (msgAttr != null)
                                        {
                                            outputMsg = this.Importer.WsdlMessages.Get(this.GetXName(outputElem, msgAttr.Value));
                                        }
                                        if (outputMsg != null)
                                        {
                                            if (outputMsg.Document) opDocument = true;
                                            if (outputMsg.Rpc) opRpc = true;
                                            if (outputMsg.Wrapped && outputMsg.ElementName == opName+"Response") opWrapped = true;
                                            else opNotWrapped = true;
                                        }
                                        else
                                        {
                                            this.Importer.Diagnostics.AddError("Could not resolve the output message.", this.Uri, this.GetTextSpan(outputElem));
                                            continue;
                                        }
                                    }
                                    foreach (var faultElem in faultElems)
                                    {
                                        XAttribute msgAttr = faultElem.Attribute("message");
                                        WsdlMessage faultMsg = null;
                                        if (msgAttr != null)
                                        {
                                            faultMsg = this.Importer.WsdlMessages.Get(this.GetXName(faultElem, msgAttr.Value));
                                        }
                                        if (faultMsg != null)
                                        {
                                            if (faultMsg.Document) opDocument = true;
                                            if (faultMsg.Rpc) opRpc = true;
                                            if (faultMsg.Wrapped) opWrapped = true;
                                            else opNotWrapped = true;
                                        }
                                        else
                                        {
                                            this.Importer.Diagnostics.AddError("Could not resolve the fault message.", this.Uri, this.GetTextSpan(faultElem));
                                        }
                                        faultMsgs.Add(faultMsg);
                                    }
                                    if (opWrapped && opNotWrapped)
                                    {
                                        opWrapped = false;
                                    }
                                    if (opDocument && opRpc)
                                    {
                                        opDocument = false;
                                        //this.Importer.Diagnostics.AddError("The operation has both document and RPC style messages. Use either of the styles but not both.", this.Uri, this.GetTextSpan(opElem));
                                        //continue;
                                    }
                                    Operation op = SoalFactory.Instance.CreateOperation();
                                    op.Name = opName;
                                    intf.Operations.Add(op);
                                    if (opDocument)
                                    {
                                        ++document;
                                        if (opWrapped)
                                        {
                                            ++wrapped;
                                            WsdlMessagePart part;
                                            Struct st;
                                            if (inputMsg != null)
                                            {
                                                part = null;
                                                st = null;
                                                if (inputMsg.Parts.Count == 1)
                                                {
                                                    part = inputMsg.Parts[0];
                                                    if (part != null)
                                                    {
                                                        st = part.Type as Struct;
                                                    }
                                                }
                                                if (st != null)
                                                {
                                                    foreach (var prop in st.Properties)
                                                    {
                                                        Parameter param = SoalFactory.Instance.CreateParameter();
                                                        param.Name = prop.Name;
                                                        param.Type = prop.Type;
                                                        if (prop.HasAnnotation(SoalAnnotations.NoWrap))
                                                        {
                                                            Annotation annot = SoalFactory.Instance.CreateAnnotation();
                                                            annot.Name = SoalAnnotations.NoWrap;
                                                            param.Annotations.Add(annot);
                                                        }
                                                        op.Parameters.Add(param);
                                                    }
                                                    this.Importer.RemoveType(st);
                                                }
                                                else
                                                {
                                                    this.Importer.Diagnostics.AddError("The input message part should be of 'complexType'.", this.Uri, this.GetTextSpan(opElem));
                                                    op.ReturnType = SoalInstance.Void;
                                                    continue;
                                                }
                                            }
                                            if (outputMsg != null)
                                            {
                                                part = null;
                                                st = null;
                                                if (outputMsg.Parts.Count == 1)
                                                {
                                                    part = outputMsg.Parts[0];
                                                    if (part != null)
                                                    {
                                                        st = part.Type as Struct;
                                                    }
                                                }
                                                if (st != null && st.Properties.Count > 0)
                                                {
                                                    if (st.Properties.Count > 1)
                                                    {
                                                        this.Importer.Diagnostics.AddError("The output message should have a single '" + op.Name + "Result' element under the '" + op.Name + "Response' element.", this.Uri, this.GetTextSpan(opElem));
                                                        op.ReturnType = SoalInstance.Void;
                                                        continue;
                                                    }
                                                    Property prop = st.Properties[0];
                                                    if (prop.Name != op.Name + "Result")
                                                    {
                                                        this.Importer.Diagnostics.AddWarning("The output message should have a single '" + op.Name + "Result' element under the '" + op.Name + "Response' element.", this.Uri, this.GetTextSpan(opElem));
                                                    }
                                                    op.ReturnType = prop.Type;
                                                    if (prop.HasAnnotation(SoalAnnotations.NoWrap))
                                                    {
                                                        Annotation annot = SoalFactory.Instance.CreateAnnotation();
                                                        annot.Name = SoalAnnotations.NoWrap;
                                                        op.ReturnAnnotations.Add(annot);
                                                    }
                                                    this.Importer.RemoveType(st);
                                                }
                                                else if (st != null)
                                                {
                                                    op.ReturnType = SoalInstance.Void;
                                                    this.Importer.RemoveType(st);
                                                }
                                                else
                                                {
                                                    this.Importer.Diagnostics.AddError("The output message part should be of 'complexType'.", this.Uri, this.GetTextSpan(opElem));
                                                    op.ReturnType = SoalInstance.Void;
                                                    continue;
                                                }
                                            }
                                            else
                                            {
                                                op.IsOneway = true;
                                            }
                                            foreach (var faultMsg in faultMsgs)
                                            {
                                                part = null;
                                                st = null;
                                                if (faultMsg.Parts.Count == 1)
                                                {
                                                    part = faultMsg.Parts[0];
                                                    if (part != null)
                                                    {
                                                        st = part.Type as Struct;
                                                    }
                                                }
                                                if (st != null)
                                                {
                                                    Exception ex = this.Importer.GetExceptionType(st) as Exception;
                                                    if (ex == null)
                                                    {
                                                        ex = this.CreateException(st);
                                                        this.Importer.RegisterExceptionType(st, ex);
                                                    }
                                                    op.Exceptions.Add(ex);
                                                }
                                            }
                                        }
                                        else
                                        {
                                            if (inputMsg != null)
                                            {
                                                foreach (var part in inputMsg.Parts)
                                                {
                                                    Parameter param = SoalFactory.Instance.CreateParameter();
                                                    param.Name = part.Name;
                                                    param.Type = part.ReplacementType;
                                                    op.Parameters.Add(param);
                                                    if (part.ReplacementType == part.Type && part.ReplacementType is ArrayType && ((ArrayType)part.ReplacementType).InnerType != SoalInstance.Byte)
                                                    {
                                                        Annotation annot = SoalFactory.Instance.CreateAnnotation();
                                                        annot.Name = SoalAnnotations.NoWrap;
                                                        param.Annotations.Add(annot);
                                                    }
                                                }
                                            }
                                            if (outputMsg != null)
                                            {
                                                if (outputMsg.Parts.Count == 1)
                                                {
                                                    WsdlMessagePart part = outputMsg.Parts[0];
                                                    op.ReturnType = part.ReplacementType;
                                                    if (part.ReplacementType == part.Type && part.ReplacementType is ArrayType && ((ArrayType)part.ReplacementType).InnerType != SoalInstance.Byte)
                                                    {
                                                        Annotation annot = SoalFactory.Instance.CreateAnnotation();
                                                        annot.Name = SoalAnnotations.NoWrap;
                                                        op.ReturnAnnotations.Add(annot);
                                                    }
                                                }
                                                else
                                                {
                                                    if (outputMsg.Parts.Count > 1)
                                                    {
                                                        this.Importer.Diagnostics.AddError("The output message should have a single part.", this.Uri, this.GetTextSpan(opElem));
                                                    }
                                                    op.ReturnType = SoalInstance.Void;
                                                }
                                            }
                                            else
                                            {
                                                op.IsOneway = true;
                                            }
                                            foreach (var faultMsg in faultMsgs)
                                            {
                                                if (faultMsg.Parts.Count == 1)
                                                {
                                                    WsdlMessagePart part = faultMsg.Parts[0];
                                                    Struct st = null;
                                                    if (part != null)
                                                    {
                                                        st = part.Type as Struct;
                                                    }
                                                    if (st != null)
                                                    {
                                                        Exception ex = this.Importer.GetExceptionType(st) as Exception;
                                                        if (ex == null)
                                                        {
                                                            ex = this.CreateException(st);
                                                            this.Importer.RegisterExceptionType(st, ex);
                                                        }
                                                        op.Exceptions.Add(ex);
                                                    }
                                                }
                                                else
                                                {
                                                    if (faultMsg.Parts.Count > 1)
                                                    {
                                                        this.Importer.Diagnostics.AddError("The fault message should have a single part.", this.Uri, this.GetTextSpan(opElem));
                                                    }
                                                }
                                            }
                                        }
                                    }
                                    if (opRpc)
                                    {
                                        ++rpc;
                                        if (inputMsg != null)
                                        {
                                            foreach (var part in inputMsg.Parts)
                                            {
                                                Parameter param = SoalFactory.Instance.CreateParameter();
                                                param.Name = part.Name;
                                                param.Type = part.ReplacementType;
                                                op.Parameters.Add(param);
                                            }
                                        }
                                        if (outputMsg != null)
                                        {
                                            if (outputMsg.Parts.Count == 1)
                                            {
                                                WsdlMessagePart part = outputMsg.Parts[0];
                                                op.ReturnType = part.ReplacementType;
                                            }
                                            else
                                            {
                                                if (outputMsg.Parts.Count > 1)
                                                {
                                                    this.Importer.Diagnostics.AddError("The output message should have a single part.", this.Uri, this.GetTextSpan(opElem));
                                                }
                                                op.ReturnType = SoalInstance.Void;
                                            }
                                        }
                                        else
                                        {
                                            op.IsOneway = true;
                                        }
                                    }
                                    foreach (var faultMsg in faultMsgs)
                                    {
                                        if (faultMsg.Parts.Count == 1)
                                        {
                                            WsdlMessagePart part = faultMsg.Parts[0];
                                            Struct st = null;
                                            if (part != null)
                                            {
                                                st = part.Type as Struct;
                                            }
                                            if (st != null)
                                            {
                                                Exception ex = this.Importer.GetExceptionType(st) as Exception;
                                                if (ex == null)
                                                {
                                                    ex = this.CreateException(st);
                                                    this.Importer.RegisterExceptionType(st, ex);
                                                }
                                                op.Exceptions.Add(ex);
                                            }
                                        }
                                        else
                                        {
                                            if (faultMsg.Parts.Count > 1)
                                            {
                                                this.Importer.Diagnostics.AddError("The fault message should have a single part.", this.Uri, this.GetTextSpan(opElem));
                                            }
                                        }
                                    }
                                }
                                else
                                {
                                    this.Importer.Diagnostics.AddError("The operation has no 'name' attribute.", this.Uri, this.GetTextSpan(opElem));
                                    continue;
                                }
                            }
                            if (document > 0 && rpc > 0)
                            {
                                this.Importer.Diagnostics.AddError("The portType has both document and RPC style operations. Use either of the styles on all operations but not both.", this.Uri, this.GetTextSpan(elem));
                                continue;
                            }
                            else if (document > 0)
                            {
                                if (wrapped < count)
                                {
                                    if (wrapped > 0)
                                    {
                                        this.Importer.Diagnostics.AddWarning("The portType has both wrapped and unwrapped document style operations. Use either of the styles on all operations but not both.", this.Uri, this.GetTextSpan(elem));
                                        wrapped = 0;
                                    }
                                    Annotation annot = SoalFactory.Instance.CreateAnnotation();
                                    annot.Name = SoalAnnotations.NoWrap;
                                    intf.Annotations.Add(annot);
                                }
                            }
                            else
                            {
                                Annotation annot = SoalFactory.Instance.CreateAnnotation();
                                annot.Name = SoalAnnotations.Rpc;
                                intf.Annotations.Add(annot);
                            }
                        }
                        else
                        {
                            this.Importer.Diagnostics.AddError("The portType has no 'name' attribute.", this.Uri, this.GetTextSpan(elem));
                            continue;
                        }
                    }
                }
            }
        }

        private Exception CreateException(Struct st)
        {
            Exception ex = SoalFactory.Instance.CreateException();
            ex.Name = st.Name;
            ex.Namespace = st.Namespace;
            foreach (var annot in st.Annotations)
            {
                Annotation exAnnot = SoalFactory.Instance.CreateAnnotation();
                exAnnot.Name = annot.Name;
                ex.Annotations.Add(exAnnot);
            }
            foreach (var prop in st.Properties)
            {
                Property exProp = SoalFactory.Instance.CreateProperty();
                exProp.Name = prop.Name;
                exProp.Type = prop.Type;
                ex.Properties.Add(exProp);
                foreach (var annot in prop.Annotations)
                {
                    Annotation exAnnot = SoalFactory.Instance.CreateAnnotation();
                    exAnnot.Name = annot.Name;
                    exProp.Annotations.Add(exAnnot);
                    foreach (var annotProp in annot.Properties)
                    {
                        AnnotationProperty exAnnotProp = SoalFactory.Instance.CreateAnnotationProperty();
                        exAnnotProp.Name = annotProp.Name;
                        exAnnotProp.Value = annotProp.Value;
                        exAnnot.Properties.Add(exAnnotProp);
                    }
                }
            }
            return ex;
        }

        public override void ImportPhase7()
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

        public override void ImportPhase8()
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
