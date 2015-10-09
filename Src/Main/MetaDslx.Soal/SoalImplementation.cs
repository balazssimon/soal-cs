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
                        if (prop.Type is ArrayType)
                        {
                            ArrayType atype = (ArrayType)prop.Type;
                            if (!arrayNames.Contains(atype.GetXsdName()))
                            {
                                result.Add(atype);
                            }
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
                            ArrayType atype = (ArrayType)op.ReturnType;
                            if (!arrayNames.Contains(atype.GetXsdName()))
                            {
                                result.Add(atype);
                            }
                        }
                        foreach (var param in op.Parameters)
                        {
                            if (param.Type is ArrayType)
                            {
                                ArrayType atype = (ArrayType)param.Type;
                                if (!arrayNames.Contains(atype.GetXsdName()))
                                {
                                    result.Add(atype);
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public static Namespace GetNamespace(this SoalType type, Namespace currentNamespace)
        {
            if (type is PrimitiveType) return SoalCompiler.XsdNamespace;
            if (type is NullableType) return GetNamespace(((NullableType)type).InnerType, currentNamespace);
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
    }
}
