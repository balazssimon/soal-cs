using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalCompiler : SoalCompilerBase
    {
        public SoalCompiler(string source, string outputDirectory, string fileName)
            : base(source, outputDirectory, fileName)
        {
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Object);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.String);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Int);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Long);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Float);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Double);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Byte);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Bool);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.Void);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.DateTime);
            this.GlobalScope.BuiltInEntries.Add((ModelObject)SoalInstance.TimeSpan);
        }

        protected override void DoCompile()
        {
            base.DoCompile();
            if (!this.Diagnostics.HasErrors())
            {
                this.Generate();
            }
        }

        private void Generate()
        {
            string xsdDirectory = Path.Combine(this.OutputDirectory, "xsd");
            Directory.CreateDirectory(xsdDirectory);
            string wsdlDirectory = Path.Combine(this.OutputDirectory, "wsdl");
            Directory.CreateDirectory(wsdlDirectory);

            var namespaces = this.Data.GetSymbols().OfType<Namespace>().ToList();
            foreach (var ns in namespaces)
            {
                if (ns.Uri != null)
                {
                    string xsdFileName = Path.Combine(xsdDirectory, ns.FullName + ".xsd");
                    using (StreamWriter writer = new StreamWriter(xsdFileName))
                    {
                        XsdGenerator xsdGen = new XsdGenerator(ns);
                        writer.WriteLine(xsdGen.Generate());
                    }
                    string wsdlFileName = Path.Combine(wsdlDirectory, ns.FullName + ".wsdl");
                    using (StreamWriter writer = new StreamWriter(wsdlFileName))
                    {
                        WsdlGenerator wsdlGen = new WsdlGenerator(ns);
                        writer.WriteLine(wsdlGen.Generate());
                    }
                }
            }
        }
    }
}
