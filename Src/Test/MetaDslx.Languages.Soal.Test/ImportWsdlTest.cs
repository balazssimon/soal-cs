using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MetaDslx.Languages.Soal;
using MetaDslx.Languages.Soal.Generator;
using Microsoft.CodeAnalysis;
using MetaDslx.Modeling;

namespace MetaDslx.Soal.Test
{
    [TestClass]
    public class ImportWsdlTest
    {
        private bool Test(int index)
        {
            bool result = false;
            string inputFileName = string.Format(@"..\..\InputFiles\wsdl\Wsdl{0:00}.Hello.wsdl", index);
            string expectedFileName = string.Format(@"..\..\ExpectedFiles\soal\Wsdl{0:00}.soal", index);
            string outputFileName = string.Format(@"..\..\OutputFiles\soal\Wsdl{0:00}.Hello.soal", index);
            string outputLogFileName = string.Format(@"..\..\OutputFiles\soal\Wsdl{0:00}.Hello.log", index);
            string outputDirectory = string.Format(@"..\..\OutputFiles\soal", index);
            DiagnosticBag diagnostics = new DiagnosticBag();
            ImmutableModel model = SoalImporter.Import(inputFileName, diagnostics);
            using (StreamWriter writer = new StreamWriter(outputLogFileName))
            {
                foreach (var msg in diagnostics.AsEnumerable())
                {
                    writer.WriteLine(msg);
                }
            }
            Assert.IsFalse(diagnostics.HasAnyErrors());
            Directory.CreateDirectory(outputDirectory);
            SoalPrinter printer = new SoalPrinter(model.Symbols);
            string outputSoal = printer.Generate();
            File.WriteAllText(outputFileName, outputSoal);
            string expectedSoal = null;
            using (StreamReader reader = new StreamReader(expectedFileName))
            {
                expectedSoal = reader.ReadToEnd();
            }
            int firstDiff = -1;
            int line = 1;
            int column = 1;
            int max = Math.Max(expectedSoal.Length, outputSoal.Length);
            for (int i = 0; i < max; i++)
            {
                if (expectedSoal[i] != outputSoal[i])
                {
                    firstDiff = i;
                    break;
                }
                ++column;
                if (expectedSoal[i] == '\n')
                {
                    ++line;
                    column = 1;
                }
            }
            Assert.AreEqual(expectedSoal, outputSoal);
            return result;
        }

        [TestMethod]
        public void TestImportWsdl01()
        {
            this.Test(1);
        }

        [TestMethod]
        public void TestImportWsdl02()
        {
            this.Test(2);
        }

        [TestMethod]
        public void TestImportWsdl03()
        {
            this.Test(3);
        }

        [TestMethod]
        public void TestImportWsdl04()
        {
            this.Test(4);
        }

    }
}
