using MetaDslx.Languages.Soal.Symbols;
using System;
using System.Collections.Generic;
using System.Text;
using static Antlr4.Runtime.Atn.SemanticContext;

namespace MetaDslx.Languages.Soal.Generator
{
    public partial class SoalPrinter
    {
        private string GetAncestor(Namespace currentNs, SoalType st)
        {
            if (st is Symbols.Enum enm)
            {
                var baseType = enm.BaseType;
                if (baseType is not null)
                {
                    if (baseType.Namespace == currentNs) return " : "+baseType.Name;
                    else return " : " + baseType.FullName;
                }
            }
            if (st is Symbols.Struct str)
            {
                var baseType = str.BaseType;
                if (baseType is not null)
                {
                    if (baseType.Namespace == currentNs) return " : " + baseType.Name;
                    else return " : " + baseType.FullName;
                }
            }
            return string.Empty;
        }

        private string GetAnnotationPropertyValue(AnnotationProperty prop)
        {
            if (prop.Value == null)
            {
                return string.Empty;
            }
            if (prop.Value is string)
            {
                return "\"" + prop.Value + "\"";
            }
            else if (prop.Value is bool)
            {
                return prop.Value.ToString().ToLower();
            }
            else
            {
                return prop.Value.ToString();
            }
        }
    }
}
