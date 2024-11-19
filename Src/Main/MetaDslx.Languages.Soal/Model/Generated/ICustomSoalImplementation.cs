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

    internal interface ICustomSoalImplementation
    {
        /// <summary>
        /// Constructor for the meta model Soal
        /// </summary>
        void Soal(ISoal _this);
    
        void AnnotatedElement(AnnotatedElement _this);
    
        void Annotation(Annotation _this);
    
        void AnnotationProperty(AnnotationProperty _this);
    
        void ArrayType(ArrayType _this);
    
        void Assembly(Assembly _this);
    
        void Binding(Binding _this);
    
        void BindingElement(BindingElement _this);
    
        void Component(Component _this);
    
        void Composite(Composite _this);
    
        void Database(Database _this);
    
        void Declaration(Declaration _this);
    
        void Deployment(Deployment _this);
    
        void DocumentedElement(DocumentedElement _this);
    
        void EncodingBindingElement(EncodingBindingElement _this);
    
        void Endpoint(Endpoint _this);
    
        void Enum(Enum _this);
    
        void EnumLiteral(EnumLiteral _this);
    
        void Environment(Environment _this);
    
        void HttpTransportBindingElement(HttpTransportBindingElement _this);
    
        void Implementation(Implementation _this);
    
        void InputParameter(InputParameter _this);
    
        void Interface(Interface _this);
    
        void JsonEncodingBindingElement(JsonEncodingBindingElement _this);
    
        void NamedElement(NamedElement _this);
    
        void Namespace(Namespace _this);
    
        void NullableType(NullableType _this);
    
        void Operation(Operation _this);
    
        void OutputParameter(OutputParameter _this);
    
        void Port(Port _this);
    
        void PrimitiveType(PrimitiveType _this);
    
        void ProgrammingLanguage(ProgrammingLanguage _this);
    
        void Property(Property _this);
    
        void ProtocolBindingElement(ProtocolBindingElement _this);
    
        void Reference(Reference _this);
    
        void RestTransportBindingElement(RestTransportBindingElement _this);
    
        void Runtime(Runtime _this);
    
        void Service(Service _this);
    
        void SoalType(SoalType _this);
    
        void SoapEncodingBindingElement(SoapEncodingBindingElement _this);
    
        void Struct(Struct _this);
    
        void TransportBindingElement(TransportBindingElement _this);
    
        void TypedElement(TypedElement _this);
    
        void WebSocketTransportBindingElement(WebSocketTransportBindingElement _this);
    
        void Wire(Wire _this);
    
        void WsAddressingBindingElement(WsAddressingBindingElement _this);
    
        void WsProtocolBindingElement(WsProtocolBindingElement _this);
    
        void XmlEncodingBindingElement(XmlEncodingBindingElement _this);
    
    
        string Declaration_FullName(Declaration _this);
    
    
        global::System.Collections.Generic.IList<string> DocumentedElement_GetDocumentationLines(DocumentedElement _this);
    
    }
}
