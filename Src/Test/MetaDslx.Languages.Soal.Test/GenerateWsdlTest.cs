using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using MetaDslx.Languages.Soal.Syntax;
using MetaDslx.Languages.Soal;
using MetaDslx.Compiler;
using MetaDslx.Languages.Soal.Symbols;
using MetaDslx.Core;
using MetaDslx.Compiler.Diagnostics;

namespace MetaDslx.Soal.Test
{
    [TestClass]
    public class GenerateWsdlTest
    {
        private bool Test(int index)
        {
            bool result = false;
            string inputFileName = string.Format(@"..\..\InputFiles\soal\Wsdl{0:00}.soal", index);
            string expectedXsdFileName = string.Format(@"..\..\ExpectedFiles\xsd\Wsdl{0:00}.Hello.xsd", index);
            string outputXsdFileName = string.Format(@"..\..\OutputFiles\xsd\Wsdl{0:00}.Hello.xsd", index);
            string expectedWsdlFileName = string.Format(@"..\..\ExpectedFiles\wsdl\Wsdl{0:00}.Hello.wsdl", index);
            string outputWsdlFileName = string.Format(@"..\..\OutputFiles\wsdl\Wsdl{0:00}.Hello.wsdl", index);
            string outputDirectory = string.Format(@"..\..\OutputFiles");
            string inputSoal = null;
            using (StreamReader reader = new StreamReader(inputFileName))
            {
                inputSoal = reader.ReadToEnd();
            }
            SoalSyntaxTree syntaxTree = SoalSyntaxTree.ParseText(inputSoal);
            MetadataReference soalReference = MetadataReference.CreateFromModel(SoalInstance.Model);
            SoalCompilation compilation = SoalCompilation.Create("SoalTest").AddReferences(soalReference).AddSyntaxTrees(syntaxTree);
            ImmutableModel model = compilation.Model;
            Assert.IsFalse(compilation.GetDiagnostics().Any(d => d.Severity == Compiler.Diagnostics.DiagnosticSeverity.Error));
            DiagnosticBag generatorDiagnostics = new DiagnosticBag();
            SoalGenerator generator = new SoalGenerator(model, outputDirectory, generatorDiagnostics, inputFileName);
            generator.SeparateXsdWsdl = true;
            generator.SingleFileWsdl = false;
            generator.Generate();
            string expectedXsd = null;
            using (StreamReader reader = new StreamReader(expectedXsdFileName))
            {
                expectedXsd = reader.ReadToEnd();
            }
            string outputXsd = null;
            using (StreamReader reader = new StreamReader(outputXsdFileName))
            {
                outputXsd = reader.ReadToEnd();
            }
            Assert.AreEqual(expectedXsd, outputXsd);
            string expectedWsdl = null;
            using (StreamReader reader = new StreamReader(expectedWsdlFileName))
            {
                expectedWsdl = reader.ReadToEnd();
            }
            string outputWsdl = null;
            using (StreamReader reader = new StreamReader(outputWsdlFileName))
            {
                outputWsdl = reader.ReadToEnd();
            }
            Assert.AreEqual(expectedWsdl, outputWsdl);
            return result;
        }

        [TestMethod]
        public void TestGenerateWsdl01()
        {
            this.Test(1);
        }

        [TestMethod]
        public void TestGenerateWsdl02()
        {
            this.Test(2);
        }

        [TestMethod]
        public void TestGenerateWsdl03()
        {
            this.Test(3);
        }

        [TestMethod]
        public void TestGenerateWsdl04()
        {
            this.Test(4);
        }
    }
}
