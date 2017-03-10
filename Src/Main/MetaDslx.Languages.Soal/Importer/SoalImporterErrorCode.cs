using MetaDslx.Compiler.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.Soal.Importer
{
    public class SoalImporterErrorCode : ErrorCode
    {
        public const string SoalImporterCategory = "SoalImporter";

        public static readonly SoalImporterErrorCode Error = new SoalImporterErrorCode(1, DiagnosticSeverity.Error, 0, "{0}");
        public static readonly SoalImporterErrorCode Warning = new SoalImporterErrorCode(2, DiagnosticSeverity.Warning, 1, "{0}");
        public static readonly SoalImporterErrorCode Info = new SoalImporterErrorCode(3, DiagnosticSeverity.Info, -1, "{0}");

        public SoalImporterErrorCode(int id, DiagnosticSeverity defaultSeverity, int warningLevel, string defaultMessage) 
            : base(SoalImporterCategory, id, defaultSeverity, warningLevel, defaultMessage)
        {
        }
    }
}
