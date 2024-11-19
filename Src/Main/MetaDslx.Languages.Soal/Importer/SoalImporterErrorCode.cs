using MetaDslx.CodeAnalysis;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiagnosticDescriptor = MetaDslx.CodeAnalysis.DiagnosticDescriptor;

namespace MetaDslx.Languages.Soal.Importer
{
    public class SoalImporterErrorCode
    {
        public static readonly DiagnosticDescriptor ERR_SoalImport = DiagnosticDescriptor.Error(nameof(ERR_SoalImport), "Error", "{0}");
        public static readonly DiagnosticDescriptor WRN_SoalImport = DiagnosticDescriptor.Error(nameof(WRN_SoalImport), "Warning", "{0}");
        public static readonly DiagnosticDescriptor INF_SoalImport = DiagnosticDescriptor.Error(nameof(INF_SoalImport), "Info", "{0}");
    }
}
