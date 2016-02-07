using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MetaDslx.Soal.Test
{
    [TestClass]
    public class GenerateXsdTest
    {
        private bool Test(int index)
        {
            bool result = false;
            string inputFileName = string.Format(@"..\..\InputFiles\soal\Xsd{0:00}.soal", index);
            string expectedFileName = string.Format(@"..\..\ExpectedFiles\xsd\Xsd{0:00}.Hello.xsd", index);
            string outputFileName = string.Format(@"..\..\OutputFiles\xsd\Xsd{0:00}.Hello.xsd", index);
            string outputDirectory = string.Format(@"..\..\OutputFiles");
            string inputSoal = null;
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                inputSoal = reader.ReadToEnd();
            }
            SoalCompiler compiler = new SoalCompiler(inputSoal, inputFileName);
            compiler.Compile();
            Assert.IsFalse(compiler.Diagnostics.HasErrors());
            SoalGenerator generator = new SoalGenerator(compiler.Model, outputDirectory, compiler.Diagnostics, compiler.FileName);
            generator.SeparateXsdWsdl = true;
            generator.SingleFileWsdl = false;
            generator.Generate();
            string expectedXsd = null;
            using (StreamReader reader = new StreamReader(expectedFileName))
            {
                expectedXsd = reader.ReadToEnd();
            }
            string outputXsd = null;
            using (StreamReader reader = new StreamReader(outputFileName))
            {
                outputXsd = reader.ReadToEnd();
            }
            Assert.AreEqual(expectedXsd, outputXsd);
            return result;
        }

        [TestMethod]
        public void TestGenerateXsd01()
        {
            this.Test(1);
        }

        [TestMethod]
        public void TestGenerateXsd02()
        {
            this.Test(2);
        }

        [TestMethod]
        public void TestGenerateXsd03()
        {
            this.Test(3);
        }

        [TestMethod]
        public void TestGenerateXsd04()
        {
            this.Test(4);
        }

        [TestMethod]
        public void TestGenerateXsd05()
        {
            this.Test(5);
        }

        [TestMethod]
        public void TestGenerateXsd06()
        {
            this.Test(6);
        }

        [TestMethod]
        public void TestGenerateXsd07()
        {
            this.Test(7);
        }

        [TestMethod]
        public void TestGenerateXsd08()
        {
            this.Test(8);
        }

        [TestMethod]
        public void TestGenerateXsd09()
        {
            this.Test(9);
        }

        [TestMethod]
        public void TestGenerateXsd10()
        {
            this.Test(10);
        }

        [TestMethod]
        public void TestGenerateXsd11()
        {
            this.Test(11);
        }

        [TestMethod]
        public void TestGenerateXsd12()
        {
            this.Test(12);
        }

        [TestMethod]
        public void TestGenerateXsd13()
        {
            this.Test(13);
        }

        [TestMethod]
        public void TestGenerateXsd14()
        {
            this.Test(14);
        }

        [TestMethod]
        public void TestGenerateXsd15()
        {
            this.Test(15);
        }

        [TestMethod]
        public void TestGenerateXsd16()
        {
            this.Test(16);
        }

        [TestMethod]
        public void TestGenerateXsd17()
        {
            this.Test(17);
        }

        [TestMethod]
        public void TestGenerateXsd18()
        {
            this.Test(18);
        }
    }
}
