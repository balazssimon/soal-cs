using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace MetaDslx.Soal.Test
{
    [TestClass]
    public class XsdTest
    {
        private bool Test(int index)
        {
            bool result = false;
            string inputFileName = string.Format(@"..\..\InputFiles\Xsd{0:00}.soal", index);
            string expectedFileName = string.Format(@"..\..\ExpectedFiles\wsdl\Xsd{0:00}.Hello.xsd", index);
            string outputFileName = string.Format(@"..\..\OutputFiles\wsdl\Xsd{0:00}.Hello.xsd", index);
            string outputDirectory = string.Format(@"..\..\OutputFiles");
            string inputSoal = null;
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                inputSoal = reader.ReadToEnd();
            }
            string expectedXsd = null;
            using (StreamReader reader = new StreamReader(expectedFileName))
            {
                expectedXsd = reader.ReadToEnd();
            }
            SoalCompiler compiler = new SoalCompiler(inputSoal, inputFileName);
            compiler.Compile();
            Assert.IsFalse(compiler.Diagnostics.HasErrors());
            SoalGenerator generator = new SoalGenerator(compiler.Model, outputDirectory, compiler.Diagnostics, compiler.FileName);
            generator.SeparateXsdWsdl = false;
            generator.SingleFileWsdl = false;
            generator.Generate();
            string outputXsd = null;
            using (StreamReader reader = new StreamReader(outputFileName))
            {
                outputXsd = reader.ReadToEnd();
            }
            Assert.AreEqual(expectedXsd, outputXsd);
            return result;
        }

        [TestMethod]
        public void TestXsd01()
        {
            this.Test(1);
        }

        [TestMethod]
        public void TestXsd02()
        {
            this.Test(2);
        }

        [TestMethod]
        public void TestXsd03()
        {
            this.Test(3);
        }

        [TestMethod]
        public void TestXsd04()
        {
            this.Test(4);
        }

        [TestMethod]
        public void TestXsd05()
        {
            this.Test(5);
        }

        [TestMethod]
        public void TestXsd06()
        {
            this.Test(6);
        }

        [TestMethod]
        public void TestXsd07()
        {
            this.Test(7);
        }

        [TestMethod]
        public void TestXsd08()
        {
            this.Test(8);
        }

        [TestMethod]
        public void TestXsd09()
        {
            this.Test(9);
        }

        [TestMethod]
        public void TestXsd10()
        {
            this.Test(10);
        }

        [TestMethod]
        public void TestXsd11()
        {
            this.Test(11);
        }

        [TestMethod]
        public void TestXsd12()
        {
            this.Test(12);
        }

        [TestMethod]
        public void TestXsd13()
        {
            this.Test(13);
        }

        [TestMethod]
        public void TestXsd14()
        {
            this.Test(14);
        }

        [TestMethod]
        public void TestXsd15()
        {
            this.Test(15);
        }

        [TestMethod]
        public void TestXsd16()
        {
            this.Test(16);
        }

        [TestMethod]
        public void TestXsd17()
        {
            this.Test(17);
        }

        [TestMethod]
        public void TestXsd18()
        {
            this.Test(18);
        }
    }
}
