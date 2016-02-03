using MetaDslx.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Soal
{
    public class SoalGenerator
    {
        public static Namespace XsdNamespace { get; private set; }
        static SoalGenerator()
        {
            XsdNamespace = SoalFactory.Instance.CreateNamespace();
            XsdNamespace.Prefix = "xs";
            XsdNamespace.Uri = "http://www.w3.org/2001/XMLSchema";
        }


        public SoalGenerator(Model model, string outputDirectory, ModelCompilerDiagnostics diagnostics, string fileName)
        {
            this.FileName = fileName;
            this.OutputDirectory = outputDirectory;
            this.Model = model;
            this.Diagnostics = diagnostics;
            this.SeparateXsdWsdl = false;
            this.SingleFileWsdl = false;
        }

        public string FileName { get; private set; }
        public string OutputDirectory { get; private set; }
        public ModelCompilerDiagnostics Diagnostics { get; private set; }
        public Model Model { get; private set; }
        public bool SeparateXsdWsdl { get; set; }
        public bool SingleFileWsdl { get; set; }

        private void PrepareGeneration()
        {
            HashSet<string> prefixes = new HashSet<string>();
            prefixes.Add("xs");
            prefixes.Add("wsdl");
            prefixes.Add("soap");
            prefixes.Add("soap12");
            prefixes.Add("wsp");
            prefixes.Add("wsu");
            prefixes.Add("wsoma");
            prefixes.Add("wsam");
            prefixes.Add("wsaw");
            prefixes.Add("wsrmp");
            prefixes.Add("wsat");
            prefixes.Add("sp");
            prefixes.Add("wst");
            prefixes.Add("wsx");
            int prefixCounter = 0;
            var namespaces = this.Model.Instances.OfType<Namespace>().ToList();
            foreach (var ns in namespaces)
            {
                Dictionary<string, List<ModelObject>> typeNames = new Dictionary<string, List<ModelObject>>();
                if (ns.Uri != null)
                {
                    if (ns.Prefix == null || prefixes.Contains(ns.Prefix))
                    {
                        while (prefixes.Contains("ns" + prefixCounter)) ++prefixCounter;
                        ns.Prefix = "ns" + prefixCounter;
                    }
                    foreach (var decl in ns.Declarations)
                    {
                        Interface intf = decl as Interface;
                        if (intf != null && !intf.HasAnnotation(SoalAnnotations.NoWrap) && !intf.HasAnnotation(SoalAnnotations.Rpc))
                        {
                            foreach (var op in intf.Operations)
                            {
                                string key = op.Name;
                                List<ModelObject> symbols = null;
                                if (!typeNames.TryGetValue(key, out symbols))
                                {
                                    symbols = new List<ModelObject>();
                                    typeNames.Add(key, symbols);
                                }
                                symbols.Add((ModelObject)op);
                                key = op.Name + "Response";
                                symbols = null;
                                if (!typeNames.TryGetValue(key, out symbols))
                                {
                                    symbols = new List<ModelObject>();
                                    typeNames.Add(key, symbols);
                                }
                                symbols.Add((ModelObject)op);
                            }
                        }
                        StructuredType stype = decl as StructuredType;
                        if (stype != null)
                        {
                            string key = stype.GetXsdName();
                            List<ModelObject> symbols = null;
                            if (!typeNames.TryGetValue(key, out symbols))
                            {
                                symbols = new List<ModelObject>();
                                typeNames.Add(key, symbols);
                            }
                            symbols.Add((ModelObject)stype);
                        }
                        Enum etype = decl as Enum;
                        if (etype != null)
                        {
                            string key = etype.GetXsdName();
                            List<ModelObject> symbols = null;
                            if (!typeNames.TryGetValue(key, out symbols))
                            {
                                symbols = new List<ModelObject>();
                                typeNames.Add(key, symbols);
                            }
                            symbols.Add((ModelObject)etype);
                        }
                    }
                    foreach (var key in typeNames.Keys)
                    {
                        List<ModelObject> symbols = typeNames[key];
                        if (symbols.Count > 1)
                        {
                            foreach (var symbol in symbols)
                            {
                                this.Diagnostics.AddError("XSD type named '" + key + "' is defined multiple times.", this.FileName, symbol);
                            }
                        }
                    }
                }
            }
            foreach (var ns in namespaces)
            {
                if (ns.Uri != null)
                {
                    foreach (var decl in ns.Declarations)
                    {
                        Interface intf = decl as Interface;
                        if (intf != null)
                        {
                            foreach (var op in intf.Operations)
                            {
                                this.CheckXsdNamespace(op.ReturnType, (ModelObject)op);
                                foreach (var param in op.Parameters)
                                {
                                    this.CheckXsdNamespace(param.Type, (ModelObject)param);
                                }
                            }
                        }
                        StructuredType stype = decl as StructuredType;
                        if (stype != null)
                        {
                            foreach (var prop in stype.Properties)
                            {
                                this.CheckXsdNamespace(prop.Type, (ModelObject)prop);
                            }
                        }
                    }
                }
            }
        }

        private void CheckXsdNamespace(SoalType type, ModelObject symbol)
        {
            if (!type.HasXsdNamespace())
            {
                this.Diagnostics.AddError("The type of this element has no XSD namespace.", this.FileName, symbol);
            }
        }

        public void Generate()
        {
            this.PrepareGeneration();
            if (this.Diagnostics.HasErrors()) return;
            if (this.SingleFileWsdl)
            {
                this.SeparateXsdWsdl = false;
            }
            string xsdDirectory = Path.Combine(this.OutputDirectory, "xsd");
            string wsdlDirectory = Path.Combine(this.OutputDirectory, "wsdl");
            if (this.SeparateXsdWsdl)
            {
                Directory.CreateDirectory(xsdDirectory);
            }
            else
            {
                xsdDirectory = wsdlDirectory;
            }
            Directory.CreateDirectory(wsdlDirectory);

            var namespaces = this.Model.Instances.OfType<Namespace>().ToList();
            foreach (var ns in namespaces)
            {
                if (ns.Uri != null)
                {
                    if (!this.SingleFileWsdl)
                    {
                        string xsdFileName = Path.Combine(xsdDirectory, ns.FullName + ".xsd");
                        using (StreamWriter writer = new StreamWriter(xsdFileName))
                        {
                            XsdGenerator xsdGen = new XsdGenerator(ns);
                            writer.WriteLine(xsdGen.Generate(ns));
                        }
                    }
                    string wsdlFileName = Path.Combine(wsdlDirectory, ns.FullName + ".wsdl");
                    using (StreamWriter writer = new StreamWriter(wsdlFileName))
                    {
                        WsdlGenerator wsdlGen = new WsdlGenerator(ns);
                        wsdlGen.Properties.SingleFileWsdl = this.SingleFileWsdl;
                        wsdlGen.Properties.SeparateXsdWsdl = this.SeparateXsdWsdl;
                        writer.WriteLine(wsdlGen.Generate(ns));
                    }
                }
            }
        }

    }
}
