namespace MetaDslx.Soal
{
	metamodel Soal(Uri="http://MetaDslx.Soal/1.0");

	const PrimitiveType Object = new PrimitiveType() { Name = "object", Nullable = true };
	const PrimitiveType String = new PrimitiveType() { Name = "string", Nullable = true };
	const PrimitiveType Int = new PrimitiveType() { Name = "int" };
	const PrimitiveType Long = new PrimitiveType() { Name = "long" };
	const PrimitiveType Float = new PrimitiveType() { Name = "float" };
	const PrimitiveType Double = new PrimitiveType() { Name = "double" };
	const PrimitiveType Byte = new PrimitiveType() { Name = "byte" };
	const PrimitiveType Bool = new PrimitiveType() { Name = "bool" };
	const PrimitiveType Void = new PrimitiveType() { Name = "void" };
	const PrimitiveType Date = new PrimitiveType() { Name = "Date" };
	const PrimitiveType Time = new PrimitiveType() { Name = "Time" };
	const PrimitiveType DateTime = new PrimitiveType() { Name = "DateTime" };
	const PrimitiveType TimeSpan = new PrimitiveType() { Name = "TimeSpan" };

	
	abstract class NamedElement
	{
		[Name]
		string Name;
	}

	abstract class TypedElement
	{
		[Type]
		SoalType Type;
	}

	[Type]
	abstract class SoalType
	{
	}

	[Scope]
	class Namespace : Declaration
	{
		string Uri;
		string Prefix;
		derived string FullName;
		[ScopeEntry]
		containment list<Declaration> Declarations;
	}

	abstract class Declaration : NamedElement
	{
		Namespace Namespace;
	}

	association Namespace.Declarations with Declaration.Namespace;

	class ArrayType : SoalType
	{
		SoalType InnerType;
	}

	class NullableType : SoalType
	{
		SoalType InnerType;
	}

	class NonNullableType : SoalType
	{
		SoalType InnerType;
	}

	class PrimitiveType : SoalType, NamedElement
	{
		PrimitiveType()
		{
			Nullable = false;
		}

		bool Nullable;
	}

	[Scope]
	class Enum : SoalType, Declaration
	{
		[ScopeEntry]
		containment list<EnumLiteral> EnumLiterals;
	}

	class EnumLiteral : NamedElement, TypedElement
	{
		EnumLiteral()
		{
			Type = Enum;
		}

		Enum Enum;
	}

	association EnumLiteral.Enum with Enum.EnumLiterals;

	[Scope]
	abstract class StructuredType : SoalType, Declaration
	{
		[ScopeEntry]
		containment list<Property> Properties;
	}

	class Property : NamedElement, TypedElement
	{
		StructuredType Parent;
	}

	association StructuredType.Properties with Property.Parent;

	class Struct : StructuredType
	{
		[InheritedScope]
		Struct BaseType;
	}

	class Exception : StructuredType
	{
		[InheritedScope]
		Exception BaseType;
	}

	class Entity : StructuredType
	{
		[InheritedScope]
		Entity BaseType;
	}

	[Scope]
	class Interface : SoalType, Declaration
	{
		[ScopeEntry]
		containment list<Operation> Operations;
	}

	class Database : Interface
	{
		[ScopeEntry]
		list<Entity> Entities;
	}

	class Operation : NamedElement
	{
		Interface Interface;
		bool IsOneway;
		SoalType ReturnType;
		containment list<Parameter> Parameters;
		list<Exception> Exceptions;
	}

	association Interface.Operations with Operation.Interface;

	class Parameter : NamedElement, TypedElement
	{
		Operation Operation;
	}

	association Operation.Parameters with Parameter.Operation;

	[Scope]
	class Component : Declaration, StructuredType
	{
		[InheritedScope]
		Component BaseComponent;
		bool IsAbstract;
		[ScopeEntry]
		containment list<Service> Services;
		[ScopeEntry]
		containment list<Reference> References;
		[ScopeEntry]
		containment list<Property> Properties;
		containment Implementation Implementation;
		containment Language Language;
	}

	class Composite : Component
	{
		[ScopeEntry]
		list<Component> Components;
		containment list<Wire> Wires;
	}

	class Assembly : Composite
	{
	}

	class Wire
	{
		InterfaceReference Source;
		InterfaceReference Target;
	}

	class InterfaceReference
	{
		InterfaceReference()
		{
			// this.Name = this.OptionalName != "" ? this.OptionalName : this.Interface.Name;
		}

		[Name]
		derived string Name;
		string OptionalName;
		Interface Interface;
		Binding Binding;
	}

	class Service : InterfaceReference
	{
	}

	class Reference : InterfaceReference
	{
	}

	class Implementation : NamedElement
	{
	}

	class Language : NamedElement
	{
	}
	
	class Deployment : Declaration
	{
		containment list<Environment> Environments;
		containment list<Wire> Wires;
	}

	class Environment : NamedElement
	{
		containment Runtime Runtime;
		list<Database> Databases;
		list<Assembly> Assemblies;
	}

	class Runtime : NamedElement
	{
	}

	class Binding : Declaration
	{
		containment TransportBindingElement Transport;
		containment list<EncodingBindingElement> Encodings;
		containment list<ProtocolBindingElement> Protocols;
	}

	class Endpoint : Declaration
	{
		Interface Interface;
		Binding Binding;
		string Address;
	}

	abstract class BindingElement : NamedElement
	{
	}

	abstract class TransportBindingElement : BindingElement
	{
	}

	abstract class EncodingBindingElement : BindingElement
	{
	}

	abstract class ProtocolBindingElement : BindingElement
	{
	}


	class HttpTransportBindingElement : TransportBindingElement
	{
		bool Ssl;
		bool ClientAuthentication;
	}

	class RestTransportBindingElement : TransportBindingElement
	{
	}

	class WebSocketTransportBindingElement : TransportBindingElement
	{
	}

	
	enum SoapVersion
	{
		Soap11,
		Soap12
	}
	
	enum SoapEncodingStyle
	{
		DocumentWrapped,
		DocumentLiteral,
		RpcLiteral,
		RpcEncoded
	}

	class SoapEncodingBindingElement : EncodingBindingElement
	{
		SoapEncodingStyle Style;
		SoapVersion Version;
		bool Mtom;
	}

	class XmlEncodingBindingElement : EncodingBindingElement
	{
	}

	class JsonEncodingBindingElement : EncodingBindingElement
	{
	}

	
	abstract class WsProtocolBindingElement : ProtocolBindingElement
	{
	}

	class WsAddressingBindingElement : WsProtocolBindingElement
	{
	}

}
