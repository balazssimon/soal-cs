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

    public class SoalModelFactory : __ModelFactory
    {
        public SoalModelFactory(__Model model)
            : base(model, Soal.MInstance)
        {
        }
    
        internal SoalModelFactory(__Model model, Soal metaModel)
            : base(model, metaModel)
        {
        }
    
        public Annotation Annotation(string? id = null)
        {
            return (Annotation)Soal.AnnotationInfo.Create(base.Model, id)!;
        }
    
        public AnnotationProperty AnnotationProperty(string? id = null)
        {
            return (AnnotationProperty)Soal.AnnotationPropertyInfo.Create(base.Model, id)!;
        }
    
        public ArrayType ArrayType(string? id = null)
        {
            return (ArrayType)Soal.ArrayTypeInfo.Create(base.Model, id)!;
        }
    
        public Assembly Assembly(string? id = null)
        {
            return (Assembly)Soal.AssemblyInfo.Create(base.Model, id)!;
        }
    
        public Binding Binding(string? id = null)
        {
            return (Binding)Soal.BindingInfo.Create(base.Model, id)!;
        }
    
        public Component Component(string? id = null)
        {
            return (Component)Soal.ComponentInfo.Create(base.Model, id)!;
        }
    
        public Composite Composite(string? id = null)
        {
            return (Composite)Soal.CompositeInfo.Create(base.Model, id)!;
        }
    
        public Database Database(string? id = null)
        {
            return (Database)Soal.DatabaseInfo.Create(base.Model, id)!;
        }
    
        public Deployment Deployment(string? id = null)
        {
            return (Deployment)Soal.DeploymentInfo.Create(base.Model, id)!;
        }
    
        public Endpoint Endpoint(string? id = null)
        {
            return (Endpoint)Soal.EndpointInfo.Create(base.Model, id)!;
        }
    
        public Enum Enum(string? id = null)
        {
            return (Enum)Soal.EnumInfo.Create(base.Model, id)!;
        }
    
        public EnumLiteral EnumLiteral(string? id = null)
        {
            return (EnumLiteral)Soal.EnumLiteralInfo.Create(base.Model, id)!;
        }
    
        public Environment Environment(string? id = null)
        {
            return (Environment)Soal.EnvironmentInfo.Create(base.Model, id)!;
        }
    
        public HttpTransportBindingElement HttpTransportBindingElement(string? id = null)
        {
            return (HttpTransportBindingElement)Soal.HttpTransportBindingElementInfo.Create(base.Model, id)!;
        }
    
        public Implementation Implementation(string? id = null)
        {
            return (Implementation)Soal.ImplementationInfo.Create(base.Model, id)!;
        }
    
        public InputParameter InputParameter(string? id = null)
        {
            return (InputParameter)Soal.InputParameterInfo.Create(base.Model, id)!;
        }
    
        public Interface Interface(string? id = null)
        {
            return (Interface)Soal.InterfaceInfo.Create(base.Model, id)!;
        }
    
        public JsonEncodingBindingElement JsonEncodingBindingElement(string? id = null)
        {
            return (JsonEncodingBindingElement)Soal.JsonEncodingBindingElementInfo.Create(base.Model, id)!;
        }
    
        public Namespace Namespace(string? id = null)
        {
            return (Namespace)Soal.NamespaceInfo.Create(base.Model, id)!;
        }
    
        public NullableType NullableType(string? id = null)
        {
            return (NullableType)Soal.NullableTypeInfo.Create(base.Model, id)!;
        }
    
        public Operation Operation(string? id = null)
        {
            return (Operation)Soal.OperationInfo.Create(base.Model, id)!;
        }
    
        public OutputParameter OutputParameter(string? id = null)
        {
            return (OutputParameter)Soal.OutputParameterInfo.Create(base.Model, id)!;
        }
    
        public Port Port(string? id = null)
        {
            return (Port)Soal.PortInfo.Create(base.Model, id)!;
        }
    
        public PrimitiveType PrimitiveType(string? id = null)
        {
            return (PrimitiveType)Soal.PrimitiveTypeInfo.Create(base.Model, id)!;
        }
    
        public ProgrammingLanguage ProgrammingLanguage(string? id = null)
        {
            return (ProgrammingLanguage)Soal.ProgrammingLanguageInfo.Create(base.Model, id)!;
        }
    
        public Property Property(string? id = null)
        {
            return (Property)Soal.PropertyInfo.Create(base.Model, id)!;
        }
    
        public Reference Reference(string? id = null)
        {
            return (Reference)Soal.ReferenceInfo.Create(base.Model, id)!;
        }
    
        public RestTransportBindingElement RestTransportBindingElement(string? id = null)
        {
            return (RestTransportBindingElement)Soal.RestTransportBindingElementInfo.Create(base.Model, id)!;
        }
    
        public Runtime Runtime(string? id = null)
        {
            return (Runtime)Soal.RuntimeInfo.Create(base.Model, id)!;
        }
    
        public Service Service(string? id = null)
        {
            return (Service)Soal.ServiceInfo.Create(base.Model, id)!;
        }
    
        public SoapEncodingBindingElement SoapEncodingBindingElement(string? id = null)
        {
            return (SoapEncodingBindingElement)Soal.SoapEncodingBindingElementInfo.Create(base.Model, id)!;
        }
    
        public Struct Struct(string? id = null)
        {
            return (Struct)Soal.StructInfo.Create(base.Model, id)!;
        }
    
        public WebSocketTransportBindingElement WebSocketTransportBindingElement(string? id = null)
        {
            return (WebSocketTransportBindingElement)Soal.WebSocketTransportBindingElementInfo.Create(base.Model, id)!;
        }
    
        public Wire Wire(string? id = null)
        {
            return (Wire)Soal.WireInfo.Create(base.Model, id)!;
        }
    
        public WsAddressingBindingElement WsAddressingBindingElement(string? id = null)
        {
            return (WsAddressingBindingElement)Soal.WsAddressingBindingElementInfo.Create(base.Model, id)!;
        }
    
        public XmlEncodingBindingElement XmlEncodingBindingElement(string? id = null)
        {
            return (XmlEncodingBindingElement)Soal.XmlEncodingBindingElementInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class SoalModelMultiFactory : __MultiModelFactory
    {
        public SoalModelMultiFactory()
            : base(new __MetaModel[] { Soal.MInstance })
        {
        }
    
        public Annotation Annotation(__Model model, string? id = null)
        {
            return (Annotation)Soal.AnnotationInfo.Create(model, id)!;
        }
    
        public AnnotationProperty AnnotationProperty(__Model model, string? id = null)
        {
            return (AnnotationProperty)Soal.AnnotationPropertyInfo.Create(model, id)!;
        }
    
        public ArrayType ArrayType(__Model model, string? id = null)
        {
            return (ArrayType)Soal.ArrayTypeInfo.Create(model, id)!;
        }
    
        public Assembly Assembly(__Model model, string? id = null)
        {
            return (Assembly)Soal.AssemblyInfo.Create(model, id)!;
        }
    
        public Binding Binding(__Model model, string? id = null)
        {
            return (Binding)Soal.BindingInfo.Create(model, id)!;
        }
    
        public Component Component(__Model model, string? id = null)
        {
            return (Component)Soal.ComponentInfo.Create(model, id)!;
        }
    
        public Composite Composite(__Model model, string? id = null)
        {
            return (Composite)Soal.CompositeInfo.Create(model, id)!;
        }
    
        public Database Database(__Model model, string? id = null)
        {
            return (Database)Soal.DatabaseInfo.Create(model, id)!;
        }
    
        public Deployment Deployment(__Model model, string? id = null)
        {
            return (Deployment)Soal.DeploymentInfo.Create(model, id)!;
        }
    
        public Endpoint Endpoint(__Model model, string? id = null)
        {
            return (Endpoint)Soal.EndpointInfo.Create(model, id)!;
        }
    
        public Enum Enum(__Model model, string? id = null)
        {
            return (Enum)Soal.EnumInfo.Create(model, id)!;
        }
    
        public EnumLiteral EnumLiteral(__Model model, string? id = null)
        {
            return (EnumLiteral)Soal.EnumLiteralInfo.Create(model, id)!;
        }
    
        public Environment Environment(__Model model, string? id = null)
        {
            return (Environment)Soal.EnvironmentInfo.Create(model, id)!;
        }
    
        public HttpTransportBindingElement HttpTransportBindingElement(__Model model, string? id = null)
        {
            return (HttpTransportBindingElement)Soal.HttpTransportBindingElementInfo.Create(model, id)!;
        }
    
        public Implementation Implementation(__Model model, string? id = null)
        {
            return (Implementation)Soal.ImplementationInfo.Create(model, id)!;
        }
    
        public InputParameter InputParameter(__Model model, string? id = null)
        {
            return (InputParameter)Soal.InputParameterInfo.Create(model, id)!;
        }
    
        public Interface Interface(__Model model, string? id = null)
        {
            return (Interface)Soal.InterfaceInfo.Create(model, id)!;
        }
    
        public JsonEncodingBindingElement JsonEncodingBindingElement(__Model model, string? id = null)
        {
            return (JsonEncodingBindingElement)Soal.JsonEncodingBindingElementInfo.Create(model, id)!;
        }
    
        public Namespace Namespace(__Model model, string? id = null)
        {
            return (Namespace)Soal.NamespaceInfo.Create(model, id)!;
        }
    
        public NullableType NullableType(__Model model, string? id = null)
        {
            return (NullableType)Soal.NullableTypeInfo.Create(model, id)!;
        }
    
        public Operation Operation(__Model model, string? id = null)
        {
            return (Operation)Soal.OperationInfo.Create(model, id)!;
        }
    
        public OutputParameter OutputParameter(__Model model, string? id = null)
        {
            return (OutputParameter)Soal.OutputParameterInfo.Create(model, id)!;
        }
    
        public Port Port(__Model model, string? id = null)
        {
            return (Port)Soal.PortInfo.Create(model, id)!;
        }
    
        public PrimitiveType PrimitiveType(__Model model, string? id = null)
        {
            return (PrimitiveType)Soal.PrimitiveTypeInfo.Create(model, id)!;
        }
    
        public ProgrammingLanguage ProgrammingLanguage(__Model model, string? id = null)
        {
            return (ProgrammingLanguage)Soal.ProgrammingLanguageInfo.Create(model, id)!;
        }
    
        public Property Property(__Model model, string? id = null)
        {
            return (Property)Soal.PropertyInfo.Create(model, id)!;
        }
    
        public Reference Reference(__Model model, string? id = null)
        {
            return (Reference)Soal.ReferenceInfo.Create(model, id)!;
        }
    
        public RestTransportBindingElement RestTransportBindingElement(__Model model, string? id = null)
        {
            return (RestTransportBindingElement)Soal.RestTransportBindingElementInfo.Create(model, id)!;
        }
    
        public Runtime Runtime(__Model model, string? id = null)
        {
            return (Runtime)Soal.RuntimeInfo.Create(model, id)!;
        }
    
        public Service Service(__Model model, string? id = null)
        {
            return (Service)Soal.ServiceInfo.Create(model, id)!;
        }
    
        public SoapEncodingBindingElement SoapEncodingBindingElement(__Model model, string? id = null)
        {
            return (SoapEncodingBindingElement)Soal.SoapEncodingBindingElementInfo.Create(model, id)!;
        }
    
        public Struct Struct(__Model model, string? id = null)
        {
            return (Struct)Soal.StructInfo.Create(model, id)!;
        }
    
        public WebSocketTransportBindingElement WebSocketTransportBindingElement(__Model model, string? id = null)
        {
            return (WebSocketTransportBindingElement)Soal.WebSocketTransportBindingElementInfo.Create(model, id)!;
        }
    
        public Wire Wire(__Model model, string? id = null)
        {
            return (Wire)Soal.WireInfo.Create(model, id)!;
        }
    
        public WsAddressingBindingElement WsAddressingBindingElement(__Model model, string? id = null)
        {
            return (WsAddressingBindingElement)Soal.WsAddressingBindingElementInfo.Create(model, id)!;
        }
    
        public XmlEncodingBindingElement XmlEncodingBindingElement(__Model model, string? id = null)
        {
            return (XmlEncodingBindingElement)Soal.XmlEncodingBindingElementInfo.Create(model, id)!;
        }
    
    }
}
