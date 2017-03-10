using MetaDslx.Compiler.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.Soal.Generator
{
    public class SoalGeneratorErrorCode : ErrorCode
    {
        public const string SoalGeneratorCategory = "SoalGenerator";

        public static readonly SoalGeneratorErrorCode XsdTypeDefinedMultipleTimes = new SoalGeneratorErrorCode(1, DiagnosticSeverity.Error, 0, "XSD type named '{0}' is defined multiple times.");
        public static readonly SoalGeneratorErrorCode TypeHasNoXsdNamespace = new SoalGeneratorErrorCode(2, DiagnosticSeverity.Error, 0, "The type of this element has no XSD namespace.");

        public SoalGeneratorErrorCode(int id, DiagnosticSeverity defaultSeverity, int warningLevel, string defaultMessage) 
            : base(SoalGeneratorCategory, id, defaultSeverity, warningLevel, defaultMessage)
        {
        }
    }
}
