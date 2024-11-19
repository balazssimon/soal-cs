#pragma warning disable CS8669

namespace MetaDslx.Languages.Soal.Symbols
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal abstract class CustomSoalImplementationBase : ICustomSoalImplementation
    {
        /// <summary>
        /// Constructor for the meta model Soal
        /// </summary>
        public virtual void Soal(ISoal _this)
        {
        }
    
        public virtual void AnnotatedElement(AnnotatedElement _this)
        {
        }
    
        public virtual void Annotation(Annotation _this)
        {
        }
    
        public virtual void AnnotationProperty(AnnotationProperty _this)
        {
        }
    
        public virtual void ArrayType(ArrayType _this)
        {
        }
    
        public virtual void Assembly(Assembly _this)
        {
        }
    
        public virtual void Binding(Binding _this)
        {
        }
    
        public virtual void BindingElement(BindingElement _this)
        {
        }
    
        public virtual void Component(Component _this)
        {
        }
    
        public virtual void Composite(Composite _this)
        {
        }
    
        public virtual void Database(Database _this)
        {
        }
    
        public virtual void Declaration(Declaration _this)
        {
        }
    
        public virtual void Deployment(Deployment _this)
        {
        }
    
        public virtual void DocumentedElement(DocumentedElement _this)
        {
        }
    
        public virtual void EncodingBindingElement(EncodingBindingElement _this)
        {
        }
    
        public virtual void Endpoint(Endpoint _this)
        {
        }
    
        public virtual void Enum(Enum _this)
        {
        }
    
        public virtual void EnumLiteral(EnumLiteral _this)
        {
        }
    
        public virtual void Environment(Environment _this)
        {
        }
    
        public virtual void HttpTransportBindingElement(HttpTransportBindingElement _this)
        {
        }
    
        public virtual void Implementation(Implementation _this)
        {
        }
    
        public virtual void InputParameter(InputParameter _this)
        {
        }
    
        public virtual void Interface(Interface _this)
        {
        }
    
        public virtual void JsonEncodingBindingElement(JsonEncodingBindingElement _this)
        {
        }
    
        public virtual void NamedElement(NamedElement _this)
        {
        }
    
        public virtual void Namespace(Namespace _this)
        {
        }
    
        public virtual void NullableType(NullableType _this)
        {
        }
    
        public virtual void Operation(Operation _this)
        {
        }
    
        public virtual void OutputParameter(OutputParameter _this)
        {
        }
    
        public virtual void Port(Port _this)
        {
        }
    
        public virtual void PrimitiveType(PrimitiveType _this)
        {
        }
    
        public virtual void ProgrammingLanguage(ProgrammingLanguage _this)
        {
        }
    
        public virtual void Property(Property _this)
        {
        }
    
        public virtual void ProtocolBindingElement(ProtocolBindingElement _this)
        {
        }
    
        public virtual void Reference(Reference _this)
        {
        }
    
        public virtual void RestTransportBindingElement(RestTransportBindingElement _this)
        {
        }
    
        public virtual void Runtime(Runtime _this)
        {
        }
    
        public virtual void Service(Service _this)
        {
        }
    
        public virtual void SoalType(SoalType _this)
        {
        }
    
        public virtual void SoapEncodingBindingElement(SoapEncodingBindingElement _this)
        {
        }
    
        public virtual void Struct(Struct _this)
        {
        }
    
        public virtual void TransportBindingElement(TransportBindingElement _this)
        {
        }
    
        public virtual void TypedElement(TypedElement _this)
        {
        }
    
        public virtual void WebSocketTransportBindingElement(WebSocketTransportBindingElement _this)
        {
        }
    
        public virtual void Wire(Wire _this)
        {
        }
    
        public virtual void WsAddressingBindingElement(WsAddressingBindingElement _this)
        {
        }
    
        public virtual void WsProtocolBindingElement(WsProtocolBindingElement _this)
        {
        }
    
        public virtual void XmlEncodingBindingElement(XmlEncodingBindingElement _this)
        {
        }
    
    
        public abstract string Declaration_FullName(Declaration _this);
    
    
        public abstract global::System.Collections.Generic.IList<string> DocumentedElement_GetDocumentationLines(DocumentedElement _this);
    
    }
}
