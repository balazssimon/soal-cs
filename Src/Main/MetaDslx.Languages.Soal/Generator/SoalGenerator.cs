using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.Soal.Symbols;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.Soal
{
    public class SoalGenerator
    {
        public static Namespace XsdNamespace { get; private set; }

        static SoalGenerator()
        {
            var xsdModel = new Model("xmlschema");
            var f = new SoalModelFactory(xsdModel);
            var xsNs = f.Namespace();
            xsNs.Prefix = "xs";
            xsNs.Uri = "http://www.w3.org/2001/XMLSchema";
            XsdNamespace = xsNs;
        }
    }
}
