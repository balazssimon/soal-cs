using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MetaDslx.Core;

namespace MetaDslx.Soal
{
    public static class SoalDescriptor
    {
        static SoalDescriptor()
        {
            AnnotatedElement.StaticInit();
            Annotation.StaticInit();
            AnnotationProperty.StaticInit();
            NamedElement.StaticInit();
            TypedElement.StaticInit();
            SoalType.StaticInit();
            Namespace.StaticInit();
            Declaration.StaticInit();
            ArrayType.StaticInit();
            NullableType.StaticInit();
            NonNullableType.StaticInit();
            PrimitiveType.StaticInit();
            Enum.StaticInit();
            EnumLiteral.StaticInit();
            Property.StaticInit();
            Struct.StaticInit();
            Interface.StaticInit();
            Database.StaticInit();
            Operation.StaticInit();
            InputParameter.StaticInit();
            OutputParameter.StaticInit();
            Component.StaticInit();
            Composite.StaticInit();
            Assembly.StaticInit();
            Wire.StaticInit();
            Port.StaticInit();
            Service.StaticInit();
            Reference.StaticInit();
            Implementation.StaticInit();
            Language.StaticInit();
            Deployment.StaticInit();
            Environment.StaticInit();
            Runtime.StaticInit();
            Binding.StaticInit();
            Endpoint.StaticInit();
            BindingElement.StaticInit();
            TransportBindingElement.StaticInit();
            EncodingBindingElement.StaticInit();
            ProtocolBindingElement.StaticInit();
            HttpTransportBindingElement.StaticInit();
            RestTransportBindingElement.StaticInit();
            WebSocketTransportBindingElement.StaticInit();
            SoapEncodingBindingElement.StaticInit();
            XmlEncodingBindingElement.StaticInit();
            JsonEncodingBindingElement.StaticInit();
            WsProtocolBindingElement.StaticInit();
            WsAddressingBindingElement.StaticInit();
        }
    
        internal static void StaticInit()
        {
        }
    
    	public const string Uri = "http://MetaDslx.Soal/1.0";
    
        
        public static class AnnotatedElement
        {
            internal static void StaticInit()
            {
            }
        
