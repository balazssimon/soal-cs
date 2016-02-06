using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalAnnotations
    {
        public const string All = "All";
        public const string Choice = "Choice";
        public const string NoWrap = "NoWrap";
        public const string Rpc = "Rpc";
        public const string Element = "Element";
        public const string Attribute = "Attribute";
        public const string Name = "Name";
        public const string Restriction = "Restriction";
    }

    public class SoalAnnotationProperties
    {
        public const string Wrapped = "wrapped";
        public const string Items = "items";
        public const string Sap = "sap";
        public const string Name = "name";
        public const string Optional = "optional";
        public const string Required = "required";
        public const string Pattern = "pattern";
        public const string Length = "length";
        public const string MinLength = "minLength";
        public const string MaxLength = "maxLength";
        public const string MaxExclusive = "maxExclusive";
        public const string MinExclusive = "minExclusive";
        public const string MaxInclusive = "maxInclusive";
        public const string MinInclusive = "minInclusive";
        public const string TotalDigits = "totalDigits";
        public const string FractionDigits = "fractionDigits";

    }

    internal class SoalImplementation : SoalImplementationBase
    {
        public override string Namespace_FullName(Namespace @this)
        {
            if (@this.Namespace == null) return @this.Name;
            else return @this.Namespace.FullName + "." + @this.Name;
        }

        public override string Port_Name(Port @this)
        {
            if (((ModelObject)@this).MIsValueCreated(SoalDescriptor.Port.InterfaceProperty))
            {
                return @this.OptionalName != null ? @this.OptionalName : @this.Interface.Name;
            }
            else
            {
                return @this.OptionalName ?? string.Empty;
            }
        }

        public override Annotation AnnotatedElement_AddAnnotation(AnnotatedElement @this, string name)
        {
            Annotation result = @this.GetAnnotation(name);
            if (result == null)
            {
                result = SoalFactory.Instance.CreateAnnotation();
                result.Name = name;
                @this.Annotations.Add(result);
            }
            return result;
        }

        public override IList<Annotation> AnnotatedElement_GetAnnotations(AnnotatedElement @this, string name)
        {
            List<Annotation> result = new List<Soal.Annotation>();
            if (@this == null) return result;
            foreach (var annot in @this.Annotations)
            {
                if (annot.Name == name)
                {
                    result.Add(annot);
                }
            }
            return result;
        }

        public override Annotation AnnotatedElement_GetAnnotation(AnnotatedElement @this, string name)
        {
            return @this.GetAnnotations(name).FirstOrDefault();
        }

        public override bool AnnotatedElement_HasAnnotation(AnnotatedElement @this, string name)
        {
            return @this.GetAnnotation(name) != null;
        }

        public override bool AnnotatedElement_HasAnnotationProperty(AnnotatedElement @this, string annotationName, string propertyName)
        {
            if (@this == null) return false;
            Annotation annot = @this.GetAnnotation(annotationName);
            if (annot != null)
            { 
                return annot.HasProperty(propertyName);
            }
            return false;
        }

        public override object AnnotatedElement_GetAnnotationPropertyValue(AnnotatedElement @this, string annotationName, string propertyName)
        {
            if (@this == null) return null;
            Annotation annot = @this.GetAnnotation(annotationName);
            if (annot != null)
            {
                return annot.GetPropertyValue(propertyName);
            }
            return null;
        }

        public override AnnotationProperty AnnotatedElement_SetAnnotationPropertyValue(AnnotatedElement @this, string annotationName, string propertyName, object propertyValue)
        {
            if (@this == null) return null;
            Annotation annot = @this.AddAnnotation(annotationName);
            return annot.SetPropertyValue(propertyName, propertyValue);
        }

        public override AnnotationProperty Annotation_GetProperty(Annotation @this, string name)
        {
            if (@this == null) return null;
            foreach (var prop in @this.Properties)
            {
                if (prop.Name == name) return prop;
            }
            return null;
        }

        public override bool Annotation_HasProperty(Annotation @this, string name)
        {
            return @this.GetProperty(name) != null;
        }

        public override object Annotation_GetPropertyValue(Annotation @this, string name)
        {
            if (@this == null) return null;
            AnnotationProperty prop = @this.GetProperty(name);
            if (prop != null)
            {
                return prop.Value;
            }
            return null;
        }

        public override AnnotationProperty Annotation_SetPropertyValue(Annotation @this, string name, object value)
        {
            if (@this == null) return null;
            AnnotationProperty prop = @this.GetProperty(name);
            if (prop == null)
            {
                prop = SoalFactory.Instance.CreateAnnotationProperty();
                prop.Name = name;
                @this.Properties.Add(prop);
            }
            prop.Value = value;
            return prop;
        }

    }

    internal static class SoalExtensions
    {
        public static string FullName(this Declaration declaration)
        {
            if (declaration == null) return string.Empty;
            if (declaration.Namespace == null) return declaration.Name;
            return declaration.Namespace.FullName + "." + declaration.Name;
        }

        public static bool IsIdentifier(this string name)
        {
            return Regex.IsMatch(name, @"[a-zA-Z\_][0-9a-zA-Z\_]*");
        }

        public static bool IsArrayType(this SoalType type)
        {
            if (type == null) return false;
            if (type is NonNullableType) return ((NonNullableType)type).InnerType.IsArrayType();
            if (type is NullableType) return ((NullableType)type).InnerType.IsArrayType();
            if (type is ArrayType) return true;
            return false;
        }

        public static SoalType GetCoreType(this SoalType type)
        {
            if (type == null) return null;
            if (type is NonNullableType) return ((NonNullableType)type).InnerType.GetCoreType();
            if (type is NullableType) return ((NullableType)type).InnerType.GetCoreType();
            if (type is ArrayType) return ((ArrayType)type).InnerType.GetCoreType();
            return type;
        }

        public static string UriWithSlash(this Namespace ns)
        {
            string uri = ns.Uri;
            if (uri == null) return uri;
            if (!uri.EndsWith("/")) return uri + "/";
            else return uri;
        }

        public static List<Namespace> GetImportedNamespaces(this Namespace ns)
        {
            List<Namespace> result = new List<Namespace>();
            foreach (var decl in ns.Declarations)
            {
                StructuredType stype = decl as StructuredType;
                if (stype != null)
                {
                    foreach (var prop in stype.Properties)
                    {
                        Namespace extns = prop.Type.GetNamespace(ns);
                        if (!result.Contains(extns))
                        {
                            result.Add(extns);
                        }
                    }
                }
                Interface intf = decl as Interface;
                if (intf != null)
                {
                    foreach (var op in intf.Operations)
                    {
                        if (op.ReturnType is ArrayType)
                        {
                            Namespace extns = op.ReturnType.GetNamespace(ns);
                            if (!result.Contains(extns))
                            {
                                result.Add(extns);
                            }
                        }
                        foreach (var param in op.Parameters)
                        {
                            Namespace extns = param.Type.GetNamespace(ns);
                            if (!result.Contains(extns))
                            {
                                result.Add(extns);
                            }
                        }
                    }
                }
            }
            result.Remove(SoalGenerator.XsdNamespace);
            result.Remove(ns);
            result.Remove(null);
            return result;
        }

        public static List<ArrayType> GetArrayTypes(this Namespace ns)
        {
            HashSet<string> arrayNames = new HashSet<string>();
            List<ArrayType> result = new List<ArrayType>();
            foreach (var decl in ns.Declarations)
            {
                StructuredType stype = decl as StructuredType;
                if (stype != null)
                {
                    foreach (var prop in stype.Properties)
                    {
                        CheckArrayType(prop.Type, prop.Annotations, arrayNames, result);
                    }
                }
                Interface intf = decl as Interface;
                if (intf != null)
                {
                    foreach (var op in intf.Operations)
                    {
                        CheckArrayType(op.ReturnType, op.Annotations, arrayNames, result);
                        foreach (var param in op.Parameters)
                        {
                            CheckArrayType(param.Type, param.Annotations, arrayNames, result);
                        }
                    }
                }
            }
            return result;
        }

        public static object GetAnnotationPropertyValue(this IList<Annotation> annotations, string annotationName, string propertyName)
        {
            foreach (var annot in annotations)
            {
                if (annot.Name == annotationName)
                {
                    return annot.GetPropertyValue(propertyName);
                }
            }
            return null;
        }

        public static Annotation GetAnnotation(this IList<Annotation> annotations, string name)
        {
            foreach (var annot in annotations)
            {
                if (annot.Name == name)
                {
                    return annot;
                }
            }
            return null;
        }

        public static bool ContainsAnnotation(this IList<Annotation> annotations, string name)
        {
            foreach (var annot in annotations)
            {
                if (annot.Name == name)
                {
                    return true;
                }
            }
            return false;
        }

        private static void CheckArrayType(SoalType type, IList<Annotation> annotations, HashSet<string> arrayNames, List<ArrayType> arrayTypes)
        {
            if (annotations.Any(a => a.Name == SoalAnnotations.Element && !(bool)a.GetPropertyValue(SoalAnnotationProperties.Wrapped))) return;
            if (type is ArrayType)
            {
                ArrayType atype = (ArrayType)type;
                string aname = atype.GetXsdName();
                if (atype.InnerType != SoalInstance.Byte && !arrayNames.Contains(aname))
                {
                    arrayNames.Add(aname);
                    arrayTypes.Add(atype);
                }
            }
            else if (type is NonNullableType)
            {
                ArrayType atype = ((NonNullableType)type).InnerType as ArrayType;
                if (atype != null)
                {
                    string aname = atype.GetXsdName();
                    if (atype.InnerType != SoalInstance.Byte && !arrayNames.Contains(aname))
                    {
                        arrayNames.Add(aname);
                        arrayTypes.Add(atype);
                    }
                }
            }
        }

        public static Namespace GetNamespace(this SoalType type, Namespace currentNamespace)
        {
            if (type is PrimitiveType) return SoalGenerator.XsdNamespace;
            if (type is NullableType) return GetNamespace(((NullableType)type).InnerType, currentNamespace);
            if (type is NonNullableType) return GetNamespace(((NonNullableType)type).InnerType, currentNamespace);
            if (type is ArrayType)
            {
                if (((ArrayType)type).InnerType == SoalInstance.Byte) return SoalGenerator.XsdNamespace;
                else return currentNamespace;
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Namespace;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Namespace;
            }
            return null;
        }

        public static string GetXsdName(this SoalType type)
        {
            if (type is PrimitiveType)
            {
                string name = ((PrimitiveType)type).Name;
                switch (name)
                {
                    case "int":
                    case "long":
                    case "float":
                    case "double":
                    case "string":
                    case "byte":
                        return name;
                    case "object":
                        return "anyType";
                    case "bool":
                        return "boolean";
                    case "Date":
                        return "date";
                    case "Time":
                        return "time";
                    case "DateTime":
                        return "dateTime";
                    case "TimeSpan":
                        return "duration";
                    default:
                        break;
                }
            }
            if (type is NullableType) return GetXsdName(((NullableType)type).InnerType);
            if (type is NonNullableType) return GetXsdName(((NonNullableType)type).InnerType);
            if (type is ArrayType)
            {
                if (((ArrayType)type).InnerType == SoalInstance.Byte) return "base64Binary";
                else return (GetXsdName(((ArrayType)type).InnerType) + "List").ToPascalCase();
            }
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Name;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Name;
            }
            return null;
        }

        public static string ToPascalCase(this string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return identifier;
            return identifier.Substring(0, 1).ToUpper() + identifier.Substring(1);
        }

        public static string ToCamelCase(this string identifier)
        {
            if (string.IsNullOrEmpty(identifier)) return identifier;
            return identifier.Substring(0, 1).ToLower() + identifier.Substring(1);
        }

        public static bool HasXsdNamespace(this SoalType type)
        {
            if (type is PrimitiveType) return true;
            if (type is NullableType) return HasXsdNamespace(((NullableType)type).InnerType);
            if (type is NonNullableType) return HasXsdNamespace(((NonNullableType)type).InnerType);
            if (type is ArrayType) return HasXsdNamespace(((ArrayType)type).InnerType);
            if (type is Enum)
            {
                Enum etype = (Enum)type;
                return etype.Namespace != null && etype.Namespace.Uri != null;
            }
            if (type is StructuredType)
            {
                StructuredType stype = (StructuredType)type;
                return stype.Namespace != null && stype.Namespace.Uri != null;
            }
            return false;
        }

        public static bool IsNullable(this SoalType type)
        {
            if (type is NonNullableType) return false;
            if (type is NullableType) return true;
            if (type is PrimitiveType) return ((PrimitiveType)type).Nullable;
            if (type is ArrayType) return true;
            if (type is Enum) return false;
            if (type is StructuredType) return true;
            return false;
        }

        public static string IsNullableXsd(this SoalType type)
        {
            return type.IsNullable().ToString().ToLower();
        }

        public static List<Exception> GetInterfaceExceptions(this Interface intf)
        {
            List<Exception> result = new List<Exception>();
            foreach (var op in intf.Operations)
            {
                foreach (var ex in op.Exceptions)
                {
                    if (!result.Contains(ex))
                    {
                        result.Add(ex);
                    }
                }
            }
            return result;
        }

        public static List<Exception> GetInterfaceExceptions(this Namespace ns)
        {
            List<Exception> result = new List<Exception>();
            foreach (var intf in ns.Declarations.OfType<Interface>())
            {
                foreach (var op in intf.Operations)
                {
                    foreach (var ex in op.Exceptions)
                    {
                        if (!result.Contains(ex))
                        {
                            result.Add(ex);
                        }
                    }
                }
            }
            return result;
        }

        public static string GetSoapPrefix(this Binding binding)
        {
            foreach (var enc in binding.Encodings)
            {
                SoapEncodingBindingElement soap = enc as SoapEncodingBindingElement;
                if (soap != null)
                {
                    if (soap.Version == SoapVersion.Soap12) return "soap12";
                    else return "soap";
                }
            }
            return null;
        }

        public static bool HasPolicy(this Binding binding)
        {
            HttpTransportBindingElement http = binding.Transport as HttpTransportBindingElement;
            if (http != null && http.Ssl) return true;
            foreach (var enc in binding.Encodings)
            {
                SoapEncodingBindingElement soap = enc as SoapEncodingBindingElement;
                if (soap != null && soap.Mtom) return true;
            }
            foreach (var prot in binding.Protocols)
            {
                if (prot is WsAddressingBindingElement) return true;
            }
            return false;
        }

        public static bool HasOperationPolicy(this Binding binding)
        {
            foreach (var prot in binding.Protocols)
            {
                //if (prot is WsSecurityBindingElement) return true;
            }
            return false;
        }

        public static string GetWsdlSoapDocRpcStyle(this Binding binding)
        {
            if (binding != null)
            {
                SoapEncodingBindingElement enc = binding.Encodings.OfType<SoapEncodingBindingElement>().FirstOrDefault();
                if (enc != null)
                {
                    if (enc.Style == SoapEncodingStyle.RpcEncoded || enc.Style == SoapEncodingStyle.RpcLiteral) return "rpc";
                }
            }
            return "document";
        }

        public static string GetWsdlSoapEncLitStyle(this Binding binding)
        {
            if (binding != null)
            {
                SoapEncodingBindingElement enc = binding.Encodings.OfType<SoapEncodingBindingElement>().FirstOrDefault();
                if (enc != null)
                {
                    if (enc.Style == SoapEncodingStyle.RpcEncoded) return "encoded";
                }
            }
            return "literal";
        }
    }
}
