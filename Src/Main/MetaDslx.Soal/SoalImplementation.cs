using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    internal class SoalImplementation : SoalImplementationBase
    {
        public override string Namespace_FullName(Namespace @this)
        {
            if (@this.Namespace == null) return @this.Name;
            else return @this.Namespace.FullName + "." + @this.Name;
        }

        public override string InterfaceReference_Name(InterfaceReference @this)
        {
            if (((ModelObject)@this).MIsValueCreated(SoalDescriptor.InterfaceReference.InterfaceProperty))
            {
                return @this.OptionalName != null ? @this.OptionalName : @this.Interface.Name;
            }
            else
            {
                return @this.OptionalName ?? string.Empty;
            }
        }
    }

    internal static class SoalExtensions
    {
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
            result.Remove(SoalCompiler.XsdNamespace);
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
                        CheckArrayType(prop.Type, arrayNames, result);
                    }
                }
                Interface intf = decl as Interface;
                if (intf != null)
                {
                    foreach (var op in intf.Operations)
                    {
                        CheckArrayType(op.ReturnType, arrayNames, result);
                        foreach (var param in op.Parameters)
                        {
                            CheckArrayType(param.Type, arrayNames, result);
                        }
                    }
                }
            }
            return result;
        }

        private static void CheckArrayType(SoalType type, HashSet<string> arrayNames, List<ArrayType> arrayTypes)
        {
            if (type is ArrayType)
            {
                ArrayType atype = (ArrayType)type;
                if (!arrayNames.Contains(atype.GetXsdName()))
                {
                    arrayTypes.Add(atype);
                }
            }
            else if (type is NonNullableType)
            {
                ArrayType atype = ((NonNullableType)type).InnerType as ArrayType;
                if (atype != null && !arrayNames.Contains(atype.GetXsdName()))
                {
                    arrayTypes.Add(atype);
                }
            }
        }

        public static Namespace GetNamespace(this SoalType type, Namespace currentNamespace)
        {
            if (type is PrimitiveType) return SoalCompiler.XsdNamespace;
            if (type is NullableType) return GetNamespace(((NullableType)type).InnerType, currentNamespace);
            if (type is NonNullableType) return GetNamespace(((NonNullableType)type).InnerType, currentNamespace);
            if (type is ArrayType) return currentNamespace;
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
            if (type is PrimitiveType) return ((PrimitiveType)type).Name;
            if (type is NullableType) return GetXsdName(((NullableType)type).InnerType);
            if (type is NonNullableType) return GetXsdName(((NonNullableType)type).InnerType);
            if (type is ArrayType) return "Arrayof"+GetXsdName(((ArrayType)type).InnerType);
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
            if (type is PrimitiveType) return ((PrimitiveType)type).Nullable;
            if (type is NullableType) return true;
            if (type is NonNullableType) return false;
            if (type is ArrayType) return true;
            if (type is Enum) return false;
            if (type is StructuredType) return true;
            return false;
        }

        public static string IsNullableXsd(this SoalType type)
        {
            return type.IsNullable().ToString().ToLower();
        }
    }
}