            static AnnotatedElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.AnnotatedElement; }
            }
        
        	
            [ContainmentAttribute]
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Annotation), "AnnotatedElement")]
            public static readonly ModelProperty AnnotationsProperty =
                ModelProperty.Register("Annotations", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>), typeof(global::MetaDslx.Soal.AnnotatedElement), typeof(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.AnnotatedElement_AnnotationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Annotation
        {
            internal static void StaticInit()
            {
            }
        
            static Annotation()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Annotation; }
            }
        
        	
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement), "Annotations")]
            public static readonly ModelProperty AnnotatedElementProperty =
                ModelProperty.Register("AnnotatedElement", typeof(global::MetaDslx.Soal.AnnotatedElement), typeof(global::MetaDslx.Soal.Annotation), typeof(global::MetaDslx.Soal.SoalDescriptor.Annotation), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Annotation_AnnotatedElementProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty PropertiesProperty =
                ModelProperty.Register("Properties", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.AnnotationProperty>), typeof(global::MetaDslx.Soal.Annotation), typeof(global::MetaDslx.Soal.SoalDescriptor.Annotation), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Annotation_PropertiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class AnnotationProperty
        {
            internal static void StaticInit()
            {
            }
        
            static AnnotationProperty()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.AnnotationProperty; }
            }
        
        	
            public static readonly ModelProperty ValueProperty =
                ModelProperty.Register("Value", typeof(object), typeof(global::MetaDslx.Soal.AnnotationProperty), typeof(global::MetaDslx.Soal.SoalDescriptor.AnnotationProperty), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.AnnotationProperty_ValueProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class NamedElement
        {
            internal static void StaticInit()
            {
            }
        
            static NamedElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.NamedElement; }
            }
        
        	
            [Name]
            public static readonly ModelProperty NameProperty =
                ModelProperty.Register("Name", typeof(string), typeof(global::MetaDslx.Soal.NamedElement), typeof(global::MetaDslx.Soal.SoalDescriptor.NamedElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class TypedElement
        {
            internal static void StaticInit()
            {
            }
        
            static TypedElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.TypedElement; }
            }
        
        	
            [Type]
            public static readonly ModelProperty TypeProperty =
                ModelProperty.Register("Type", typeof(global::MetaDslx.Soal.SoalType), typeof(global::MetaDslx.Soal.TypedElement), typeof(global::MetaDslx.Soal.SoalDescriptor.TypedElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.TypedElement_TypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class SoalType
        {
            internal static void StaticInit()
            {
            }
        
            static SoalType()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.SoalType; }
            }
        
        }
        
        public static class Namespace
        {
            internal static void StaticInit()
            {
            }
        
            static Namespace()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Namespace; }
            }
        
        	
            public static readonly ModelProperty UriProperty =
                ModelProperty.Register("Uri", typeof(string), typeof(global::MetaDslx.Soal.Namespace), typeof(global::MetaDslx.Soal.SoalDescriptor.Namespace), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Namespace_UriProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty PrefixProperty =
                ModelProperty.Register("Prefix", typeof(string), typeof(global::MetaDslx.Soal.Namespace), typeof(global::MetaDslx.Soal.SoalDescriptor.Namespace), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Namespace_PrefixProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ReadonlyAttribute]
            public static readonly ModelProperty FullNameProperty =
                ModelProperty.Register("FullName", typeof(string), typeof(global::MetaDslx.Soal.Namespace), typeof(global::MetaDslx.Soal.SoalDescriptor.Namespace), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Namespace_FullNameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ScopeEntry]
            [ContainmentAttribute]
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Declaration), "Namespace")]
            public static readonly ModelProperty DeclarationsProperty =
                ModelProperty.Register("Declarations", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Declaration>), typeof(global::MetaDslx.Soal.Namespace), typeof(global::MetaDslx.Soal.SoalDescriptor.Namespace), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Namespace_DeclarationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Declaration
        {
            internal static void StaticInit()
            {
            }
        
            static Declaration()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Declaration; }
            }
        
        	
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Namespace), "Declarations")]
            public static readonly ModelProperty NamespaceProperty =
                ModelProperty.Register("Namespace", typeof(global::MetaDslx.Soal.Namespace), typeof(global::MetaDslx.Soal.Declaration), typeof(global::MetaDslx.Soal.SoalDescriptor.Declaration), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Declaration_NamespaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class ArrayType
        {
            internal static void StaticInit()
            {
            }
        
            static ArrayType()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.ArrayType; }
            }
        
        	
            public static readonly ModelProperty InnerTypeProperty =
                ModelProperty.Register("InnerType", typeof(global::MetaDslx.Soal.SoalType), typeof(global::MetaDslx.Soal.ArrayType), typeof(global::MetaDslx.Soal.SoalDescriptor.ArrayType), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.ArrayType_InnerTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class NullableType
        {
            internal static void StaticInit()
            {
            }
        
            static NullableType()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.NullableType; }
            }
        
        	
            public static readonly ModelProperty InnerTypeProperty =
                ModelProperty.Register("InnerType", typeof(global::MetaDslx.Soal.SoalType), typeof(global::MetaDslx.Soal.NullableType), typeof(global::MetaDslx.Soal.SoalDescriptor.NullableType), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.NullableType_InnerTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class NonNullableType
        {
            internal static void StaticInit()
            {
            }
        
            static NonNullableType()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.NonNullableType; }
            }
        
        	
            public static readonly ModelProperty InnerTypeProperty =
                ModelProperty.Register("InnerType", typeof(global::MetaDslx.Soal.SoalType), typeof(global::MetaDslx.Soal.NonNullableType), typeof(global::MetaDslx.Soal.SoalDescriptor.NonNullableType), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.NonNullableType_InnerTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class PrimitiveType
        {
            internal static void StaticInit()
            {
            }
        
            static PrimitiveType()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.PrimitiveType; }
            }
        
        	
            public static readonly ModelProperty NullableProperty =
                ModelProperty.Register("Nullable", typeof(bool), typeof(global::MetaDslx.Soal.PrimitiveType), typeof(global::MetaDslx.Soal.SoalDescriptor.PrimitiveType), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.PrimitiveType_NullableProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Enum
        {
            internal static void StaticInit()
            {
            }
        
            static Enum()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Enum; }
            }
        
        	
            [InheritedScope]
            public static readonly ModelProperty BaseTypeProperty =
                ModelProperty.Register("BaseType", typeof(global::MetaDslx.Soal.Enum), typeof(global::MetaDslx.Soal.Enum), typeof(global::MetaDslx.Soal.SoalDescriptor.Enum), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Enum_BaseTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ScopeEntry]
            [ContainmentAttribute]
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.EnumLiteral), "Enum")]
            public static readonly ModelProperty EnumLiteralsProperty =
                ModelProperty.Register("EnumLiterals", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.EnumLiteral>), typeof(global::MetaDslx.Soal.Enum), typeof(global::MetaDslx.Soal.SoalDescriptor.Enum), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Enum_EnumLiteralsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class EnumLiteral
        {
            internal static void StaticInit()
            {
            }
        
            static EnumLiteral()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.EnumLiteral; }
            }
        
        	
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Enum), "EnumLiterals")]
            public static readonly ModelProperty EnumProperty =
                ModelProperty.Register("Enum", typeof(global::MetaDslx.Soal.Enum), typeof(global::MetaDslx.Soal.EnumLiteral), typeof(global::MetaDslx.Soal.SoalDescriptor.EnumLiteral), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.EnumLiteral_EnumProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Property
        {
            internal static void StaticInit()
            {
            }
        
            static Property()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Property; }
            }
        
        }
        
        public static class Struct
        {
            internal static void StaticInit()
            {
            }
        
            static Struct()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Struct; }
            }
        
        	
            [InheritedScope]
            public static readonly ModelProperty BaseTypeProperty =
                ModelProperty.Register("BaseType", typeof(global::MetaDslx.Soal.Struct), typeof(global::MetaDslx.Soal.Struct), typeof(global::MetaDslx.Soal.SoalDescriptor.Struct), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Struct_BaseTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ScopeEntry]
            [ContainmentAttribute]
            public static readonly ModelProperty PropertiesProperty =
                ModelProperty.Register("Properties", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>), typeof(global::MetaDslx.Soal.Struct), typeof(global::MetaDslx.Soal.SoalDescriptor.Struct), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Struct_PropertiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Interface
        {
            internal static void StaticInit()
            {
            }
        
            static Interface()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Interface; }
            }
        
        	
            [ScopeEntry]
            [ContainmentAttribute]
            public static readonly ModelProperty OperationsProperty =
                ModelProperty.Register("Operations", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation>), typeof(global::MetaDslx.Soal.Interface), typeof(global::MetaDslx.Soal.SoalDescriptor.Interface), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Interface_OperationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Database
        {
            internal static void StaticInit()
            {
            }
        
            static Database()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Database; }
            }
        
        	
            [ScopeEntry]
            public static readonly ModelProperty EntitiesProperty =
                ModelProperty.Register("Entities", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct>), typeof(global::MetaDslx.Soal.Database), typeof(global::MetaDslx.Soal.SoalDescriptor.Database), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Database_EntitiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Operation
        {
            internal static void StaticInit()
            {
            }
        
            static Operation()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Operation; }
            }
        
        	
            public static readonly ModelProperty ActionProperty =
                ModelProperty.Register("Action", typeof(string), typeof(global::MetaDslx.Soal.Operation), typeof(global::MetaDslx.Soal.SoalDescriptor.Operation), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Operation_ActionProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty ParametersProperty =
                ModelProperty.Register("Parameters", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.InputParameter>), typeof(global::MetaDslx.Soal.Operation), typeof(global::MetaDslx.Soal.SoalDescriptor.Operation), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Operation_ParametersProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ReadonlyAttribute]
            public static readonly ModelProperty ResultProperty =
                ModelProperty.Register("Result", typeof(global::MetaDslx.Soal.OutputParameter), typeof(global::MetaDslx.Soal.Operation), typeof(global::MetaDslx.Soal.SoalDescriptor.Operation), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Operation_ResultProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty ExceptionsProperty =
                ModelProperty.Register("Exceptions", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct>), typeof(global::MetaDslx.Soal.Operation), typeof(global::MetaDslx.Soal.SoalDescriptor.Operation), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Operation_ExceptionsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class InputParameter
        {
            internal static void StaticInit()
            {
            }
        
            static InputParameter()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.InputParameter; }
            }
        
        }
        
        public static class OutputParameter
        {
            internal static void StaticInit()
            {
            }
        
            static OutputParameter()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.OutputParameter; }
            }
        
        	
            public static readonly ModelProperty IsOnewayProperty =
                ModelProperty.Register("IsOneway", typeof(bool), typeof(global::MetaDslx.Soal.OutputParameter), typeof(global::MetaDslx.Soal.SoalDescriptor.OutputParameter), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.OutputParameter_IsOnewayProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Component
        {
            internal static void StaticInit()
            {
            }
        
            static Component()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Component; }
            }
        
        	
            [InheritedScope]
            public static readonly ModelProperty BaseComponentProperty =
                ModelProperty.Register("BaseComponent", typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_BaseComponentProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty IsAbstractProperty =
                ModelProperty.Register("IsAbstract", typeof(bool), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_IsAbstractProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ScopeEntry]
            [ContainmentAttribute]
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Port), "Component")]
            public static readonly ModelProperty PortsProperty =
                ModelProperty.Register("Ports", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_PortsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            [SubsetsAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Component), "Ports")]
            public static readonly ModelProperty ServicesProperty =
                ModelProperty.Register("Services", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_ServicesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            [SubsetsAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Component), "Ports")]
            public static readonly ModelProperty ReferencesProperty =
                ModelProperty.Register("References", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_ReferencesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ScopeEntry]
            [ContainmentAttribute]
            public static readonly ModelProperty PropertiesProperty =
                ModelProperty.Register("Properties", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_PropertiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty ImplementationProperty =
                ModelProperty.Register("Implementation", typeof(global::MetaDslx.Soal.Implementation), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_ImplementationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty LanguageProperty =
                ModelProperty.Register("Language", typeof(global::MetaDslx.Soal.Language), typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.SoalDescriptor.Component), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Component_LanguageProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Composite
        {
            internal static void StaticInit()
            {
            }
        
            static Composite()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Composite; }
            }
        
        	
            [ScopeEntry]
            public static readonly ModelProperty ComponentsProperty =
                ModelProperty.Register("Components", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component>), typeof(global::MetaDslx.Soal.Composite), typeof(global::MetaDslx.Soal.SoalDescriptor.Composite), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Composite_ComponentsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty WiresProperty =
                ModelProperty.Register("Wires", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>), typeof(global::MetaDslx.Soal.Composite), typeof(global::MetaDslx.Soal.SoalDescriptor.Composite), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Composite_WiresProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Assembly
        {
            internal static void StaticInit()
            {
            }
        
            static Assembly()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Assembly; }
            }
        
        }
        
        public static class Wire
        {
            internal static void StaticInit()
            {
            }
        
            static Wire()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Wire; }
            }
        
        	
            public static readonly ModelProperty SourceProperty =
                ModelProperty.Register("Source", typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.Wire), typeof(global::MetaDslx.Soal.SoalDescriptor.Wire), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Wire_SourceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty TargetProperty =
                ModelProperty.Register("Target", typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.Wire), typeof(global::MetaDslx.Soal.SoalDescriptor.Wire), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Wire_TargetProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Port
        {
            internal static void StaticInit()
            {
            }
        
            static Port()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Port; }
            }
        
        	
            [OppositeAttribute(typeof(global::MetaDslx.Soal.SoalDescriptor.Component), "Ports")]
            public static readonly ModelProperty ComponentProperty =
                ModelProperty.Register("Component", typeof(global::MetaDslx.Soal.Component), typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.SoalDescriptor.Port), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Port_ComponentProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [Name]
            [ReadonlyAttribute]
            public static readonly ModelProperty NameProperty =
                ModelProperty.Register("Name", typeof(string), typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.SoalDescriptor.Port), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Port_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty OptionalNameProperty =
                ModelProperty.Register("OptionalName", typeof(string), typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.SoalDescriptor.Port), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Port_OptionalNameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty InterfaceProperty =
                ModelProperty.Register("Interface", typeof(global::MetaDslx.Soal.Interface), typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.SoalDescriptor.Port), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Port_InterfaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty BindingProperty =
                ModelProperty.Register("Binding", typeof(global::MetaDslx.Soal.Binding), typeof(global::MetaDslx.Soal.Port), typeof(global::MetaDslx.Soal.SoalDescriptor.Port), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Port_BindingProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Service
        {
            internal static void StaticInit()
            {
            }
        
            static Service()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Service; }
            }
        
        }
        
        public static class Reference
        {
            internal static void StaticInit()
            {
            }
        
            static Reference()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Reference; }
            }
        
        }
        
        public static class Implementation
        {
            internal static void StaticInit()
            {
            }
        
            static Implementation()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Implementation; }
            }
        
        }
        
        public static class Language
        {
            internal static void StaticInit()
            {
            }
        
            static Language()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Language; }
            }
        
        }
        
        public static class Deployment
        {
            internal static void StaticInit()
            {
            }
        
            static Deployment()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Deployment; }
            }
        
        	
            [ContainmentAttribute]
            public static readonly ModelProperty EnvironmentsProperty =
                ModelProperty.Register("Environments", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Environment>), typeof(global::MetaDslx.Soal.Deployment), typeof(global::MetaDslx.Soal.SoalDescriptor.Deployment), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Deployment_EnvironmentsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty WiresProperty =
                ModelProperty.Register("Wires", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>), typeof(global::MetaDslx.Soal.Deployment), typeof(global::MetaDslx.Soal.SoalDescriptor.Deployment), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Deployment_WiresProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Environment
        {
            internal static void StaticInit()
            {
            }
        
            static Environment()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Environment; }
            }
        
        	
            [ContainmentAttribute]
            public static readonly ModelProperty RuntimeProperty =
                ModelProperty.Register("Runtime", typeof(global::MetaDslx.Soal.Runtime), typeof(global::MetaDslx.Soal.Environment), typeof(global::MetaDslx.Soal.SoalDescriptor.Environment), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Environment_RuntimeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty DatabasesProperty =
                ModelProperty.Register("Databases", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Database>), typeof(global::MetaDslx.Soal.Environment), typeof(global::MetaDslx.Soal.SoalDescriptor.Environment), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Environment_DatabasesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty AssembliesProperty =
                ModelProperty.Register("Assemblies", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Assembly>), typeof(global::MetaDslx.Soal.Environment), typeof(global::MetaDslx.Soal.SoalDescriptor.Environment), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Environment_AssembliesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Runtime
        {
            internal static void StaticInit()
            {
            }
        
            static Runtime()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Runtime; }
            }
        
        }
        
        public static class Binding
        {
            internal static void StaticInit()
            {
            }
        
            static Binding()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Binding; }
            }
        
        	
            [ContainmentAttribute]
            public static readonly ModelProperty TransportProperty =
                ModelProperty.Register("Transport", typeof(global::MetaDslx.Soal.TransportBindingElement), typeof(global::MetaDslx.Soal.Binding), typeof(global::MetaDslx.Soal.SoalDescriptor.Binding), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Binding_TransportProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty EncodingsProperty =
                ModelProperty.Register("Encodings", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.EncodingBindingElement>), typeof(global::MetaDslx.Soal.Binding), typeof(global::MetaDslx.Soal.SoalDescriptor.Binding), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Binding_EncodingsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            [ContainmentAttribute]
            public static readonly ModelProperty ProtocolsProperty =
                ModelProperty.Register("Protocols", typeof(global::System.Collections.Generic.IList<global::MetaDslx.Soal.ProtocolBindingElement>), typeof(global::MetaDslx.Soal.Binding), typeof(global::MetaDslx.Soal.SoalDescriptor.Binding), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Binding_ProtocolsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class Endpoint
        {
            internal static void StaticInit()
            {
            }
        
            static Endpoint()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.Endpoint; }
            }
        
        	
            public static readonly ModelProperty InterfaceProperty =
                ModelProperty.Register("Interface", typeof(global::MetaDslx.Soal.Interface), typeof(global::MetaDslx.Soal.Endpoint), typeof(global::MetaDslx.Soal.SoalDescriptor.Endpoint), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Endpoint_InterfaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty BindingProperty =
                ModelProperty.Register("Binding", typeof(global::MetaDslx.Soal.Binding), typeof(global::MetaDslx.Soal.Endpoint), typeof(global::MetaDslx.Soal.SoalDescriptor.Endpoint), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Endpoint_BindingProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty AddressProperty =
                ModelProperty.Register("Address", typeof(string), typeof(global::MetaDslx.Soal.Endpoint), typeof(global::MetaDslx.Soal.SoalDescriptor.Endpoint), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.Endpoint_AddressProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class BindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static BindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.BindingElement; }
            }
        
        }
        
        public static class TransportBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static TransportBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.TransportBindingElement; }
            }
        
        }
        
        public static class EncodingBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static EncodingBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.EncodingBindingElement; }
            }
        
        }
        
        public static class ProtocolBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static ProtocolBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.ProtocolBindingElement; }
            }
        
        }
        
        public static class HttpTransportBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static HttpTransportBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.HttpTransportBindingElement; }
            }
        
        	
            public static readonly ModelProperty SslProperty =
                ModelProperty.Register("Ssl", typeof(bool), typeof(global::MetaDslx.Soal.HttpTransportBindingElement), typeof(global::MetaDslx.Soal.SoalDescriptor.HttpTransportBindingElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.HttpTransportBindingElement_SslProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty ClientAuthenticationProperty =
                ModelProperty.Register("ClientAuthentication", typeof(bool), typeof(global::MetaDslx.Soal.HttpTransportBindingElement), typeof(global::MetaDslx.Soal.SoalDescriptor.HttpTransportBindingElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.HttpTransportBindingElement_ClientAuthenticationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class RestTransportBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static RestTransportBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.RestTransportBindingElement; }
            }
        
        }
        
        public static class WebSocketTransportBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static WebSocketTransportBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.WebSocketTransportBindingElement; }
            }
        
        }
        
        public static class SoapEncodingBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static SoapEncodingBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.SoapEncodingBindingElement; }
            }
        
        	
            public static readonly ModelProperty StyleProperty =
                ModelProperty.Register("Style", typeof(global::MetaDslx.Soal.SoapEncodingStyle), typeof(global::MetaDslx.Soal.SoapEncodingBindingElement), typeof(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.SoapEncodingBindingElement_StyleProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty VersionProperty =
                ModelProperty.Register("Version", typeof(global::MetaDslx.Soal.SoapVersion), typeof(global::MetaDslx.Soal.SoapEncodingBindingElement), typeof(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.SoapEncodingBindingElement_VersionProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        	
            public static readonly ModelProperty MtomProperty =
                ModelProperty.Register("Mtom", typeof(bool), typeof(global::MetaDslx.Soal.SoapEncodingBindingElement), typeof(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement), new Lazy<global::MetaDslx.Core.MetaProperty>(() => global::MetaDslx.Soal.SoalInstance.SoapEncodingBindingElement_MtomProperty, LazyThreadSafetyMode.ExecutionAndPublication));
            
        }
        
        public static class XmlEncodingBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static XmlEncodingBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.XmlEncodingBindingElement; }
            }
        
        }
        
        public static class JsonEncodingBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static JsonEncodingBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.JsonEncodingBindingElement; }
            }
        
        }
        
        public static class WsProtocolBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static WsProtocolBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.WsProtocolBindingElement; }
            }
        
        }
        
        public static class WsAddressingBindingElement
        {
            internal static void StaticInit()
            {
            }
        
            static WsAddressingBindingElement()
            {
                global::MetaDslx.Soal.SoalDescriptor.StaticInit();
            }
        
            public static global::MetaDslx.Core.MetaClass MetaClass
            {
                get { return global::MetaDslx.Soal.SoalInstance.WsAddressingBindingElement; }
            }
        
        }
    }
    
	public static class SoalInstance
	{
	    private static global::MetaDslx.Core.Model model;
	
	    public static global::MetaDslx.Core.Model Model
	    {
	        get { return SoalInstance.model; }
	    }
	
	    public static readonly global::MetaDslx.Core.MetaModel Meta;
	
	    public static readonly global::MetaDslx.Soal.PrimitiveType Object;
	    public static readonly global::MetaDslx.Soal.PrimitiveType String;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Int;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Long;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Float;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Double;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Byte;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Bool;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Void;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Date;
	    public static readonly global::MetaDslx.Soal.PrimitiveType Time;
	    public static readonly global::MetaDslx.Soal.PrimitiveType DateTime;
	    public static readonly global::MetaDslx.Soal.PrimitiveType TimeSpan;
	
		private static readonly global::MetaDslx.Core.MetaNamespace __tmp1;
		private static readonly global::MetaDslx.Core.MetaNamespace __tmp2;
		private static readonly global::MetaDslx.Core.MetaModel __tmp3;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp4;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp5;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp6;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp7;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp8;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp9;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp10;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp11;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp12;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp13;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp14;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp15;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp16;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp17;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp18;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp19;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp20;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp21;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp22;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp23;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp24;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp25;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp26;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp27;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp28;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp29;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp30;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp31;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp32;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp33;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp34;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp35;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp36;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp37;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp38;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp39;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp40;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp41;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp42;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp43;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp44;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp45;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp46;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp47;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp48;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp49;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp50;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp51;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp52;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp53;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp54;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp55;
		private static readonly global::MetaDslx.Core.MetaConstant __tmp56;
		private static readonly global::MetaDslx.Core.MetaNewExpression __tmp57;
		private static readonly global::MetaDslx.Core.MetaNewPropertyInitializer __tmp58;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp59;
		public static readonly global::MetaDslx.Core.MetaClass AnnotatedElement;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp60;
		public static readonly global::MetaDslx.Core.MetaProperty AnnotatedElement_AnnotationsProperty;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp61;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp62;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp63;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp64;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp65;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp66;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp67;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp68;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp69;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp70;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp71;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp72;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp73;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp74;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp75;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp76;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp77;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp78;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp79;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp80;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp81;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp82;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp83;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp84;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp85;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp86;
		public static readonly global::MetaDslx.Core.MetaClass Annotation;
		public static readonly global::MetaDslx.Core.MetaProperty Annotation_AnnotatedElementProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp87;
		public static readonly global::MetaDslx.Core.MetaProperty Annotation_PropertiesProperty;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp88;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp89;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp90;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp91;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp92;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp93;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp94;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp95;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp96;
		private static readonly global::MetaDslx.Core.MetaOperation __tmp97;
		private static readonly global::MetaDslx.Core.MetaFunctionType __tmp98;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp99;
		private static readonly global::MetaDslx.Core.MetaParameter __tmp100;
		public static readonly global::MetaDslx.Core.MetaClass AnnotationProperty;
		public static readonly global::MetaDslx.Core.MetaProperty AnnotationProperty_ValueProperty;
		public static readonly global::MetaDslx.Core.MetaClass NamedElement;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp101;
		public static readonly global::MetaDslx.Core.MetaProperty NamedElement_NameProperty;
		public static readonly global::MetaDslx.Core.MetaClass TypedElement;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp102;
		public static readonly global::MetaDslx.Core.MetaProperty TypedElement_TypeProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp103;
		public static readonly global::MetaDslx.Core.MetaClass SoalType;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp104;
		public static readonly global::MetaDslx.Core.MetaClass Namespace;
		public static readonly global::MetaDslx.Core.MetaProperty Namespace_UriProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Namespace_PrefixProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Namespace_FullNameProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp105;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp106;
		public static readonly global::MetaDslx.Core.MetaProperty Namespace_DeclarationsProperty;
		public static readonly global::MetaDslx.Core.MetaClass Declaration;
		public static readonly global::MetaDslx.Core.MetaProperty Declaration_NamespaceProperty;
		public static readonly global::MetaDslx.Core.MetaClass ArrayType;
		public static readonly global::MetaDslx.Core.MetaProperty ArrayType_InnerTypeProperty;
		public static readonly global::MetaDslx.Core.MetaClass NullableType;
		public static readonly global::MetaDslx.Core.MetaProperty NullableType_InnerTypeProperty;
		public static readonly global::MetaDslx.Core.MetaClass NonNullableType;
		public static readonly global::MetaDslx.Core.MetaProperty NonNullableType_InnerTypeProperty;
		public static readonly global::MetaDslx.Core.MetaClass PrimitiveType;
		private static readonly global::MetaDslx.Core.MetaConstructor __tmp107;
		private static readonly global::MetaDslx.Core.MetaSynthetizedPropertyInitializer __tmp108;
		private static readonly global::MetaDslx.Core.MetaConstantExpression __tmp109;
		public static readonly global::MetaDslx.Core.MetaProperty PrimitiveType_NullableProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp110;
		public static readonly global::MetaDslx.Core.MetaClass Enum;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp111;
		public static readonly global::MetaDslx.Core.MetaProperty Enum_BaseTypeProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp112;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp113;
		public static readonly global::MetaDslx.Core.MetaProperty Enum_EnumLiteralsProperty;
		public static readonly global::MetaDslx.Core.MetaClass EnumLiteral;
		private static readonly global::MetaDslx.Core.MetaConstructor __tmp114;
		private static readonly global::MetaDslx.Core.MetaSynthetizedPropertyInitializer __tmp115;
		private static readonly global::MetaDslx.Core.MetaIdentifierExpression __tmp116;
		public static readonly global::MetaDslx.Core.MetaProperty EnumLiteral_EnumProperty;
		public static readonly global::MetaDslx.Core.MetaClass Property;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp117;
		public static readonly global::MetaDslx.Core.MetaClass Struct;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp118;
		public static readonly global::MetaDslx.Core.MetaProperty Struct_BaseTypeProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp119;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp120;
		public static readonly global::MetaDslx.Core.MetaProperty Struct_PropertiesProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp121;
		public static readonly global::MetaDslx.Core.MetaClass Interface;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp122;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp123;
		public static readonly global::MetaDslx.Core.MetaProperty Interface_OperationsProperty;
		public static readonly global::MetaDslx.Core.MetaClass Database;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp124;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp125;
		public static readonly global::MetaDslx.Core.MetaProperty Database_EntitiesProperty;
		public static readonly global::MetaDslx.Core.MetaClass Operation;
		public static readonly global::MetaDslx.Core.MetaProperty Operation_ActionProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp126;
		public static readonly global::MetaDslx.Core.MetaProperty Operation_ParametersProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Operation_ResultProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp127;
		public static readonly global::MetaDslx.Core.MetaProperty Operation_ExceptionsProperty;
		public static readonly global::MetaDslx.Core.MetaClass InputParameter;
		public static readonly global::MetaDslx.Core.MetaClass OutputParameter;
		public static readonly global::MetaDslx.Core.MetaProperty OutputParameter_IsOnewayProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp128;
		public static readonly global::MetaDslx.Core.MetaClass Component;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp129;
		public static readonly global::MetaDslx.Core.MetaProperty Component_BaseComponentProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Component_IsAbstractProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp130;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp131;
		public static readonly global::MetaDslx.Core.MetaProperty Component_PortsProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp132;
		public static readonly global::MetaDslx.Core.MetaProperty Component_ServicesProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp133;
		public static readonly global::MetaDslx.Core.MetaProperty Component_ReferencesProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp134;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp135;
		public static readonly global::MetaDslx.Core.MetaProperty Component_PropertiesProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Component_ImplementationProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Component_LanguageProperty;
		public static readonly global::MetaDslx.Core.MetaClass Composite;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp136;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp137;
		public static readonly global::MetaDslx.Core.MetaProperty Composite_ComponentsProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp138;
		public static readonly global::MetaDslx.Core.MetaProperty Composite_WiresProperty;
		public static readonly global::MetaDslx.Core.MetaClass Assembly;
		public static readonly global::MetaDslx.Core.MetaClass Wire;
		public static readonly global::MetaDslx.Core.MetaProperty Wire_SourceProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Wire_TargetProperty;
		public static readonly global::MetaDslx.Core.MetaClass Port;
		private static readonly global::MetaDslx.Core.MetaConstructor __tmp139;
		public static readonly global::MetaDslx.Core.MetaProperty Port_ComponentProperty;
		private static readonly global::MetaDslx.Core.MetaAnnotation __tmp140;
		public static readonly global::MetaDslx.Core.MetaProperty Port_NameProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Port_OptionalNameProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Port_InterfaceProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Port_BindingProperty;
		public static readonly global::MetaDslx.Core.MetaClass Service;
		public static readonly global::MetaDslx.Core.MetaClass Reference;
		public static readonly global::MetaDslx.Core.MetaClass Implementation;
		public static readonly global::MetaDslx.Core.MetaClass Language;
		public static readonly global::MetaDslx.Core.MetaClass Deployment;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp141;
		public static readonly global::MetaDslx.Core.MetaProperty Deployment_EnvironmentsProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp142;
		public static readonly global::MetaDslx.Core.MetaProperty Deployment_WiresProperty;
		public static readonly global::MetaDslx.Core.MetaClass Environment;
		public static readonly global::MetaDslx.Core.MetaProperty Environment_RuntimeProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp143;
		public static readonly global::MetaDslx.Core.MetaProperty Environment_DatabasesProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp144;
		public static readonly global::MetaDslx.Core.MetaProperty Environment_AssembliesProperty;
		public static readonly global::MetaDslx.Core.MetaClass Runtime;
		public static readonly global::MetaDslx.Core.MetaClass Binding;
		public static readonly global::MetaDslx.Core.MetaProperty Binding_TransportProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp145;
		public static readonly global::MetaDslx.Core.MetaProperty Binding_EncodingsProperty;
		private static readonly global::MetaDslx.Core.MetaCollectionType __tmp146;
		public static readonly global::MetaDslx.Core.MetaProperty Binding_ProtocolsProperty;
		public static readonly global::MetaDslx.Core.MetaClass Endpoint;
		public static readonly global::MetaDslx.Core.MetaProperty Endpoint_InterfaceProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Endpoint_BindingProperty;
		public static readonly global::MetaDslx.Core.MetaProperty Endpoint_AddressProperty;
		public static readonly global::MetaDslx.Core.MetaClass BindingElement;
		public static readonly global::MetaDslx.Core.MetaClass TransportBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass EncodingBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass ProtocolBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass HttpTransportBindingElement;
		public static readonly global::MetaDslx.Core.MetaProperty HttpTransportBindingElement_SslProperty;
		public static readonly global::MetaDslx.Core.MetaProperty HttpTransportBindingElement_ClientAuthenticationProperty;
		public static readonly global::MetaDslx.Core.MetaClass RestTransportBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass WebSocketTransportBindingElement;
		public static readonly global::MetaDslx.Core.MetaEnum SoapVersion;
		private static readonly global::MetaDslx.Core.MetaEnumLiteral __tmp147;
		private static readonly global::MetaDslx.Core.MetaEnumLiteral __tmp148;
		public static readonly global::MetaDslx.Core.MetaEnum SoapEncodingStyle;
		private static readonly global::MetaDslx.Core.MetaEnumLiteral __tmp149;
		private static readonly global::MetaDslx.Core.MetaEnumLiteral __tmp150;
		private static readonly global::MetaDslx.Core.MetaEnumLiteral __tmp151;
		private static readonly global::MetaDslx.Core.MetaEnumLiteral __tmp152;
		public static readonly global::MetaDslx.Core.MetaClass SoapEncodingBindingElement;
		public static readonly global::MetaDslx.Core.MetaProperty SoapEncodingBindingElement_StyleProperty;
		public static readonly global::MetaDslx.Core.MetaProperty SoapEncodingBindingElement_VersionProperty;
		public static readonly global::MetaDslx.Core.MetaProperty SoapEncodingBindingElement_MtomProperty;
		public static readonly global::MetaDslx.Core.MetaClass XmlEncodingBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass JsonEncodingBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass WsProtocolBindingElement;
		public static readonly global::MetaDslx.Core.MetaClass WsAddressingBindingElement;
	
	    static SoalInstance()
	    {
			SoalDescriptor.StaticInit();
			SoalInstance.model = new global::MetaDslx.Core.Model();
	   		using (new ModelContextScope(SoalInstance.model))
			{
	            Object = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "object", LazyThreadSafetyMode.ExecutionAndPublication)), new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.PrimitiveType.NullableProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication))});
	            String = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "string", LazyThreadSafetyMode.ExecutionAndPublication)), new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.PrimitiveType.NullableProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication))});
	            Int = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "int", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Long = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "long", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Float = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "float", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Double = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "double", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Byte = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "byte", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Bool = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "bool", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Void = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "void", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Date = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "Date", LazyThreadSafetyMode.ExecutionAndPublication))});
	            Time = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "Time", LazyThreadSafetyMode.ExecutionAndPublication))});
	            DateTime = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "DateTime", LazyThreadSafetyMode.ExecutionAndPublication))});
	            TimeSpan = global::MetaDslx.Soal.SoalFactory.Instance.CreatePrimitiveType(new List<ModelPropertyInitializer>() {new ModelPropertyInitializer(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, new Lazy<object>(() => "TimeSpan", LazyThreadSafetyMode.ExecutionAndPublication))});
	
				__tmp1 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNamespace();
				__tmp2 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNamespace();
				__tmp3 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaModel();
				Meta = __tmp3;
				__tmp4 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp5 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp6 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp7 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp8 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp9 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp10 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp11 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp12 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp13 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp14 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp15 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp16 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp17 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp18 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp19 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp20 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp21 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp22 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp23 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp24 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp25 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp26 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp27 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp28 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp29 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp30 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp31 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp32 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp33 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp34 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp35 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp36 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp37 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp38 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp39 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp40 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp41 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp42 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp43 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp44 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp45 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp46 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp47 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp48 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp49 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp50 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp51 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp52 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp53 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp54 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp55 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				__tmp56 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstant();
				__tmp57 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewExpression();
				__tmp58 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaNewPropertyInitializer();
				__tmp59 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				AnnotatedElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp60 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				AnnotatedElement_AnnotationsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp61 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp62 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp63 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp64 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp65 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp66 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp67 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp68 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp69 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp70 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				__tmp71 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp72 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp73 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp74 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp75 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp76 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp77 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp78 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp79 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp80 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp81 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp82 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp83 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp84 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp85 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp86 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				Annotation = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Annotation_AnnotatedElementProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp87 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Annotation_PropertiesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp88 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp89 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp90 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp91 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp92 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp93 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp94 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp95 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp96 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp97 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaOperation();
				__tmp98 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaFunctionType();
				__tmp99 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				__tmp100 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaParameter();
				AnnotationProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				AnnotationProperty_ValueProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				NamedElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp101 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				NamedElement_NameProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				TypedElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp102 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				TypedElement_TypeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp103 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				SoalType = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp104 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Namespace = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Namespace_UriProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Namespace_PrefixProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Namespace_FullNameProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp105 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp106 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Namespace_DeclarationsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Declaration = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Declaration_NamespaceProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				ArrayType = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				ArrayType_InnerTypeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				NullableType = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				NullableType_InnerTypeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				NonNullableType = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				NonNullableType_InnerTypeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				PrimitiveType = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp107 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstructor();
				__tmp108 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaSynthetizedPropertyInitializer();
				__tmp109 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstantExpression();
				PrimitiveType_NullableProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp110 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Enum = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp111 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Enum_BaseTypeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp112 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp113 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Enum_EnumLiteralsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				EnumLiteral = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp114 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstructor();
				__tmp115 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaSynthetizedPropertyInitializer();
				__tmp116 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaIdentifierExpression();
				EnumLiteral_EnumProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Property = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp117 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Struct = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp118 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Struct_BaseTypeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp119 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp120 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Struct_PropertiesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp121 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Interface = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp122 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp123 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Interface_OperationsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Database = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp124 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp125 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Database_EntitiesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Operation = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Operation_ActionProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp126 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Operation_ParametersProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Operation_ResultProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp127 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Operation_ExceptionsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				InputParameter = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				OutputParameter = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				OutputParameter_IsOnewayProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp128 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Component = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp129 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Component_BaseComponentProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Component_IsAbstractProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp130 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp131 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Component_PortsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp132 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Component_ServicesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp133 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Component_ReferencesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp134 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp135 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Component_PropertiesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Component_ImplementationProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Component_LanguageProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Composite = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp136 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				__tmp137 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Composite_ComponentsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp138 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Composite_WiresProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Assembly = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Wire = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Wire_SourceProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Wire_TargetProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Port = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp139 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaConstructor();
				Port_ComponentProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp140 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaAnnotation();
				Port_NameProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Port_OptionalNameProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Port_InterfaceProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Port_BindingProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Service = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Reference = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Implementation = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Language = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Deployment = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				__tmp141 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Deployment_EnvironmentsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp142 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Deployment_WiresProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Environment = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Environment_RuntimeProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp143 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Environment_DatabasesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp144 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Environment_AssembliesProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Runtime = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Binding = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Binding_TransportProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp145 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Binding_EncodingsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				__tmp146 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaCollectionType();
				Binding_ProtocolsProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Endpoint = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				Endpoint_InterfaceProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Endpoint_BindingProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				Endpoint_AddressProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				BindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				TransportBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				EncodingBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				ProtocolBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				HttpTransportBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				HttpTransportBindingElement_SslProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				HttpTransportBindingElement_ClientAuthenticationProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				RestTransportBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				WebSocketTransportBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				SoapVersion = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnum();
				__tmp147 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnumLiteral();
				__tmp148 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnumLiteral();
				SoapEncodingStyle = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnum();
				__tmp149 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnumLiteral();
				__tmp150 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnumLiteral();
				__tmp151 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnumLiteral();
				__tmp152 = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaEnumLiteral();
				SoapEncodingBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				SoapEncodingBindingElement_StyleProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				SoapEncodingBindingElement_VersionProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				SoapEncodingBindingElement_MtomProperty = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaProperty();
				XmlEncodingBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				JsonEncodingBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				WsProtocolBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
				WsAddressingBindingElement = global::MetaDslx.Core.MetaFactory.Instance.CreateMetaClass();
	
				((ModelObject)__tmp1).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.ParentProperty);
				((ModelObject)__tmp1).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.ParentProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp1).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.MetaModelProperty);
				((ModelObject)__tmp1).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.MetaModelProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp1).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.NamespacesProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp1).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp1).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "MetaDslx", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp1).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp1).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.ParentProperty);
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.ParentProperty, new Lazy<object>(() => __tmp1, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.MetaModelProperty);
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.MetaModelProperty, new Lazy<object>(() => __tmp3, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp4, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp10, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp16, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp20, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp24, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp28, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp32, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp36, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp40, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp44, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp48, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp52, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => __tmp56, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => TypedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Namespace, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => ArrayType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => NullableType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => NonNullableType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Enum, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => EnumLiteral, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Property, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Struct, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Interface, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Database, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Operation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => InputParameter, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => OutputParameter, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Composite, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Assembly, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Wire, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Service, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Reference, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Implementation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Language, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Deployment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Environment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Runtime, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Binding, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => Endpoint, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => BindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => TransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => EncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => ProtocolBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => HttpTransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => RestTransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => WebSocketTransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => SoapVersion, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => SoapEncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => XmlEncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => JsonEncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => WsProtocolBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamespace.DeclarationsProperty, new Lazy<object>(() => WsAddressingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Soal", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp2).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp2).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp3).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaModel.UriProperty);
				((ModelObject)__tmp3).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaModel.UriProperty, new Lazy<object>(() => "http://MetaDslx.Soal/1.0", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp3).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaModel.NamespaceProperty);
				((ModelObject)__tmp3).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaModel.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp3).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp3).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Soal", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp3).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp3).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp4).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp4).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp5, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp4).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp4).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp4).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp4).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp4).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp4).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Object", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp4).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp4).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp5).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp5).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp5).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp6, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp5).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp8, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp5).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp5).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp5).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp5).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp5).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp5).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp6).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp6).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp5, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp6).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp6).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp6).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp6).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp7, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp6).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp6).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp7).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp7).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "object", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp7).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp7).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp7).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp7).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp7).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp7).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp8).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp8).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp5, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp8).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp8).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Nullable", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp8).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp8).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp9, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp8).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp8).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => PrimitiveType_NullableProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp9).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp9).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp9).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp9).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp9).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp9).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp9).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp9).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp10).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp10).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp11, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp10).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp10).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp10).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp10).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp10).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp10).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "String", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp10).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp10).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp11).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp11).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp11).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp12, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp11).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp14, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp11).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp11).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp11).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp11).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp11).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp11).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp12).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp12).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp11, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp12).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp12).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp12).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp12).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp13, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp12).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp12).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp13).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp13).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "string", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp13).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp13).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp13).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp13).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp13).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp13).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp14).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp14).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp11, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp14).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp14).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Nullable", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp14).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp14).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp15, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp14).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp14).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => PrimitiveType_NullableProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp15).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp15).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp15).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp15).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp15).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp15).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp15).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp15).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp16).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp16).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp17, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp16).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp16).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp16).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp16).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp16).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp16).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Int", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp16).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp16).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp17).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp17).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp17).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp18, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp17).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp17).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp17).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp17).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp17).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp17).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp18).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp18).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp17, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp18).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp18).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp18).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp18).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp19, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp18).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp18).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp19).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp19).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "int", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp19).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp19).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp19).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp19).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp19).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp19).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp20).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp20).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp21, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp20).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp20).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp20).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp20).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp20).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp20).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Long", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp20).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp20).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp21).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp21).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp21).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp22, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp21).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp21).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp21).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp21).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp21).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp21).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp22).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp22).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp21, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp22).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp22).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp22).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp22).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp23, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp22).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp22).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp23).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp23).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "long", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp23).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp23).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp23).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp23).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp23).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp23).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp24).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp24).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp25, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp24).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp24).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp24).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp24).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp24).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp24).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Float", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp24).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp24).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp25).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp25).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp25).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp26, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp25).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp25).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp25).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp25).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp25).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp25).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp26).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp26).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp25, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp26).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp26).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp26).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp26).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp27, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp26).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp26).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp27).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp27).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "float", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp27).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp27).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp27).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp27).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp27).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp27).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp28).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp28).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp29, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp28).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp28).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp28).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp28).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp28).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp28).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Double", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp28).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp28).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp29).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp29).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp29).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp30, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp29).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp29).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp29).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp29).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp29).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp29).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp30).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp30).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp29, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp30).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp30).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp30).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp30).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp31, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp30).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp30).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp31).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp31).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "double", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp31).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp31).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp31).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp31).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp31).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp31).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp32).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp32).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp33, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp32).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp32).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp32).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp32).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp32).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp32).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Byte", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp32).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp32).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp33).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp33).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp33).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp34, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp33).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp33).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp33).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp33).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp33).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp33).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp34).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp34).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp33, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp34).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp34).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp34).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp34).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp35, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp34).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp34).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp35).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp35).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "byte", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp35).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp35).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp35).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp35).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp35).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp35).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp36).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp36).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp37, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp36).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp36).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp36).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp36).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp36).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp36).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Bool", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp36).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp36).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp37).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp37).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp37).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp38, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp37).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp37).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp37).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp37).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp37).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp37).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp38).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp38).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp37, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp38).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp38).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp38).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp38).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp39, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp38).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp38).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp39).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp39).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "bool", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp39).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp39).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp39).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp39).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp39).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp39).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp40).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp40).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp41, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp40).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp40).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp40).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp40).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp40).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp40).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Void", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp40).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp40).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp41).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp41).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp41).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp42, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp41).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp41).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp41).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp41).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp41).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp41).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp42).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp42).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp41, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp42).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp42).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp42).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp42).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp43, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp42).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp42).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp43).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp43).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "void", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp43).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp43).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp43).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp43).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp43).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp43).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp44).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp44).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp45, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp44).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp44).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp44).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp44).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp44).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp44).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Date", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp44).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp44).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp45).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp45).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp45).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp46, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp45).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp45).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp45).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp45).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp45).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp45).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp46).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp46).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp45, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp46).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp46).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp46).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp46).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp47, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp46).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp46).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp47).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp47).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "Date", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp47).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp47).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp47).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp47).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp47).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp47).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp48).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp48).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp49, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp48).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp48).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp48).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp48).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp48).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp48).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Time", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp48).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp48).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp49).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp49).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp49).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp50, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp49).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp49).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp49).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp49).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp49).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp49).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp50).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp50).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp49, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp50).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp50).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp50).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp50).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp51, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp50).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp50).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp51).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp51).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "Time", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp51).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp51).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp51).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp51).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp51).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp51).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp52).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp52).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp53, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp52).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp52).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp52).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp52).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp52).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp52).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "DateTime", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp52).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp52).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp53).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp53).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp53).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp54, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp53).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp53).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp53).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp53).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp53).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp53).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp54).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp54).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp53, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp54).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp54).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp54).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp54).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp55, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp54).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp54).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp55).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp55).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "DateTime", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp55).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp55).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp55).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp55).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp55).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp55).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp56).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty);
				((ModelObject)__tmp56).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstant.ValueProperty, new Lazy<object>(() => __tmp57, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp56).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp56).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp56).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)__tmp56).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp56).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp56).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "TimeSpan", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp56).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp56).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp57).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty);
				((ModelObject)__tmp57).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.TypeReferenceProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp57).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewExpression.PropertyInitializersProperty, new Lazy<object>(() => __tmp58, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp57).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp57).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp57).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp57).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp57).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp57).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp58).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty);
				((ModelObject)__tmp58).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ParentProperty, new Lazy<object>(() => __tmp57, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp58).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp58).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp58).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty);
				((ModelObject)__tmp58).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp59, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp58).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp58).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNewPropertyInitializer.PropertyProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp59).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp59).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => "TimeSpan", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp59).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp59).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp59).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp59).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp59).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp59).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => AnnotatedElement_AnnotationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp61, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp64, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp67, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp71, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp74, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp78, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp82, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "AnnotatedElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)AnnotatedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp60).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp60).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp60).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp60).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement_AnnotationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)AnnotatedElement_AnnotationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement_AnnotationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)AnnotatedElement_AnnotationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement_AnnotationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => Annotation_AnnotatedElementProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement_AnnotationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)AnnotatedElement_AnnotationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Annotations", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement_AnnotationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)AnnotatedElement_AnnotationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotatedElement_AnnotationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)AnnotatedElement_AnnotationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp60, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp62, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp63, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp62, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "AddAnnotation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp61).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp61).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp62).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp62).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp62).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp63).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp63).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp61, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp63).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp63).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp63).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp63).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp63).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp63).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp65, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp66, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp65, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "HasAnnotation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp64).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp64).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp65).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp65).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp65).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp66).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp66).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp64, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp66).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp66).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp66).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp66).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp66).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp66).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp68, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp69, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp68, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "GetAnnotation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp67).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp67).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp68).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp68).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp68).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp69).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp69).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp67, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp69).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp69).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp69).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp69).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp69).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp69).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp70).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp70).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp70).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp70).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp72, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp73, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => __tmp70, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp72, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "GetAnnotations", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp71).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp71).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp72).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp72).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp72).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => __tmp70, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp73).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp73).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp71, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp73).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp73).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp73).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp73).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp73).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp73).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp75, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp76, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp77, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp75, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "HasAnnotationProperty", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp74).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp74).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp75).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp75).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp75).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp75).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp76).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp76).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp74, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp76).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp76).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "annotationName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp76).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp76).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp76).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp76).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp77).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp77).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp74, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp77).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp77).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "propertyName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp77).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp77).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp77).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp77).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp79, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp80, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp81, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp79, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "GetAnnotationPropertyValue", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp78).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp78).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp79).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp79).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp79).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp79).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp80).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp80).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp78, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp80).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp80).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "annotationName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp80).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp80).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp80).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp80).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp81).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp81).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp78, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp81).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp81).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "propertyName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp81).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp81).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp81).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp81).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp83, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp84, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp85, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp86, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp83, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "SetAnnotationPropertyValue", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp82).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp82).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp83).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp83).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp83).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp83).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp83).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp84).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp84).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp82, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp84).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp84).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "annotationName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp84).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp84).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp84).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp84).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp85).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp85).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp82, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp85).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp85).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "propertyName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp85).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp85).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp85).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp85).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp86).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp86).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp82, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp86).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp86).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "propertyValue", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp86).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp86).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp86).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp86).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Annotation_AnnotatedElementProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Annotation_PropertiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp88, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp91, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp94, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.OperationsProperty, new Lazy<object>(() => __tmp97, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Annotation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Annotation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_AnnotatedElementProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Annotation_AnnotatedElementProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_AnnotatedElementProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Annotation_AnnotatedElementProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_AnnotatedElementProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => AnnotatedElement_AnnotationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_AnnotatedElementProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Annotation_AnnotatedElementProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "AnnotatedElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_AnnotatedElementProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Annotation_AnnotatedElementProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_AnnotatedElementProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Annotation_AnnotatedElementProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp87).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp87).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp87).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp87).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Annotation_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Annotation_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Annotation_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Properties", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Annotation_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Annotation_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Annotation_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp87, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp89, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp90, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp89, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "HasProperty", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp88).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp88).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp89).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp89).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp89).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp90).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp90).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp88, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp90).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp90).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp90).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp90).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp90).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp90).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp92, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp93, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp92, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "GetProperty", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp91).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp91).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp92).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp92).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp92).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp93).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp93).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp91, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp93).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp93).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp93).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp93).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp93).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp93).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp95, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp96, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp95, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "GetPropertyValue", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp94).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp94).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp95).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp95).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp95).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp96).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp96).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp94, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp96).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp96).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp96).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp96).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp96).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp96).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty);
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaOperation.ParentProperty, new Lazy<object>(() => Annotation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty);
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.TypeProperty, new Lazy<object>(() => __tmp98, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp99, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ParametersProperty, new Lazy<object>(() => __tmp100, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty);
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunction.ReturnTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp98, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "SetPropertyValue", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp97).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp97).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp98).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp98).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ParameterTypesProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp98).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty);
				((ModelObject)__tmp98).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaFunctionType.ReturnTypeProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp99).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp99).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp97, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp99).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp99).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp99).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp99).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp99).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp99).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp100).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty);
				((ModelObject)__tmp100).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaParameter.FunctionProperty, new Lazy<object>(() => __tmp97, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp100).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp100).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "value", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp100).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp100).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp100).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp100).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => AnnotationProperty_ValueProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "AnnotationProperty", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)AnnotationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty_ValueProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)AnnotationProperty_ValueProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty_ValueProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)AnnotationProperty_ValueProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => AnnotationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty_ValueProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)AnnotationProperty_ValueProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Value", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty_ValueProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)AnnotationProperty_ValueProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)AnnotationProperty_ValueProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)AnnotationProperty_ValueProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Object	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)NamedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => NamedElement_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)NamedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)NamedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)NamedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "NamedElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)NamedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp101).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp101).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp101).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp101).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)NamedElement_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)NamedElement_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)NamedElement_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)NamedElement_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)NamedElement_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NamedElement_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp101, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)TypedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => TypedElement_TypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)TypedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)TypedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)TypedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "TypedElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)TypedElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp102).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp102).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Type", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp102).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp102).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement_TypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)TypedElement_TypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement_TypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)TypedElement_TypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => TypedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement_TypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)TypedElement_TypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Type", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement_TypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)TypedElement_TypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement_TypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)TypedElement_TypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TypedElement_TypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp102, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp103).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp103).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Type", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp103).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp103).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoalType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)SoalType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoalType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)SoalType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoalType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)SoalType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoalType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoalType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "SoalType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoalType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoalType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoalType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp103, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp104).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp104).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Scope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp104).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp104).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Namespace_UriProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Namespace_PrefixProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Namespace_FullNameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Namespace_DeclarationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Namespace", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp104, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_UriProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Namespace_UriProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_UriProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Namespace_UriProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Namespace, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_UriProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Namespace_UriProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Uri", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_UriProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Namespace_UriProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_UriProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Namespace_UriProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_PrefixProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Namespace_PrefixProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_PrefixProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Namespace_PrefixProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Namespace, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_PrefixProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Namespace_PrefixProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Prefix", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_PrefixProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Namespace_PrefixProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_PrefixProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Namespace_PrefixProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_FullNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Namespace_FullNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Derived, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_FullNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Namespace_FullNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Namespace, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_FullNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Namespace_FullNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "FullName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_FullNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Namespace_FullNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_FullNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Namespace_FullNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp105).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp105).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp105).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp105).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp106).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp106).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp106).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp106).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Namespace, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => Declaration_NamespaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Declarations", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp106, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Namespace_DeclarationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp105, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Declaration_NamespaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Declaration", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Declaration).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration_NamespaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Declaration_NamespaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration_NamespaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Declaration_NamespaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration_NamespaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => Namespace_DeclarationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration_NamespaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Declaration_NamespaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Namespace", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration_NamespaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Declaration_NamespaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Declaration_NamespaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Declaration_NamespaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Namespace, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => ArrayType_InnerTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ArrayType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)ArrayType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)ArrayType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)ArrayType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => ArrayType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)ArrayType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InnerType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)ArrayType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ArrayType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)ArrayType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => NullableType_InnerTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "NullableType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)NullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)NullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)NullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => NullableType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)NullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InnerType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)NullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)NullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => NonNullableType_InnerTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "NonNullableType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)NonNullableType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)NonNullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)NonNullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => NonNullableType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)NonNullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InnerType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)NonNullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)NonNullableType_InnerTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)NonNullableType_InnerTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => PrimitiveType_NullableProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => __tmp107, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "PrimitiveType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)PrimitiveType).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp107).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.ParentProperty);
				((ModelObject)__tmp107).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.ParentProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp107).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.InitializersProperty, new Lazy<object>(() => __tmp108, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp107).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp107).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "PrimitiveType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp107).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp107).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp108).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ConstructorProperty);
				((ModelObject)__tmp108).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ConstructorProperty, new Lazy<object>(() => __tmp107, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp108).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp108).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Nullable", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp108).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyContextProperty);
				((ModelObject)__tmp108).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyContextProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp108).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp108).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyProperty, new Lazy<object>(() => PrimitiveType_NullableProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp108).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ValueProperty);
				((ModelObject)__tmp108).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp109, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp109).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty);
				((ModelObject)__tmp109).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstantExpression.ValueProperty, new Lazy<object>(() => false, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp109).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp109).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp109).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp109).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp109).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp109).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType_NullableProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)PrimitiveType_NullableProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType_NullableProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)PrimitiveType_NullableProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => PrimitiveType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType_NullableProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)PrimitiveType_NullableProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Nullable", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType_NullableProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)PrimitiveType_NullableProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)PrimitiveType_NullableProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)PrimitiveType_NullableProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp110).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp110).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Scope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp110).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp110).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Enum_BaseTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Enum_EnumLiteralsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Enum", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp110, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp111).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp111).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InheritedScope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp111).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp111).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Enum_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Enum_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Enum, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Enum_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "BaseType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Enum_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Enum_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Enum, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp111, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp112).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp112).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp112).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp112).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp113).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp113).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp113).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp113).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => EnumLiteral, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Enum, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => EnumLiteral_EnumProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "EnumLiterals", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp113, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Enum_EnumLiteralsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp112, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TypedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => EnumLiteral_EnumProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => __tmp114, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "EnumLiteral", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)EnumLiteral).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp114).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.ParentProperty);
				((ModelObject)__tmp114).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.ParentProperty, new Lazy<object>(() => EnumLiteral, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp114).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.InitializersProperty, new Lazy<object>(() => __tmp115, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp114).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp114).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "EnumLiteral", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp114).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp114).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp115).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ConstructorProperty);
				((ModelObject)__tmp115).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ConstructorProperty, new Lazy<object>(() => __tmp114, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp115).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyNameProperty);
				((ModelObject)__tmp115).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyNameProperty, new Lazy<object>(() => "Type", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp115).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyContextProperty);
				((ModelObject)__tmp115).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyContextProperty, new Lazy<object>(() => EnumLiteral, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp115).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyProperty);
				((ModelObject)__tmp115).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.PropertyProperty, new Lazy<object>(() => TypedElement_TypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp115).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ValueProperty);
				((ModelObject)__tmp115).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaPropertyInitializer.ValueProperty, new Lazy<object>(() => __tmp116, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaIdentifierExpression.NameProperty);
				((ModelObject)__tmp116).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaIdentifierExpression.NameProperty, new Lazy<object>(() => "Enum", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaBoundExpression.UniqueDefinitionProperty);
				((ModelObject)__tmp116).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaBoundExpression.UniqueDefinitionProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaBoundExpression.DefinitionsProperty);
				// Invalid property value type: __tmp116.global::MetaDslx.Core.MetaDescriptor.MetaBoundExpression.DefinitionsProperty = MetaDslx.Core.BindingInfo
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaBoundExpression.DefinitionProperty);
				((ModelObject)__tmp116).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaBoundExpression.DefinitionProperty, new Lazy<object>(() => EnumLiteral_EnumProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty);
				((ModelObject)__tmp116).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.NoTypeErrorProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty);
				((ModelObject)__tmp116).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaExpression.ExpectedTypeProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp116).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp116).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Enum, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral_EnumProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)EnumLiteral_EnumProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral_EnumProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)EnumLiteral_EnumProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => EnumLiteral, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral_EnumProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => Enum_EnumLiteralsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral_EnumProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)EnumLiteral_EnumProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Enum", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral_EnumProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)EnumLiteral_EnumProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EnumLiteral_EnumProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)EnumLiteral_EnumProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Enum, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TypedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Property", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Property).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Property).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp117).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp117).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Scope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp117).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp117).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Struct_BaseTypeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Struct_PropertiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Struct", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp117, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp118).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp118).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InheritedScope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp118).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp118).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Struct_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Struct_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Struct, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Struct_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "BaseType", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Struct_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_BaseTypeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Struct_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Struct, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_BaseTypeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp118, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp119).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp119).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp119).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp119).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp120).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp120).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp120).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp120).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Property, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Struct_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Struct_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Struct, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Struct_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Properties", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Struct_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Struct_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp120, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Struct_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp119, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp121).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp121).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Scope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp121).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp121).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => SoalType, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Interface_OperationsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Interface", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp121, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp122).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp122).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp122).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp122).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp123).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp123).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp123).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp123).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Operation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface_OperationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Interface_OperationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface_OperationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Interface_OperationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Interface, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface_OperationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Interface_OperationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Operations", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface_OperationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Interface_OperationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface_OperationsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Interface_OperationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp123, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Interface_OperationsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp122, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Interface, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Database_EntitiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Database", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Database).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp124).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp124).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp124).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp124).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp125).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp125).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp125).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp125).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Struct, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database_EntitiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Database_EntitiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database_EntitiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Database_EntitiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Database, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database_EntitiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Database_EntitiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Entities", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database_EntitiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Database_EntitiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database_EntitiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Database_EntitiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp125, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Database_EntitiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp124, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Operation_ActionProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Operation_ParametersProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Operation_ResultProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Operation_ExceptionsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Operation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Operation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ActionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Operation_ActionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ActionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Operation_ActionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Operation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ActionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Operation_ActionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Action", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ActionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Operation_ActionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ActionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Operation_ActionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp126).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp126).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp126).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp126).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => InputParameter, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ParametersProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Operation_ParametersProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ParametersProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Operation_ParametersProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Operation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ParametersProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Operation_ParametersProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Parameters", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ParametersProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Operation_ParametersProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ParametersProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Operation_ParametersProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp126, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ResultProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Operation_ResultProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Readonly, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ResultProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Operation_ResultProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Operation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ResultProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Operation_ResultProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Result", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ResultProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Operation_ResultProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ResultProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Operation_ResultProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => OutputParameter, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp127).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp127).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp127).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp127).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Struct, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ExceptionsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Operation_ExceptionsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ExceptionsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Operation_ExceptionsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Operation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ExceptionsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Operation_ExceptionsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Exceptions", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ExceptionsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Operation_ExceptionsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Operation_ExceptionsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Operation_ExceptionsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp127, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TypedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InputParameter", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)InputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)InputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TypedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => AnnotatedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => OutputParameter_IsOnewayProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "OutputParameter", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)OutputParameter).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter_IsOnewayProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)OutputParameter_IsOnewayProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter_IsOnewayProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)OutputParameter_IsOnewayProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => OutputParameter, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter_IsOnewayProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)OutputParameter_IsOnewayProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "IsOneway", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter_IsOnewayProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)OutputParameter_IsOnewayProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)OutputParameter_IsOnewayProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)OutputParameter_IsOnewayProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp128).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp128).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Scope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp128).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp128).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_BaseComponentProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_IsAbstractProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_PortsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_ServicesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_ReferencesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_PropertiesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_ImplementationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Component_LanguageProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Component", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp128, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp129).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp129).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "InheritedScope", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp129).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp129).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_BaseComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_BaseComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_BaseComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_BaseComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_BaseComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_BaseComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "BaseComponent", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_BaseComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_BaseComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_BaseComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_BaseComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_BaseComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp129, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_IsAbstractProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_IsAbstractProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_IsAbstractProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_IsAbstractProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_IsAbstractProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_IsAbstractProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "IsAbstract", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_IsAbstractProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_IsAbstractProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_IsAbstractProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_IsAbstractProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp130).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp130).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp130).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp130).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp131).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp131).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp131).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp131).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => Port_ComponentProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.SubsettingPropertiesProperty, new Lazy<object>(() => Component_ServicesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.SubsettingPropertiesProperty, new Lazy<object>(() => Component_ReferencesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Ports", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp131, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PortsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp130, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp132).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp132).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp132).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp132).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Service, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ServicesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_ServicesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ServicesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_ServicesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ServicesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.SubsettedPropertiesProperty, new Lazy<object>(() => Component_PortsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ServicesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_ServicesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Services", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ServicesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_ServicesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ServicesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_ServicesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp132, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp133).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp133).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp133).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp133).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Reference, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ReferencesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_ReferencesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ReferencesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_ReferencesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ReferencesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.SubsettedPropertiesProperty, new Lazy<object>(() => Component_PortsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ReferencesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_ReferencesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "References", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ReferencesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_ReferencesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ReferencesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_ReferencesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp133, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp134).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp134).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp134).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp134).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp135).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp135).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp135).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp135).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Property, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Properties", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PropertiesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp135, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_PropertiesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp134, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ImplementationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_ImplementationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ImplementationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_ImplementationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ImplementationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_ImplementationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Implementation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ImplementationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_ImplementationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_ImplementationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_ImplementationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Implementation, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_LanguageProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Component_LanguageProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_LanguageProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Component_LanguageProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_LanguageProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Component_LanguageProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Language", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_LanguageProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Component_LanguageProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Component_LanguageProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Component_LanguageProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Language, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Composite_ComponentsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Composite_WiresProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Composite", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Composite).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp136).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp136).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ScopeEntry", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp136).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp136).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp137).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp137).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp137).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp137).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_ComponentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Composite_ComponentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_ComponentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Composite_ComponentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Composite, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_ComponentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Composite_ComponentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Components", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_ComponentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Composite_ComponentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_ComponentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Composite_ComponentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp137, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_ComponentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp136, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp138).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp138).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp138).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp138).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Wire, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Composite_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Composite_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Composite, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Composite_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Wires", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Composite_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Composite_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Composite_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp138, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Assembly).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Assembly).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Assembly).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Composite, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Assembly).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Assembly).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Assembly).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Assembly).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Assembly).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Assembly).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Assembly", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Assembly).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Assembly).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Wire_SourceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Wire_TargetProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Wire", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Wire).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_SourceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Wire_SourceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_SourceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Wire_SourceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Wire, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_SourceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Wire_SourceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Source", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_SourceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Wire_SourceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_SourceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Wire_SourceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_TargetProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Wire_TargetProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_TargetProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Wire_TargetProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Wire, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_TargetProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Wire_TargetProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Target", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_TargetProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Wire_TargetProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Wire_TargetProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Wire_TargetProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Port_ComponentProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Port_NameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Port_OptionalNameProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Port_InterfaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Port_BindingProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => __tmp139, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Port", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Port).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp139).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.ParentProperty);
				((ModelObject)__tmp139).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaConstructor.ParentProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp139).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp139).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Port", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp139).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp139).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_ComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Port_ComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_ComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Port_ComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_ComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.OppositePropertiesProperty, new Lazy<object>(() => Component_PortsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_ComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Port_ComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Component", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_ComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Port_ComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_ComponentProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Port_ComponentProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Component, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp140).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp140).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp140).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp140).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Port_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Derived, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Port_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Port_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Name", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Port_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_NameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Port_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_NameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaAnnotatedElement.AnnotationsProperty, new Lazy<object>(() => __tmp140, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_OptionalNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Port_OptionalNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_OptionalNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Port_OptionalNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_OptionalNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Port_OptionalNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "OptionalName", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_OptionalNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Port_OptionalNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_OptionalNameProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Port_OptionalNameProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Port_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Port_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Port_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Interface", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Port_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Port_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Interface, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Port_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Port_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Port_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Binding", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Port_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Port_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Port_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Binding, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Service).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Service).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Service).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Service).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Service).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Service).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Service).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Service).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Service).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Service", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Service).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Service).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Reference).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Reference).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Reference).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Port, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Reference).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Reference).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Reference).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Reference).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Reference).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Reference).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Reference", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Reference).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Reference).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Implementation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Implementation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Implementation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Implementation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Implementation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Implementation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Implementation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Implementation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Implementation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Implementation", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Implementation).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Implementation).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Language).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Language).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Language).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Language).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Language).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Language).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Language).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Language).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Language).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Language", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Language).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Language).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Deployment_EnvironmentsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Deployment_WiresProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Deployment", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Deployment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp141).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp141).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp141).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp141).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Environment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_EnvironmentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Deployment_EnvironmentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_EnvironmentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Deployment_EnvironmentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Deployment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_EnvironmentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Deployment_EnvironmentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Environments", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_EnvironmentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Deployment_EnvironmentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_EnvironmentsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Deployment_EnvironmentsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp141, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp142).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp142).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp142).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp142).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Wire, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Deployment_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Deployment_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Deployment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Deployment_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Wires", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Deployment_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Deployment_WiresProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Deployment_WiresProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp142, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Environment_RuntimeProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Environment_DatabasesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Environment_AssembliesProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Environment", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Environment).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_RuntimeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Environment_RuntimeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_RuntimeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Environment_RuntimeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Environment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_RuntimeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Environment_RuntimeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Runtime", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_RuntimeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Environment_RuntimeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_RuntimeProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Environment_RuntimeProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Runtime, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp143).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp143).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp143).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp143).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Database, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_DatabasesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Environment_DatabasesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_DatabasesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Environment_DatabasesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Environment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_DatabasesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Environment_DatabasesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Databases", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_DatabasesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Environment_DatabasesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_DatabasesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Environment_DatabasesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp143, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp144).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp144).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp144).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp144).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => Assembly, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_AssembliesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Environment_AssembliesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_AssembliesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Environment_AssembliesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Environment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_AssembliesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Environment_AssembliesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Assemblies", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_AssembliesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Environment_AssembliesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Environment_AssembliesProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Environment_AssembliesProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp144, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Runtime).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Runtime).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Runtime).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Runtime).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Runtime).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Runtime).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Runtime).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Runtime).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Runtime).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Runtime", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Runtime).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Runtime).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Binding_TransportProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Binding_EncodingsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Binding_ProtocolsProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Binding", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Binding).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_TransportProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Binding_TransportProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_TransportProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Binding_TransportProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Binding, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_TransportProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Binding_TransportProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Transport", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_TransportProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Binding_TransportProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_TransportProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Binding_TransportProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => TransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp145).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp145).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp145).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp145).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => EncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_EncodingsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Binding_EncodingsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_EncodingsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Binding_EncodingsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Binding, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_EncodingsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Binding_EncodingsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Encodings", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_EncodingsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Binding_EncodingsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_EncodingsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Binding_EncodingsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp145, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp146).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty);
				((ModelObject)__tmp146).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaCollectionKind.List, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp146).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty);
				((ModelObject)__tmp146).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaCollectionType.InnerTypeProperty, new Lazy<object>(() => ProtocolBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_ProtocolsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Binding_ProtocolsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => global::MetaDslx.Core.MetaPropertyKind.Containment, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_ProtocolsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Binding_ProtocolsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Binding, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_ProtocolsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Binding_ProtocolsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Protocols", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_ProtocolsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Binding_ProtocolsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Binding_ProtocolsProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Binding_ProtocolsProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => __tmp146, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => Declaration, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Endpoint_InterfaceProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Endpoint_BindingProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => Endpoint_AddressProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Endpoint", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Endpoint).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Endpoint_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Endpoint_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Endpoint, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Endpoint_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Interface", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Endpoint_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_InterfaceProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Endpoint_InterfaceProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Interface, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Endpoint_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Endpoint_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Endpoint, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Endpoint_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Binding", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Endpoint_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_BindingProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Endpoint_BindingProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => Binding, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_AddressProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)Endpoint_AddressProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_AddressProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)Endpoint_AddressProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => Endpoint, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_AddressProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)Endpoint_AddressProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Address", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_AddressProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)Endpoint_AddressProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)Endpoint_AddressProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)Endpoint_AddressProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.String	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)BindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)BindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)BindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => NamedElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)BindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)BindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)BindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)BindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)BindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)BindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "BindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)BindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)BindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)TransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => BindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)TransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)TransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)TransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "TransportBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)TransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)TransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)EncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => BindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)EncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)EncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)EncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "EncodingBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)EncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)EncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)ProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => BindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)ProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)ProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)ProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ProtocolBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)ProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)ProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => HttpTransportBindingElement_SslProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => HttpTransportBindingElement_ClientAuthenticationProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "HttpTransportBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)HttpTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_SslProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)HttpTransportBindingElement_SslProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_SslProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)HttpTransportBindingElement_SslProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => HttpTransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_SslProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)HttpTransportBindingElement_SslProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Ssl", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_SslProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)HttpTransportBindingElement_SslProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_SslProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)HttpTransportBindingElement_SslProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => HttpTransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "ClientAuthentication", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)HttpTransportBindingElement_ClientAuthenticationProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)RestTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)RestTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)RestTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)RestTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)RestTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)RestTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)RestTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)RestTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)RestTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "RestTransportBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)RestTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)RestTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WebSocketTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)WebSocketTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WebSocketTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => TransportBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WebSocketTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)WebSocketTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WebSocketTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)WebSocketTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WebSocketTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)WebSocketTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "WebSocketTransportBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WebSocketTransportBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)WebSocketTransportBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapVersion).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnum.EnumLiteralsProperty, new Lazy<object>(() => __tmp147, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapVersion).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnum.EnumLiteralsProperty, new Lazy<object>(() => __tmp148, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapVersion).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)SoapVersion).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapVersion).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoapVersion).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "SoapVersion", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapVersion).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoapVersion).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp147).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty);
				((ModelObject)__tmp147).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty, new Lazy<object>(() => SoapVersion, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp147).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp147).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Soap11", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp147).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp147).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp147).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp147).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapVersion, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp148).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty);
				((ModelObject)__tmp148).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty, new Lazy<object>(() => SoapVersion, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp148).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp148).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Soap12", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp148).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp148).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp148).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp148).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapVersion, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnum.EnumLiteralsProperty, new Lazy<object>(() => __tmp149, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnum.EnumLiteralsProperty, new Lazy<object>(() => __tmp150, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnum.EnumLiteralsProperty, new Lazy<object>(() => __tmp151, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnum.EnumLiteralsProperty, new Lazy<object>(() => __tmp152, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "SoapEncodingStyle", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingStyle).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoapEncodingStyle).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp149).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty);
				((ModelObject)__tmp149).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp149).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp149).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "DocumentWrapped", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp149).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp149).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp149).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp149).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp150).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty);
				((ModelObject)__tmp150).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp150).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp150).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "DocumentLiteral", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp150).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp150).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp150).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp150).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp151).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty);
				((ModelObject)__tmp151).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp151).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp151).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "RpcLiteral", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp151).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp151).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp151).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp151).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp152).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty);
				((ModelObject)__tmp152).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaEnumLiteral.EnumProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp152).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)__tmp152).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "RpcEncoded", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp152).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)__tmp152).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)__tmp152).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)__tmp152).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => EncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => SoapEncodingBindingElement_StyleProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => SoapEncodingBindingElement_VersionProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.PropertiesProperty, new Lazy<object>(() => SoapEncodingBindingElement_MtomProperty, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "SoapEncodingBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoapEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => SoapEncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Style", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)SoapEncodingBindingElement_StyleProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapEncodingStyle, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => SoapEncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Version", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)SoapEncodingBindingElement_VersionProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => SoapVersion, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty);
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.KindProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty);
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaProperty.ClassProperty, new Lazy<object>(() => SoapEncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "Mtom", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty);
				((ModelObject)SoapEncodingBindingElement_MtomProperty).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaTypedElement.TypeProperty, new Lazy<object>(() => 	MetaInstance.Bool	, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)XmlEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)XmlEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)XmlEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => EncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)XmlEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)XmlEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)XmlEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)XmlEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)XmlEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)XmlEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "XmlEncodingBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)XmlEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)XmlEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)JsonEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)JsonEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)JsonEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => EncodingBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)JsonEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)JsonEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)JsonEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)JsonEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)JsonEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)JsonEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "JsonEncodingBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)JsonEncodingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)JsonEncodingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)WsProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => true, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => ProtocolBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)WsProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)WsProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)WsProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "WsProtocolBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsProtocolBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)WsProtocolBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsAddressingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty);
				((ModelObject)WsAddressingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.IsAbstractProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsAddressingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.SuperClassesProperty, new Lazy<object>(() => WsProtocolBindingElement, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsAddressingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty);
				((ModelObject)WsAddressingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaClass.ConstructorProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsAddressingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty);
				((ModelObject)WsAddressingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDeclaration.NamespaceProperty, new Lazy<object>(() => __tmp2, LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsAddressingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty);
				((ModelObject)WsAddressingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaNamedElement.NameProperty, new Lazy<object>(() => "WsAddressingBindingElement", LazyThreadSafetyMode.ExecutionAndPublication));
				((ModelObject)WsAddressingBindingElement).MUnSet(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty);
				((ModelObject)WsAddressingBindingElement).MLazyAdd(global::MetaDslx.Core.MetaDescriptor.MetaDocumentedElement.DocumentationProperty, new Lazy<object>(() => null, LazyThreadSafetyMode.ExecutionAndPublication));
	
	            SoalInstance.model.EvalLazyValues();
			}
	    }
	}
    public enum SoapVersion
    {
        Soap11,
        Soap12,
    }
    
    public enum SoapEncodingStyle
    {
        DocumentWrapped,
        DocumentLiteral,
        RpcLiteral,
        RpcEncoded,
    }
    
    public interface AnnotatedElement
    {
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> Annotations { get; }
    
        global::MetaDslx.Soal.Annotation AddAnnotation(string name);
        bool HasAnnotation(string name);
        global::MetaDslx.Soal.Annotation GetAnnotation(string name);
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> GetAnnotations(string name);
        bool HasAnnotationProperty(string annotationName, string propertyName);
        object GetAnnotationPropertyValue(string annotationName, string propertyName);
        global::MetaDslx.Soal.AnnotationProperty SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue);
    }
    
    internal class AnnotatedElementImpl : ModelObject, global::MetaDslx.Soal.AnnotatedElement
    {
        static AnnotatedElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.AnnotatedElement; }
        }
    
        public AnnotatedElementImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement(this);
            this.MMakeDefault();
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Annotation : global::MetaDslx.Soal.NamedElement
    {
        global::MetaDslx.Soal.AnnotatedElement AnnotatedElement { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.AnnotationProperty> Properties { get; }
    
        bool HasProperty(string name);
        global::MetaDslx.Soal.AnnotationProperty GetProperty(string name);
        object GetPropertyValue(string name);
        global::MetaDslx.Soal.AnnotationProperty SetPropertyValue(string name, object value);
    }
    
    internal class AnnotationImpl : ModelObject, global::MetaDslx.Soal.Annotation
    {
        static AnnotationImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Annotation; }
        }
    
        public AnnotationImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Annotation.PropertiesProperty, new global::MetaDslx.Core.ModelList<AnnotationProperty>(this, global::MetaDslx.Soal.SoalDescriptor.Annotation.PropertiesProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Annotation(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.AnnotatedElement global::MetaDslx.Soal.Annotation.AnnotatedElement
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Annotation.AnnotatedElementProperty); 
                if (result != null) return (global::MetaDslx.Soal.AnnotatedElement)result;
                else return default(global::MetaDslx.Soal.AnnotatedElement);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Annotation.AnnotatedElementProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.AnnotationProperty> global::MetaDslx.Soal.Annotation.Properties
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Annotation.PropertiesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.AnnotationProperty>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.AnnotationProperty>);
            }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        bool global::MetaDslx.Soal.Annotation.HasProperty(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Annotation_HasProperty(this, name);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.Annotation.GetProperty(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Annotation_GetProperty(this, name);
        }
        
        object global::MetaDslx.Soal.Annotation.GetPropertyValue(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Annotation_GetPropertyValue(this, name);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.Annotation.SetPropertyValue(string name, object value)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Annotation_SetPropertyValue(this, name, value);
        }
    }
    
    public interface AnnotationProperty : global::MetaDslx.Soal.NamedElement
    {
        object Value { get; set; }
    
    }
    
    internal class AnnotationPropertyImpl : ModelObject, global::MetaDslx.Soal.AnnotationProperty
    {
        static AnnotationPropertyImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.AnnotationProperty; }
        }
    
        public AnnotationPropertyImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotationProperty(this);
            this.MMakeDefault();
        }
        
        object global::MetaDslx.Soal.AnnotationProperty.Value
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotationProperty.ValueProperty); 
                if (result != null) return (object)result;
                else return default(object);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotationProperty.ValueProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface NamedElement
    {
        string Name { get; set; }
    
    }
    
    internal class NamedElementImpl : ModelObject, global::MetaDslx.Soal.NamedElement
    {
        static NamedElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.NamedElement; }
        }
    
        public NamedElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.NamedElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface TypedElement
    {
        global::MetaDslx.Soal.SoalType Type { get; set; }
    
    }
    
    internal class TypedElementImpl : ModelObject, global::MetaDslx.Soal.TypedElement
    {
        static TypedElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.TypedElement; }
        }
    
        public TypedElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.TypedElement(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.TypedElement.Type
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty, value); }
        }
    }
    
    [Type]
    public interface SoalType
    {
    
    }
    
    internal class SoalTypeImpl : ModelObject, global::MetaDslx.Soal.SoalType
    {
        static SoalTypeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.SoalType; }
        }
    
        public SoalTypeImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.SoalType(this);
            this.MMakeDefault();
        }
    }
    
    [Scope]
    public interface Namespace : global::MetaDslx.Soal.Declaration
    {
        string Uri { get; set; }
        string Prefix { get; set; }
        string FullName { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Declaration> Declarations { get; }
    
    }
    
    internal class NamespaceImpl : ModelObject, global::MetaDslx.Soal.Namespace
    {
        static NamespaceImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Namespace; }
        }
    
        public NamespaceImpl() 
        {
            this.MDerivedSet(global::MetaDslx.Soal.SoalDescriptor.Namespace.FullNameProperty, () => global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Namespace_FullName(this));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Namespace.DeclarationsProperty, new global::MetaDslx.Core.ModelList<Declaration>(this, global::MetaDslx.Soal.SoalDescriptor.Namespace.DeclarationsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Namespace(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.Namespace.Uri
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Namespace.UriProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Namespace.UriProperty, value); }
        }
        
        string global::MetaDslx.Soal.Namespace.Prefix
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Namespace.PrefixProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Namespace.PrefixProperty, value); }
        }
        
        string global::MetaDslx.Soal.Namespace.FullName
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Namespace.FullNameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Declaration> global::MetaDslx.Soal.Namespace.Declarations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Namespace.DeclarationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Declaration>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Declaration>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Declaration : global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
    {
        global::MetaDslx.Soal.Namespace Namespace { get; set; }
    
    }
    
    internal class DeclarationImpl : ModelObject, global::MetaDslx.Soal.Declaration
    {
        static DeclarationImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Declaration; }
        }
    
        public DeclarationImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Declaration(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface ArrayType : global::MetaDslx.Soal.SoalType
    {
        global::MetaDslx.Soal.SoalType InnerType { get; set; }
    
    }
    
    internal class ArrayTypeImpl : ModelObject, global::MetaDslx.Soal.ArrayType
    {
        static ArrayTypeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.ArrayType; }
        }
    
        public ArrayTypeImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.ArrayType(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.ArrayType.InnerType
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.ArrayType.InnerTypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.ArrayType.InnerTypeProperty, value); }
        }
    }
    
    public interface NullableType : global::MetaDslx.Soal.SoalType
    {
        global::MetaDslx.Soal.SoalType InnerType { get; set; }
    
    }
    
    internal class NullableTypeImpl : ModelObject, global::MetaDslx.Soal.NullableType
    {
        static NullableTypeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.NullableType; }
        }
    
        public NullableTypeImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.NullableType(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.NullableType.InnerType
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NullableType.InnerTypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NullableType.InnerTypeProperty, value); }
        }
    }
    
    public interface NonNullableType : global::MetaDslx.Soal.SoalType
    {
        global::MetaDslx.Soal.SoalType InnerType { get; set; }
    
    }
    
    internal class NonNullableTypeImpl : ModelObject, global::MetaDslx.Soal.NonNullableType
    {
        static NonNullableTypeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.NonNullableType; }
        }
    
        public NonNullableTypeImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.NonNullableType(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.NonNullableType.InnerType
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NonNullableType.InnerTypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NonNullableType.InnerTypeProperty, value); }
        }
    }
    
    public interface PrimitiveType : global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    {
        bool Nullable { get; set; }
    
    }
    
    internal class PrimitiveTypeImpl : ModelObject, global::MetaDslx.Soal.PrimitiveType
    {
        static PrimitiveTypeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.PrimitiveType; }
        }
    
        public PrimitiveTypeImpl() 
        {
            this.MLazySet(global::MetaDslx.Soal.SoalDescriptor.PrimitiveType.NullableProperty, new Lazy<object>(() => false, LazyThreadSafetyMode.ExecutionAndPublication));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.PrimitiveType(this);
            this.MMakeDefault();
        }
        
        bool global::MetaDslx.Soal.PrimitiveType.Nullable
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.PrimitiveType.NullableProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.PrimitiveType.NullableProperty, value); }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    [Scope]
    public interface Enum : global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    {
        global::MetaDslx.Soal.Enum BaseType { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.EnumLiteral> EnumLiterals { get; }
    
    }
    
    internal class EnumImpl : ModelObject, global::MetaDslx.Soal.Enum
    {
        static EnumImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Enum; }
        }
    
        public EnumImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Enum.EnumLiteralsProperty, new global::MetaDslx.Core.ModelList<EnumLiteral>(this, global::MetaDslx.Soal.SoalDescriptor.Enum.EnumLiteralsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Enum(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Enum global::MetaDslx.Soal.Enum.BaseType
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Enum.BaseTypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.Enum)result;
                else return default(global::MetaDslx.Soal.Enum);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Enum.BaseTypeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.EnumLiteral> global::MetaDslx.Soal.Enum.EnumLiterals
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Enum.EnumLiteralsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.EnumLiteral>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.EnumLiteral>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface EnumLiteral : global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    {
        global::MetaDslx.Soal.Enum Enum { get; set; }
    
    }
    
    internal class EnumLiteralImpl : ModelObject, global::MetaDslx.Soal.EnumLiteral
    {
        static EnumLiteralImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.EnumLiteral; }
        }
    
        public EnumLiteralImpl() 
        {
            this.MLazySet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty, new Lazy<object>(() => ((EnumLiteral)this).Enum, LazyThreadSafetyMode.ExecutionAndPublication));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.EnumLiteral(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Enum global::MetaDslx.Soal.EnumLiteral.Enum
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.EnumLiteral.EnumProperty); 
                if (result != null) return (global::MetaDslx.Soal.Enum)result;
                else return default(global::MetaDslx.Soal.Enum);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.EnumLiteral.EnumProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.TypedElement.Type
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Property : global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    {
    
    }
    
    internal class PropertyImpl : ModelObject, global::MetaDslx.Soal.Property
    {
        static PropertyImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Property; }
        }
    
        public PropertyImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Property(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.TypedElement.Type
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    [Scope]
    public interface Struct : global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    {
        global::MetaDslx.Soal.Struct BaseType { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property> Properties { get; }
    
    }
    
    internal class StructImpl : ModelObject, global::MetaDslx.Soal.Struct
    {
        static StructImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Struct; }
        }
    
        public StructImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Struct.PropertiesProperty, new global::MetaDslx.Core.ModelList<Property>(this, global::MetaDslx.Soal.SoalDescriptor.Struct.PropertiesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Struct(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Struct global::MetaDslx.Soal.Struct.BaseType
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Struct.BaseTypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.Struct)result;
                else return default(global::MetaDslx.Soal.Struct);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Struct.BaseTypeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property> global::MetaDslx.Soal.Struct.Properties
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Struct.PropertiesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    [Scope]
    public interface Interface : global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    {
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation> Operations { get; }
    
    }
    
    internal class InterfaceImpl : ModelObject, global::MetaDslx.Soal.Interface
    {
        static InterfaceImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Interface; }
        }
    
        public InterfaceImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Interface.OperationsProperty, new global::MetaDslx.Core.ModelList<Operation>(this, global::MetaDslx.Soal.SoalDescriptor.Interface.OperationsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Interface(this);
            this.MMakeDefault();
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation> global::MetaDslx.Soal.Interface.Operations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Interface.OperationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Database : global::MetaDslx.Soal.Interface
    {
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct> Entities { get; }
    
    }
    
    internal class DatabaseImpl : ModelObject, global::MetaDslx.Soal.Database
    {
        static DatabaseImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Database; }
        }
    
        public DatabaseImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Database.EntitiesProperty, new global::MetaDslx.Core.ModelList<Struct>(this, global::MetaDslx.Soal.SoalDescriptor.Database.EntitiesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Interface.OperationsProperty, new global::MetaDslx.Core.ModelList<Operation>(this, global::MetaDslx.Soal.SoalDescriptor.Interface.OperationsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Database(this);
            this.MMakeDefault();
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct> global::MetaDslx.Soal.Database.Entities
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Database.EntitiesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation> global::MetaDslx.Soal.Interface.Operations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Interface.OperationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Operation>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Operation : global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
    {
        string Action { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.InputParameter> Parameters { get; }
        global::MetaDslx.Soal.OutputParameter Result { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct> Exceptions { get; }
    
    }
    
    internal class OperationImpl : ModelObject, global::MetaDslx.Soal.Operation
    {
        static OperationImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Operation; }
        }
    
        public OperationImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Operation.ParametersProperty, new global::MetaDslx.Core.ModelList<InputParameter>(this, global::MetaDslx.Soal.SoalDescriptor.Operation.ParametersProperty));
            // Init global::MetaDslx.Soal.SoalDescriptor.Operation.ResultProperty in global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Operation_Operation
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Operation.ExceptionsProperty, new global::MetaDslx.Core.ModelList<Struct>(this, global::MetaDslx.Soal.SoalDescriptor.Operation.ExceptionsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Operation(this);
            if (!this.MIsSet(global::MetaDslx.Soal.SoalDescriptor.Operation.ResultProperty)) throw new ModelException("Readonly property Soal.Operation.ResultProperty was not set in Operation_Operation().");
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.Operation.Action
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Operation.ActionProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Operation.ActionProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.InputParameter> global::MetaDslx.Soal.Operation.Parameters
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Operation.ParametersProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.InputParameter>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.InputParameter>);
            }
        }
        
        global::MetaDslx.Soal.OutputParameter global::MetaDslx.Soal.Operation.Result
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Operation.ResultProperty); 
                if (result != null) return (global::MetaDslx.Soal.OutputParameter)result;
                else return default(global::MetaDslx.Soal.OutputParameter);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct> global::MetaDslx.Soal.Operation.Exceptions
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Operation.ExceptionsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Struct>);
            }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface InputParameter : global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    {
    
    }
    
    internal class InputParameterImpl : ModelObject, global::MetaDslx.Soal.InputParameter
    {
        static InputParameterImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.InputParameter; }
        }
    
        public InputParameterImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.InputParameter(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.TypedElement.Type
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface OutputParameter : global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    {
        bool IsOneway { get; set; }
    
    }
    
    internal class OutputParameterImpl : ModelObject, global::MetaDslx.Soal.OutputParameter
    {
        static OutputParameterImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.OutputParameter; }
        }
    
        public OutputParameterImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.OutputParameter(this);
            this.MMakeDefault();
        }
        
        bool global::MetaDslx.Soal.OutputParameter.IsOneway
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.OutputParameter.IsOnewayProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.OutputParameter.IsOnewayProperty, value); }
        }
        
        global::MetaDslx.Soal.SoalType global::MetaDslx.Soal.TypedElement.Type
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoalType)result;
                else return default(global::MetaDslx.Soal.SoalType);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.TypedElement.TypeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    [Scope]
    public interface Component : global::MetaDslx.Soal.Declaration
    {
        global::MetaDslx.Soal.Component BaseComponent { get; set; }
        bool IsAbstract { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port> Ports { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service> Services { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference> References { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property> Properties { get; }
        global::MetaDslx.Soal.Implementation Implementation { get; set; }
        global::MetaDslx.Soal.Language Language { get; set; }
    
    }
    
    internal class ComponentImpl : ModelObject, global::MetaDslx.Soal.Component
    {
        static ComponentImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Component; }
        }
    
        public ComponentImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty, new global::MetaDslx.Core.ModelList<Port>(this, global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty, new global::MetaDslx.Core.ModelList<Service>(this, global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty, new global::MetaDslx.Core.ModelList<Reference>(this, global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty, new global::MetaDslx.Core.ModelList<Property>(this, global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Component(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Component global::MetaDslx.Soal.Component.BaseComponent
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.BaseComponentProperty); 
                if (result != null) return (global::MetaDslx.Soal.Component)result;
                else return default(global::MetaDslx.Soal.Component);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.BaseComponentProperty, value); }
        }
        
        bool global::MetaDslx.Soal.Component.IsAbstract
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.IsAbstractProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.IsAbstractProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port> global::MetaDslx.Soal.Component.Ports
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service> global::MetaDslx.Soal.Component.Services
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference> global::MetaDslx.Soal.Component.References
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property> global::MetaDslx.Soal.Component.Properties
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>);
            }
        }
        
        global::MetaDslx.Soal.Implementation global::MetaDslx.Soal.Component.Implementation
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ImplementationProperty); 
                if (result != null) return (global::MetaDslx.Soal.Implementation)result;
                else return default(global::MetaDslx.Soal.Implementation);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ImplementationProperty, value); }
        }
        
        global::MetaDslx.Soal.Language global::MetaDslx.Soal.Component.Language
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.LanguageProperty); 
                if (result != null) return (global::MetaDslx.Soal.Language)result;
                else return default(global::MetaDslx.Soal.Language);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.LanguageProperty, value); }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Composite : global::MetaDslx.Soal.Component
    {
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component> Components { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire> Wires { get; }
    
    }
    
    internal class CompositeImpl : ModelObject, global::MetaDslx.Soal.Composite
    {
        static CompositeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Composite; }
        }
    
        public CompositeImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Composite.ComponentsProperty, new global::MetaDslx.Core.ModelList<Component>(this, global::MetaDslx.Soal.SoalDescriptor.Composite.ComponentsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Composite.WiresProperty, new global::MetaDslx.Core.ModelList<Wire>(this, global::MetaDslx.Soal.SoalDescriptor.Composite.WiresProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty, new global::MetaDslx.Core.ModelList<Port>(this, global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty, new global::MetaDslx.Core.ModelList<Service>(this, global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty, new global::MetaDslx.Core.ModelList<Reference>(this, global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty, new global::MetaDslx.Core.ModelList<Property>(this, global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Composite(this);
            this.MMakeDefault();
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component> global::MetaDslx.Soal.Composite.Components
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Composite.ComponentsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire> global::MetaDslx.Soal.Composite.Wires
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Composite.WiresProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>);
            }
        }
        
        global::MetaDslx.Soal.Component global::MetaDslx.Soal.Component.BaseComponent
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.BaseComponentProperty); 
                if (result != null) return (global::MetaDslx.Soal.Component)result;
                else return default(global::MetaDslx.Soal.Component);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.BaseComponentProperty, value); }
        }
        
        bool global::MetaDslx.Soal.Component.IsAbstract
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.IsAbstractProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.IsAbstractProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port> global::MetaDslx.Soal.Component.Ports
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service> global::MetaDslx.Soal.Component.Services
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference> global::MetaDslx.Soal.Component.References
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property> global::MetaDslx.Soal.Component.Properties
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>);
            }
        }
        
        global::MetaDslx.Soal.Implementation global::MetaDslx.Soal.Component.Implementation
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ImplementationProperty); 
                if (result != null) return (global::MetaDslx.Soal.Implementation)result;
                else return default(global::MetaDslx.Soal.Implementation);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ImplementationProperty, value); }
        }
        
        global::MetaDslx.Soal.Language global::MetaDslx.Soal.Component.Language
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.LanguageProperty); 
                if (result != null) return (global::MetaDslx.Soal.Language)result;
                else return default(global::MetaDslx.Soal.Language);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.LanguageProperty, value); }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Assembly : global::MetaDslx.Soal.Composite
    {
    
    }
    
    internal class AssemblyImpl : ModelObject, global::MetaDslx.Soal.Assembly
    {
        static AssemblyImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Assembly; }
        }
    
        public AssemblyImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Composite.ComponentsProperty, new global::MetaDslx.Core.ModelList<Component>(this, global::MetaDslx.Soal.SoalDescriptor.Composite.ComponentsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Composite.WiresProperty, new global::MetaDslx.Core.ModelList<Wire>(this, global::MetaDslx.Soal.SoalDescriptor.Composite.WiresProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty, new global::MetaDslx.Core.ModelList<Port>(this, global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty, new global::MetaDslx.Core.ModelList<Service>(this, global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty, new global::MetaDslx.Core.ModelList<Reference>(this, global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty, new global::MetaDslx.Core.ModelList<Property>(this, global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Assembly(this);
            this.MMakeDefault();
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component> global::MetaDslx.Soal.Composite.Components
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Composite.ComponentsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Component>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire> global::MetaDslx.Soal.Composite.Wires
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Composite.WiresProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>);
            }
        }
        
        global::MetaDslx.Soal.Component global::MetaDslx.Soal.Component.BaseComponent
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.BaseComponentProperty); 
                if (result != null) return (global::MetaDslx.Soal.Component)result;
                else return default(global::MetaDslx.Soal.Component);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.BaseComponentProperty, value); }
        }
        
        bool global::MetaDslx.Soal.Component.IsAbstract
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.IsAbstractProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.IsAbstractProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port> global::MetaDslx.Soal.Component.Ports
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.PortsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Port>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service> global::MetaDslx.Soal.Component.Services
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ServicesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Service>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference> global::MetaDslx.Soal.Component.References
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ReferencesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Reference>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property> global::MetaDslx.Soal.Component.Properties
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.PropertiesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Property>);
            }
        }
        
        global::MetaDslx.Soal.Implementation global::MetaDslx.Soal.Component.Implementation
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.ImplementationProperty); 
                if (result != null) return (global::MetaDslx.Soal.Implementation)result;
                else return default(global::MetaDslx.Soal.Implementation);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.ImplementationProperty, value); }
        }
        
        global::MetaDslx.Soal.Language global::MetaDslx.Soal.Component.Language
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Component.LanguageProperty); 
                if (result != null) return (global::MetaDslx.Soal.Language)result;
                else return default(global::MetaDslx.Soal.Language);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Component.LanguageProperty, value); }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Wire
    {
        global::MetaDslx.Soal.Port Source { get; set; }
        global::MetaDslx.Soal.Port Target { get; set; }
    
    }
    
    internal class WireImpl : ModelObject, global::MetaDslx.Soal.Wire
    {
        static WireImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Wire; }
        }
    
        public WireImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Wire(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Port global::MetaDslx.Soal.Wire.Source
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Wire.SourceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Port)result;
                else return default(global::MetaDslx.Soal.Port);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Wire.SourceProperty, value); }
        }
        
        global::MetaDslx.Soal.Port global::MetaDslx.Soal.Wire.Target
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Wire.TargetProperty); 
                if (result != null) return (global::MetaDslx.Soal.Port)result;
                else return default(global::MetaDslx.Soal.Port);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Wire.TargetProperty, value); }
        }
    }
    
    public interface Port
    {
        global::MetaDslx.Soal.Component Component { get; set; }
        string Name { get; }
        string OptionalName { get; set; }
        global::MetaDslx.Soal.Interface Interface { get; set; }
        global::MetaDslx.Soal.Binding Binding { get; set; }
    
    }
    
    internal class PortImpl : ModelObject, global::MetaDslx.Soal.Port
    {
        static PortImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Port; }
        }
    
        public PortImpl() 
        {
            this.MDerivedSet(global::MetaDslx.Soal.SoalDescriptor.Port.NameProperty, () => global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Port_Name(this));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Port(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Component global::MetaDslx.Soal.Port.Component
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.ComponentProperty); 
                if (result != null) return (global::MetaDslx.Soal.Component)result;
                else return default(global::MetaDslx.Soal.Component);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.ComponentProperty, value); }
        }
        
        string global::MetaDslx.Soal.Port.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
        }
        
        string global::MetaDslx.Soal.Port.OptionalName
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.OptionalNameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.OptionalNameProperty, value); }
        }
        
        global::MetaDslx.Soal.Interface global::MetaDslx.Soal.Port.Interface
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.InterfaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Interface)result;
                else return default(global::MetaDslx.Soal.Interface);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.InterfaceProperty, value); }
        }
        
        global::MetaDslx.Soal.Binding global::MetaDslx.Soal.Port.Binding
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.BindingProperty); 
                if (result != null) return (global::MetaDslx.Soal.Binding)result;
                else return default(global::MetaDslx.Soal.Binding);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.BindingProperty, value); }
        }
    }
    
    public interface Service : global::MetaDslx.Soal.Port
    {
    
    }
    
    internal class ServiceImpl : ModelObject, global::MetaDslx.Soal.Service
    {
        static ServiceImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Service; }
        }
    
        public ServiceImpl() 
        {
            this.MDerivedSet(global::MetaDslx.Soal.SoalDescriptor.Port.NameProperty, () => global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Port_Name(this));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Service(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Component global::MetaDslx.Soal.Port.Component
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.ComponentProperty); 
                if (result != null) return (global::MetaDslx.Soal.Component)result;
                else return default(global::MetaDslx.Soal.Component);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.ComponentProperty, value); }
        }
        
        string global::MetaDslx.Soal.Port.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
        }
        
        string global::MetaDslx.Soal.Port.OptionalName
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.OptionalNameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.OptionalNameProperty, value); }
        }
        
        global::MetaDslx.Soal.Interface global::MetaDslx.Soal.Port.Interface
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.InterfaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Interface)result;
                else return default(global::MetaDslx.Soal.Interface);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.InterfaceProperty, value); }
        }
        
        global::MetaDslx.Soal.Binding global::MetaDslx.Soal.Port.Binding
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.BindingProperty); 
                if (result != null) return (global::MetaDslx.Soal.Binding)result;
                else return default(global::MetaDslx.Soal.Binding);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.BindingProperty, value); }
        }
    }
    
    public interface Reference : global::MetaDslx.Soal.Port
    {
    
    }
    
    internal class ReferenceImpl : ModelObject, global::MetaDslx.Soal.Reference
    {
        static ReferenceImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Reference; }
        }
    
        public ReferenceImpl() 
        {
            this.MDerivedSet(global::MetaDslx.Soal.SoalDescriptor.Port.NameProperty, () => global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Port_Name(this));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Reference(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Component global::MetaDslx.Soal.Port.Component
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.ComponentProperty); 
                if (result != null) return (global::MetaDslx.Soal.Component)result;
                else return default(global::MetaDslx.Soal.Component);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.ComponentProperty, value); }
        }
        
        string global::MetaDslx.Soal.Port.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
        }
        
        string global::MetaDslx.Soal.Port.OptionalName
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.OptionalNameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.OptionalNameProperty, value); }
        }
        
        global::MetaDslx.Soal.Interface global::MetaDslx.Soal.Port.Interface
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.InterfaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Interface)result;
                else return default(global::MetaDslx.Soal.Interface);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.InterfaceProperty, value); }
        }
        
        global::MetaDslx.Soal.Binding global::MetaDslx.Soal.Port.Binding
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Port.BindingProperty); 
                if (result != null) return (global::MetaDslx.Soal.Binding)result;
                else return default(global::MetaDslx.Soal.Binding);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Port.BindingProperty, value); }
        }
    }
    
    public interface Implementation : global::MetaDslx.Soal.NamedElement
    {
    
    }
    
    internal class ImplementationImpl : ModelObject, global::MetaDslx.Soal.Implementation
    {
        static ImplementationImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Implementation; }
        }
    
        public ImplementationImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Implementation(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface Language : global::MetaDslx.Soal.NamedElement
    {
    
    }
    
    internal class LanguageImpl : ModelObject, global::MetaDslx.Soal.Language
    {
        static LanguageImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Language; }
        }
    
        public LanguageImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Language(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface Deployment : global::MetaDslx.Soal.Declaration
    {
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Environment> Environments { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire> Wires { get; }
    
    }
    
    internal class DeploymentImpl : ModelObject, global::MetaDslx.Soal.Deployment
    {
        static DeploymentImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Deployment; }
        }
    
        public DeploymentImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Deployment.EnvironmentsProperty, new global::MetaDslx.Core.ModelList<Environment>(this, global::MetaDslx.Soal.SoalDescriptor.Deployment.EnvironmentsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Deployment.WiresProperty, new global::MetaDslx.Core.ModelList<Wire>(this, global::MetaDslx.Soal.SoalDescriptor.Deployment.WiresProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Deployment(this);
            this.MMakeDefault();
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Environment> global::MetaDslx.Soal.Deployment.Environments
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Deployment.EnvironmentsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Environment>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Environment>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire> global::MetaDslx.Soal.Deployment.Wires
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Deployment.WiresProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Wire>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Environment : global::MetaDslx.Soal.NamedElement
    {
        global::MetaDslx.Soal.Runtime Runtime { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Database> Databases { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Assembly> Assemblies { get; }
    
    }
    
    internal class EnvironmentImpl : ModelObject, global::MetaDslx.Soal.Environment
    {
        static EnvironmentImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Environment; }
        }
    
        public EnvironmentImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Environment.DatabasesProperty, new global::MetaDslx.Core.ModelList<Database>(this, global::MetaDslx.Soal.SoalDescriptor.Environment.DatabasesProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Environment.AssembliesProperty, new global::MetaDslx.Core.ModelList<Assembly>(this, global::MetaDslx.Soal.SoalDescriptor.Environment.AssembliesProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Environment(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Runtime global::MetaDslx.Soal.Environment.Runtime
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Environment.RuntimeProperty); 
                if (result != null) return (global::MetaDslx.Soal.Runtime)result;
                else return default(global::MetaDslx.Soal.Runtime);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Environment.RuntimeProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Database> global::MetaDslx.Soal.Environment.Databases
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Environment.DatabasesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Database>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Database>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Assembly> global::MetaDslx.Soal.Environment.Assemblies
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Environment.AssembliesProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Assembly>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Assembly>);
            }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface Runtime : global::MetaDslx.Soal.NamedElement
    {
    
    }
    
    internal class RuntimeImpl : ModelObject, global::MetaDslx.Soal.Runtime
    {
        static RuntimeImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Runtime; }
        }
    
        public RuntimeImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Runtime(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface Binding : global::MetaDslx.Soal.Declaration
    {
        global::MetaDslx.Soal.TransportBindingElement Transport { get; set; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.EncodingBindingElement> Encodings { get; }
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.ProtocolBindingElement> Protocols { get; }
    
    }
    
    internal class BindingImpl : ModelObject, global::MetaDslx.Soal.Binding
    {
        static BindingImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Binding; }
        }
    
        public BindingImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Binding.EncodingsProperty, new global::MetaDslx.Core.ModelList<EncodingBindingElement>(this, global::MetaDslx.Soal.SoalDescriptor.Binding.EncodingsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.Binding.ProtocolsProperty, new global::MetaDslx.Core.ModelList<ProtocolBindingElement>(this, global::MetaDslx.Soal.SoalDescriptor.Binding.ProtocolsProperty));
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Binding(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.TransportBindingElement global::MetaDslx.Soal.Binding.Transport
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Binding.TransportProperty); 
                if (result != null) return (global::MetaDslx.Soal.TransportBindingElement)result;
                else return default(global::MetaDslx.Soal.TransportBindingElement);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Binding.TransportProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.EncodingBindingElement> global::MetaDslx.Soal.Binding.Encodings
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Binding.EncodingsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.EncodingBindingElement>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.EncodingBindingElement>);
            }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.ProtocolBindingElement> global::MetaDslx.Soal.Binding.Protocols
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Binding.ProtocolsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.ProtocolBindingElement>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.ProtocolBindingElement>);
            }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface Endpoint : global::MetaDslx.Soal.Declaration
    {
        global::MetaDslx.Soal.Interface Interface { get; set; }
        global::MetaDslx.Soal.Binding Binding { get; set; }
        string Address { get; set; }
    
    }
    
    internal class EndpointImpl : ModelObject, global::MetaDslx.Soal.Endpoint
    {
        static EndpointImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.Endpoint; }
        }
    
        public EndpointImpl() 
        {
            this.MSet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty, new global::MetaDslx.Core.ModelList<Annotation>(this, global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty));
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.Endpoint(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.Interface global::MetaDslx.Soal.Endpoint.Interface
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Endpoint.InterfaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Interface)result;
                else return default(global::MetaDslx.Soal.Interface);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Endpoint.InterfaceProperty, value); }
        }
        
        global::MetaDslx.Soal.Binding global::MetaDslx.Soal.Endpoint.Binding
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Endpoint.BindingProperty); 
                if (result != null) return (global::MetaDslx.Soal.Binding)result;
                else return default(global::MetaDslx.Soal.Binding);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Endpoint.BindingProperty, value); }
        }
        
        string global::MetaDslx.Soal.Endpoint.Address
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Endpoint.AddressProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Endpoint.AddressProperty, value); }
        }
        
        global::MetaDslx.Soal.Namespace global::MetaDslx.Soal.Declaration.Namespace
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty); 
                if (result != null) return (global::MetaDslx.Soal.Namespace)result;
                else return default(global::MetaDslx.Soal.Namespace);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.Declaration.NamespaceProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.Annotations
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.AnnotatedElement.AnnotationsProperty); 
                if (result != null) return (global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>)result;
                else return default(global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation>);
            }
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.AddAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_AddAnnotation(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotation(this, name);
        }
        
        global::MetaDslx.Soal.Annotation global::MetaDslx.Soal.AnnotatedElement.GetAnnotation(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotation(this, name);
        }
        
        global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> global::MetaDslx.Soal.AnnotatedElement.GetAnnotations(string name)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotations(this, name);
        }
        
        bool global::MetaDslx.Soal.AnnotatedElement.HasAnnotationProperty(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_HasAnnotationProperty(this, annotationName, propertyName);
        }
        
        object global::MetaDslx.Soal.AnnotatedElement.GetAnnotationPropertyValue(string annotationName, string propertyName)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_GetAnnotationPropertyValue(this, annotationName, propertyName);
        }
        
        global::MetaDslx.Soal.AnnotationProperty global::MetaDslx.Soal.AnnotatedElement.SetAnnotationPropertyValue(string annotationName, string propertyName, object propertyValue)
        {
            return global::MetaDslx.Soal.SoalImplementationProvider.Implementation.AnnotatedElement_SetAnnotationPropertyValue(this, annotationName, propertyName, propertyValue);
        }
    }
    
    public interface BindingElement : global::MetaDslx.Soal.NamedElement
    {
    
    }
    
    internal class BindingElementImpl : ModelObject, global::MetaDslx.Soal.BindingElement
    {
        static BindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.BindingElement; }
        }
    
        public BindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.BindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface TransportBindingElement : global::MetaDslx.Soal.BindingElement
    {
    
    }
    
    internal class TransportBindingElementImpl : ModelObject, global::MetaDslx.Soal.TransportBindingElement
    {
        static TransportBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.TransportBindingElement; }
        }
    
        public TransportBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.TransportBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface EncodingBindingElement : global::MetaDslx.Soal.BindingElement
    {
    
    }
    
    internal class EncodingBindingElementImpl : ModelObject, global::MetaDslx.Soal.EncodingBindingElement
    {
        static EncodingBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.EncodingBindingElement; }
        }
    
        public EncodingBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.EncodingBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface ProtocolBindingElement : global::MetaDslx.Soal.BindingElement
    {
    
    }
    
    internal class ProtocolBindingElementImpl : ModelObject, global::MetaDslx.Soal.ProtocolBindingElement
    {
        static ProtocolBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.ProtocolBindingElement; }
        }
    
        public ProtocolBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.ProtocolBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface HttpTransportBindingElement : global::MetaDslx.Soal.TransportBindingElement
    {
        bool Ssl { get; set; }
        bool ClientAuthentication { get; set; }
    
    }
    
    internal class HttpTransportBindingElementImpl : ModelObject, global::MetaDslx.Soal.HttpTransportBindingElement
    {
        static HttpTransportBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.HttpTransportBindingElement; }
        }
    
        public HttpTransportBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.HttpTransportBindingElement(this);
            this.MMakeDefault();
        }
        
        bool global::MetaDslx.Soal.HttpTransportBindingElement.Ssl
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.HttpTransportBindingElement.SslProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.HttpTransportBindingElement.SslProperty, value); }
        }
        
        bool global::MetaDslx.Soal.HttpTransportBindingElement.ClientAuthentication
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.HttpTransportBindingElement.ClientAuthenticationProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.HttpTransportBindingElement.ClientAuthenticationProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface RestTransportBindingElement : global::MetaDslx.Soal.TransportBindingElement
    {
    
    }
    
    internal class RestTransportBindingElementImpl : ModelObject, global::MetaDslx.Soal.RestTransportBindingElement
    {
        static RestTransportBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.RestTransportBindingElement; }
        }
    
        public RestTransportBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.RestTransportBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface WebSocketTransportBindingElement : global::MetaDslx.Soal.TransportBindingElement
    {
    
    }
    
    internal class WebSocketTransportBindingElementImpl : ModelObject, global::MetaDslx.Soal.WebSocketTransportBindingElement
    {
        static WebSocketTransportBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.WebSocketTransportBindingElement; }
        }
    
        public WebSocketTransportBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.WebSocketTransportBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface SoapEncodingBindingElement : global::MetaDslx.Soal.EncodingBindingElement
    {
        global::MetaDslx.Soal.SoapEncodingStyle Style { get; set; }
        global::MetaDslx.Soal.SoapVersion Version { get; set; }
        bool Mtom { get; set; }
    
    }
    
    internal class SoapEncodingBindingElementImpl : ModelObject, global::MetaDslx.Soal.SoapEncodingBindingElement
    {
        static SoapEncodingBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.SoapEncodingBindingElement; }
        }
    
        public SoapEncodingBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.SoapEncodingBindingElement(this);
            this.MMakeDefault();
        }
        
        global::MetaDslx.Soal.SoapEncodingStyle global::MetaDslx.Soal.SoapEncodingBindingElement.Style
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement.StyleProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoapEncodingStyle)result;
                else return default(global::MetaDslx.Soal.SoapEncodingStyle);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement.StyleProperty, value); }
        }
        
        global::MetaDslx.Soal.SoapVersion global::MetaDslx.Soal.SoapEncodingBindingElement.Version
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement.VersionProperty); 
                if (result != null) return (global::MetaDslx.Soal.SoapVersion)result;
                else return default(global::MetaDslx.Soal.SoapVersion);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement.VersionProperty, value); }
        }
        
        bool global::MetaDslx.Soal.SoapEncodingBindingElement.Mtom
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement.MtomProperty); 
                if (result != null) return (bool)result;
                else return default(bool);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.SoapEncodingBindingElement.MtomProperty, value); }
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface XmlEncodingBindingElement : global::MetaDslx.Soal.EncodingBindingElement
    {
    
    }
    
    internal class XmlEncodingBindingElementImpl : ModelObject, global::MetaDslx.Soal.XmlEncodingBindingElement
    {
        static XmlEncodingBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.XmlEncodingBindingElement; }
        }
    
        public XmlEncodingBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.XmlEncodingBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface JsonEncodingBindingElement : global::MetaDslx.Soal.EncodingBindingElement
    {
    
    }
    
    internal class JsonEncodingBindingElementImpl : ModelObject, global::MetaDslx.Soal.JsonEncodingBindingElement
    {
        static JsonEncodingBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.JsonEncodingBindingElement; }
        }
    
        public JsonEncodingBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.JsonEncodingBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface WsProtocolBindingElement : global::MetaDslx.Soal.ProtocolBindingElement
    {
    
    }
    
    internal class WsProtocolBindingElementImpl : ModelObject, global::MetaDslx.Soal.WsProtocolBindingElement
    {
        static WsProtocolBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.WsProtocolBindingElement; }
        }
    
        public WsProtocolBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.WsProtocolBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    public interface WsAddressingBindingElement : global::MetaDslx.Soal.WsProtocolBindingElement
    {
    
    }
    
    internal class WsAddressingBindingElementImpl : ModelObject, global::MetaDslx.Soal.WsAddressingBindingElement
    {
        static WsAddressingBindingElementImpl()
        {
            global::MetaDslx.Soal.SoalDescriptor.StaticInit();
        }
    
        public override global::MetaDslx.Core.MetaModel MMetaModel
        {
            get { return global::MetaDslx.Soal.SoalInstance.Meta; }
        }
    
        public override global::MetaDslx.Core.MetaClass MMetaClass
        {
            get { return global::MetaDslx.Soal.SoalInstance.WsAddressingBindingElement; }
        }
    
        public WsAddressingBindingElementImpl() 
        {
            global::MetaDslx.Soal.SoalImplementationProvider.Implementation.WsAddressingBindingElement(this);
            this.MMakeDefault();
        }
        
        string global::MetaDslx.Soal.NamedElement.Name
        {
            get 
            {
                object result = this.MGet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty); 
                if (result != null) return (string)result;
                else return default(string);
            }
            set { this.MSet(global::MetaDslx.Soal.SoalDescriptor.NamedElement.NameProperty, value); }
        }
    }
    
    /// <summary>
    /// Factory class for creating instances of model elements.
    /// </summary>
    public class SoalFactory : ModelFactory
    {
        private static SoalFactory instance = new SoalFactory();
    
    	private SoalFactory()
    	{
    	}
    
        /// <summary>
        /// The singleton instance of the factory.
        /// </summary>
        public static SoalFactory Instance
        {
            get { return SoalFactory.instance; }
        }
    
        /// <summary>
        /// Creates a new instance of Annotation.
        /// </summary>
        public Annotation CreateAnnotation(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Annotation result = new global::MetaDslx.Soal.AnnotationImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of AnnotationProperty.
        /// </summary>
        public AnnotationProperty CreateAnnotationProperty(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		AnnotationProperty result = new global::MetaDslx.Soal.AnnotationPropertyImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Namespace.
        /// </summary>
        public Namespace CreateNamespace(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Namespace result = new global::MetaDslx.Soal.NamespaceImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of ArrayType.
        /// </summary>
        public ArrayType CreateArrayType(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		ArrayType result = new global::MetaDslx.Soal.ArrayTypeImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of NullableType.
        /// </summary>
        public NullableType CreateNullableType(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		NullableType result = new global::MetaDslx.Soal.NullableTypeImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of NonNullableType.
        /// </summary>
        public NonNullableType CreateNonNullableType(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		NonNullableType result = new global::MetaDslx.Soal.NonNullableTypeImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of PrimitiveType.
        /// </summary>
        public PrimitiveType CreatePrimitiveType(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		PrimitiveType result = new global::MetaDslx.Soal.PrimitiveTypeImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Enum.
        /// </summary>
        public Enum CreateEnum(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Enum result = new global::MetaDslx.Soal.EnumImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of EnumLiteral.
        /// </summary>
        public EnumLiteral CreateEnumLiteral(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		EnumLiteral result = new global::MetaDslx.Soal.EnumLiteralImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Property.
        /// </summary>
        public Property CreateProperty(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Property result = new global::MetaDslx.Soal.PropertyImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Struct.
        /// </summary>
        public Struct CreateStruct(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Struct result = new global::MetaDslx.Soal.StructImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Interface.
        /// </summary>
        public Interface CreateInterface(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Interface result = new global::MetaDslx.Soal.InterfaceImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Database.
        /// </summary>
        public Database CreateDatabase(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Database result = new global::MetaDslx.Soal.DatabaseImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Operation.
        /// </summary>
        public Operation CreateOperation(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Operation result = new global::MetaDslx.Soal.OperationImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of InputParameter.
        /// </summary>
        public InputParameter CreateInputParameter(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		InputParameter result = new global::MetaDslx.Soal.InputParameterImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of OutputParameter.
        /// </summary>
        public OutputParameter CreateOutputParameter(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		OutputParameter result = new global::MetaDslx.Soal.OutputParameterImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Component.
        /// </summary>
        public Component CreateComponent(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Component result = new global::MetaDslx.Soal.ComponentImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Composite.
        /// </summary>
        public Composite CreateComposite(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Composite result = new global::MetaDslx.Soal.CompositeImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Assembly.
        /// </summary>
        public Assembly CreateAssembly(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Assembly result = new global::MetaDslx.Soal.AssemblyImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Wire.
        /// </summary>
        public Wire CreateWire(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Wire result = new global::MetaDslx.Soal.WireImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Port.
        /// </summary>
        public Port CreatePort(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Port result = new global::MetaDslx.Soal.PortImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Service.
        /// </summary>
        public Service CreateService(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Service result = new global::MetaDslx.Soal.ServiceImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Reference.
        /// </summary>
        public Reference CreateReference(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Reference result = new global::MetaDslx.Soal.ReferenceImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Implementation.
        /// </summary>
        public Implementation CreateImplementation(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Implementation result = new global::MetaDslx.Soal.ImplementationImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Language.
        /// </summary>
        public Language CreateLanguage(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Language result = new global::MetaDslx.Soal.LanguageImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Deployment.
        /// </summary>
        public Deployment CreateDeployment(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Deployment result = new global::MetaDslx.Soal.DeploymentImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Environment.
        /// </summary>
        public Environment CreateEnvironment(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Environment result = new global::MetaDslx.Soal.EnvironmentImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Runtime.
        /// </summary>
        public Runtime CreateRuntime(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Runtime result = new global::MetaDslx.Soal.RuntimeImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Binding.
        /// </summary>
        public Binding CreateBinding(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Binding result = new global::MetaDslx.Soal.BindingImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of Endpoint.
        /// </summary>
        public Endpoint CreateEndpoint(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		Endpoint result = new global::MetaDslx.Soal.EndpointImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of HttpTransportBindingElement.
        /// </summary>
        public HttpTransportBindingElement CreateHttpTransportBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		HttpTransportBindingElement result = new global::MetaDslx.Soal.HttpTransportBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of RestTransportBindingElement.
        /// </summary>
        public RestTransportBindingElement CreateRestTransportBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		RestTransportBindingElement result = new global::MetaDslx.Soal.RestTransportBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of WebSocketTransportBindingElement.
        /// </summary>
        public WebSocketTransportBindingElement CreateWebSocketTransportBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		WebSocketTransportBindingElement result = new global::MetaDslx.Soal.WebSocketTransportBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of SoapEncodingBindingElement.
        /// </summary>
        public SoapEncodingBindingElement CreateSoapEncodingBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		SoapEncodingBindingElement result = new global::MetaDslx.Soal.SoapEncodingBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of XmlEncodingBindingElement.
        /// </summary>
        public XmlEncodingBindingElement CreateXmlEncodingBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		XmlEncodingBindingElement result = new global::MetaDslx.Soal.XmlEncodingBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of JsonEncodingBindingElement.
        /// </summary>
        public JsonEncodingBindingElement CreateJsonEncodingBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		JsonEncodingBindingElement result = new global::MetaDslx.Soal.JsonEncodingBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    
        /// <summary>
        /// Creates a new instance of WsAddressingBindingElement.
        /// </summary>
        public WsAddressingBindingElement CreateWsAddressingBindingElement(IEnumerable<ModelPropertyInitializer> initializers = null)
    	{
    		WsAddressingBindingElement result = new global::MetaDslx.Soal.WsAddressingBindingElementImpl();
    		if (initializers != null)
    		{
    			this.Init((ModelObject)result, initializers);
    		}
    		return result;
    	}
    }
    
    internal static class SoalImplementationProvider
    {
        // If there is a compile error at this line, create a new class called SoalImplementation
    	// which is a subclass of SoalImplementationBase:
        private static SoalImplementation implementation = new SoalImplementation();
    
        public static SoalImplementation Implementation
        {
            get { return SoalImplementationProvider.implementation; }
        }
    }
    
    public static class SoapVersionExtensions
    {
    }
    
    public static class SoapEncodingStyleExtensions
    {
    }
    
    /// <summary>
    /// Base class for implementing the behavior of the model elements.
    /// This class has to be be overriden in SoalImplementation to provide custom
    /// implementation for the constructors, operations and property values.
    /// </summary>
    internal abstract class SoalImplementationBase
    {
        /// <summary>
    	/// Implements the constructor: AnnotatedElement()
        /// </summary>
        public virtual void AnnotatedElement(AnnotatedElement @this)
        {
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.AddAnnotation()
        /// </summary>
        public virtual global::MetaDslx.Soal.Annotation AnnotatedElement_AddAnnotation(global::MetaDslx.Soal.AnnotatedElement @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.HasAnnotation()
        /// </summary>
        public virtual bool AnnotatedElement_HasAnnotation(global::MetaDslx.Soal.AnnotatedElement @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.GetAnnotation()
        /// </summary>
        public virtual global::MetaDslx.Soal.Annotation AnnotatedElement_GetAnnotation(global::MetaDslx.Soal.AnnotatedElement @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.GetAnnotations()
        /// </summary>
        public virtual global::System.Collections.Generic.IList<global::MetaDslx.Soal.Annotation> AnnotatedElement_GetAnnotations(global::MetaDslx.Soal.AnnotatedElement @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.HasAnnotationProperty()
        /// </summary>
        public virtual bool AnnotatedElement_HasAnnotationProperty(global::MetaDslx.Soal.AnnotatedElement @this, string annotationName, string propertyName)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.GetAnnotationPropertyValue()
        /// </summary>
        public virtual object AnnotatedElement_GetAnnotationPropertyValue(global::MetaDslx.Soal.AnnotatedElement @this, string annotationName, string propertyName)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: AnnotatedElement.SetAnnotationPropertyValue()
        /// </summary>
        public virtual global::MetaDslx.Soal.AnnotationProperty AnnotatedElement_SetAnnotationPropertyValue(global::MetaDslx.Soal.AnnotatedElement @this, string annotationName, string propertyName, object propertyValue)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
    	/// Implements the constructor: Annotation()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void Annotation(Annotation @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
        /// Implements the operation: Annotation.HasProperty()
        /// </summary>
        public virtual bool Annotation_HasProperty(global::MetaDslx.Soal.Annotation @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: Annotation.GetProperty()
        /// </summary>
        public virtual global::MetaDslx.Soal.AnnotationProperty Annotation_GetProperty(global::MetaDslx.Soal.Annotation @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: Annotation.GetPropertyValue()
        /// </summary>
        public virtual object Annotation_GetPropertyValue(global::MetaDslx.Soal.Annotation @this, string name)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
        /// Implements the operation: Annotation.SetPropertyValue()
        /// </summary>
        public virtual global::MetaDslx.Soal.AnnotationProperty Annotation_SetPropertyValue(global::MetaDslx.Soal.Annotation @this, string name, object value)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
    	/// Implements the constructor: AnnotationProperty()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void AnnotationProperty(AnnotationProperty @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: NamedElement()
        /// </summary>
        public virtual void NamedElement(NamedElement @this)
        {
        }
    
        /// <summary>
    	/// Implements the constructor: TypedElement()
        /// </summary>
        public virtual void TypedElement(TypedElement @this)
        {
        }
    
        /// <summary>
    	/// Implements the constructor: SoalType()
        /// </summary>
        public virtual void SoalType(SoalType @this)
        {
        }
    
        /// <summary>
    	/// Implements the constructor: Namespace()
    	/// Direct superclasses: global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Namespace(Namespace @this)
        {
            this.Declaration(@this);
        }
    
        /// <summary>
        /// Returns the value of the derived property: Namespace.FullName
        /// </summary>
        public virtual string Namespace_FullName(Namespace @this)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
    	/// Implements the constructor: Declaration()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Declaration(Declaration @this)
        {
            this.NamedElement(@this);
            this.AnnotatedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: ArrayType()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType
    	/// All superclasses: global::MetaDslx.Soal.SoalType
        /// </summary>
        public virtual void ArrayType(ArrayType @this)
        {
            this.SoalType(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: NullableType()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType
    	/// All superclasses: global::MetaDslx.Soal.SoalType
        /// </summary>
        public virtual void NullableType(NullableType @this)
        {
            this.SoalType(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: NonNullableType()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType
    	/// All superclasses: global::MetaDslx.Soal.SoalType
        /// </summary>
        public virtual void NonNullableType(NonNullableType @this)
        {
            this.SoalType(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: PrimitiveType()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void PrimitiveType(PrimitiveType @this)
        {
            this.SoalType(@this);
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Enum()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Enum(Enum @this)
        {
            this.SoalType(@this);
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: EnumLiteral()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void EnumLiteral(EnumLiteral @this)
        {
            this.NamedElement(@this);
            this.TypedElement(@this);
            this.AnnotatedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Property()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Property(Property @this)
        {
            this.NamedElement(@this);
            this.TypedElement(@this);
            this.AnnotatedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Struct()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Struct(Struct @this)
        {
            this.SoalType(@this);
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Interface()
    	/// Direct superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Interface(Interface @this)
        {
            this.SoalType(@this);
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Database()
    	/// Direct superclasses: global::MetaDslx.Soal.Interface
    	/// All superclasses: global::MetaDslx.Soal.Interface, global::MetaDslx.Soal.SoalType, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Database(Database @this)
        {
            this.Interface(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Operation()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// Initializes the following readonly properties:
        ///    Operation.Result
        /// </summary>
        public virtual void Operation(Operation @this)
        {
            this.NamedElement(@this);
            this.AnnotatedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: InputParameter()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void InputParameter(InputParameter @this)
        {
            this.NamedElement(@this);
            this.TypedElement(@this);
            this.AnnotatedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: OutputParameter()
    	/// Direct superclasses: global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
    	/// All superclasses: global::MetaDslx.Soal.TypedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void OutputParameter(OutputParameter @this)
        {
            this.TypedElement(@this);
            this.AnnotatedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Component()
    	/// Direct superclasses: global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Component(Component @this)
        {
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Composite()
    	/// Direct superclasses: global::MetaDslx.Soal.Component
    	/// All superclasses: global::MetaDslx.Soal.Component, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Composite(Composite @this)
        {
            this.Component(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Assembly()
    	/// Direct superclasses: global::MetaDslx.Soal.Composite
    	/// All superclasses: global::MetaDslx.Soal.Composite, global::MetaDslx.Soal.Component, global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Assembly(Assembly @this)
        {
            this.Composite(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Wire()
        /// </summary>
        public virtual void Wire(Wire @this)
        {
        }
    
        /// <summary>
    	/// Implements the constructor: Port()
        /// </summary>
        public virtual void Port(Port @this)
        {
        }
    
        /// <summary>
        /// Returns the value of the derived property: Port.Name
        /// </summary>
        public virtual string Port_Name(Port @this)
        {
            throw new NotImplementedException();
        }
    
        /// <summary>
    	/// Implements the constructor: Service()
    	/// Direct superclasses: global::MetaDslx.Soal.Port
    	/// All superclasses: global::MetaDslx.Soal.Port
        /// </summary>
        public virtual void Service(Service @this)
        {
            this.Port(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Reference()
    	/// Direct superclasses: global::MetaDslx.Soal.Port
    	/// All superclasses: global::MetaDslx.Soal.Port
        /// </summary>
        public virtual void Reference(Reference @this)
        {
            this.Port(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Implementation()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void Implementation(Implementation @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Language()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void Language(Language @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Deployment()
    	/// Direct superclasses: global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Deployment(Deployment @this)
        {
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Environment()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void Environment(Environment @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Runtime()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void Runtime(Runtime @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Binding()
    	/// Direct superclasses: global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Binding(Binding @this)
        {
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: Endpoint()
    	/// Direct superclasses: global::MetaDslx.Soal.Declaration
    	/// All superclasses: global::MetaDslx.Soal.Declaration, global::MetaDslx.Soal.NamedElement, global::MetaDslx.Soal.AnnotatedElement
        /// </summary>
        public virtual void Endpoint(Endpoint @this)
        {
            this.Declaration(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: BindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.NamedElement
    	/// All superclasses: global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void BindingElement(BindingElement @this)
        {
            this.NamedElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: TransportBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.BindingElement
    	/// All superclasses: global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void TransportBindingElement(TransportBindingElement @this)
        {
            this.BindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: EncodingBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.BindingElement
    	/// All superclasses: global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void EncodingBindingElement(EncodingBindingElement @this)
        {
            this.BindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: ProtocolBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.BindingElement
    	/// All superclasses: global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void ProtocolBindingElement(ProtocolBindingElement @this)
        {
            this.BindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: HttpTransportBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.TransportBindingElement
    	/// All superclasses: global::MetaDslx.Soal.TransportBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void HttpTransportBindingElement(HttpTransportBindingElement @this)
        {
            this.TransportBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: RestTransportBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.TransportBindingElement
    	/// All superclasses: global::MetaDslx.Soal.TransportBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void RestTransportBindingElement(RestTransportBindingElement @this)
        {
            this.TransportBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: WebSocketTransportBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.TransportBindingElement
    	/// All superclasses: global::MetaDslx.Soal.TransportBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void WebSocketTransportBindingElement(WebSocketTransportBindingElement @this)
        {
            this.TransportBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: SoapEncodingBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.EncodingBindingElement
    	/// All superclasses: global::MetaDslx.Soal.EncodingBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void SoapEncodingBindingElement(SoapEncodingBindingElement @this)
        {
            this.EncodingBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: XmlEncodingBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.EncodingBindingElement
    	/// All superclasses: global::MetaDslx.Soal.EncodingBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void XmlEncodingBindingElement(XmlEncodingBindingElement @this)
        {
            this.EncodingBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: JsonEncodingBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.EncodingBindingElement
    	/// All superclasses: global::MetaDslx.Soal.EncodingBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void JsonEncodingBindingElement(JsonEncodingBindingElement @this)
        {
            this.EncodingBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: WsProtocolBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.ProtocolBindingElement
    	/// All superclasses: global::MetaDslx.Soal.ProtocolBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void WsProtocolBindingElement(WsProtocolBindingElement @this)
        {
            this.ProtocolBindingElement(@this);
        }
    
        /// <summary>
    	/// Implements the constructor: WsAddressingBindingElement()
    	/// Direct superclasses: global::MetaDslx.Soal.WsProtocolBindingElement
    	/// All superclasses: global::MetaDslx.Soal.WsProtocolBindingElement, global::MetaDslx.Soal.ProtocolBindingElement, global::MetaDslx.Soal.BindingElement, global::MetaDslx.Soal.NamedElement
        /// </summary>
        public virtual void WsAddressingBindingElement(WsAddressingBindingElement @this)
        {
            this.WsProtocolBindingElement(@this);
        }
    
    
    
    }
    
}
