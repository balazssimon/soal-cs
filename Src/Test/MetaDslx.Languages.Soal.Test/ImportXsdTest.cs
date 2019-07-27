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
    public class ImportXsdTest
    {
        private bool Test(int index)
        {
            bool result = false;
            string inputFileName = string.Format(@"..\..\InputFiles\xsd\Xsd{0:00}.Hello.xsd", index);
            string expectedFileName = string.Format(@"..\..\ExpectedFiles\soal\Xsd{0:00}.soal", index);
            string outputFileName = string.Format(@"..\..\OutputFiles\soal\Xsd{0:00}.Hello.soal", index);
            string outputLogFileName = string.Format(@"..\..\OutputFiles\soal\Xsd{0:00}.Hello.log", index);
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
            Assert.AreEqual(expectedSoal, outputSoal);
            return result;
        }


        [TestMethod]
        public void TestImportXsd01()
        {
            this.Test(1);
        }

        [TestMethod]
        public void TestImportXsd02()
        {
            this.Test(2);
        }

        [TestMethod]
        public void TestImportXsd03()
        {
            this.Test(3);
        }

        [TestMethod]
        public void TestImportXsd04()
        {
            this.Test(4);
        }

        [TestMethod]
        public void TestImportXsd05()
        {
            this.Test(5);
        }

        [TestMethod]
        public void TestImportXsd06()
        {
            this.Test(6);
        }

        [TestMethod]
        public void TestImportXsd07()
        {
            this.Test(7);
        }

        [TestMethod]
        public void TestImportXsd08()
        {
            this.Test(8);
        }

        [TestMethod]
        public void TestImportXsd09()
        {
            this.Test(9);
        }

        [TestMethod]
        public void TestImportXsd10()
        {
            this.Test(10);
        }

        [TestMethod]
        public void TestImportXsd11()
        {
            this.Test(11);
        }

        [TestMethod]
        public void TestImportXsd12()
        {
            this.Test(12);
        }

        [TestMethod]
        public void TestImportXsd13()
        {
            this.Test(13);
        }

        [TestMethod]
        public void TestImportXsd14()
        {
            this.Test(14);
        }

        [TestMethod]
        public void TestImportXsd15()
        {
            this.Test(15);
        }

        [TestMethod]
        public void TestImportXsd16()
        {
            this.Test(16);
        }

        [TestMethod]
        public void TestImportXsd17()
        {
            this.Test(17);
        }

        [TestMethod]
        public void TestImportXsd18()
        {
            this.Test(18);
        }

    }
}
