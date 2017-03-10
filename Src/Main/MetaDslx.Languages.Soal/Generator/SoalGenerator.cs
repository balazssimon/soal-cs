using MetaDslx.Compiler.Diagnostics;
using MetaDslx.Compiler.Symbols;
using MetaDslx.Compiler.Syntax;
using MetaDslx.Core;
using MetaDslx.Languages.Soal.Generator;
using MetaDslx.Languages.Soal.Symbols;
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
            MutableModel xsdModel = new MutableModel("xmlschema");
            SoalFactory f = new SoalFactory(xsdModel);
            var xsNs = f.Namespace();
            xsNs.Prefix = "xs";
            xsNs.Uri = "http://www.w3.org/2001/XMLSchema";
            XsdNamespace = xsNs.ToImmutable();
        }


        public SoalGenerator(ImmutableModel model, string outputDirectory, DiagnosticBag diagnostics, string fileName)
        {
            this.FileName = fileName;
            this.OutputDirectory = outputDirectory;
            this.diagnostics = diagnostics;
            this.SeparateXsdWsdl = false;
            this.SingleFileWsdl = false;
            this.modelBuilder = model.ToMutable(true);
        }

        private DiagnosticBag diagnostics;
        private MutableModel modelBuilder;
        public string FileName { get; private set; }
        public string OutputDirectory { get; private set; }
        public ImmutableModel Model { get; private set; }
        public bool SeparateXsdWsdl { get; set; }
        public bool SingleFileWsdl { get; set; }

        private void AddDiagnostic(ISymbol symbol, ErrorCode errorCode, params object[] args)
        {
            ImmutableArray<SyntaxReference> references = (ImmutableArray<SyntaxReference>)symbol.MGet(CompilerAttachedProperties.DeclaringSyntaxReferencesProperty);
            foreach (var reference in references)
            {
                this.diagnostics.Add(reference.GetLocation(), SoalGeneratorErrorCode.XsdTypeDefinedMultipleTimes, args);
            }
        }

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
            var namespaceBuilders = this.modelBuilder.Symbols.OfType<NamespaceBuilder>().ToList();
            foreach (var ns in namespaceBuilders)
            {
                if (ns.Uri != null)
                {
                    if (ns.Prefix == null || prefixes.Contains(ns.Prefix))
                    {
                        while (prefixes.Contains("ns" + prefixCounter)) ++prefixCounter;
                        ns.Prefix = "ns" + prefixCounter;
                    }
                }
            }
            this.Model = this.modelBuilder.ToImmutable();
            var namespaces = this.Model.Symbols.OfType<Namespace>().ToList();
            foreach (var ns in namespaces)
            {
                Dictionary<string, List<ISymbol>> typeNames = new Dictionary<string, List<ISymbol>>();
                if (ns.Uri != null)
                {
                    foreach (var decl in ns.Declarations)
                    {
                        Interface intf = decl as Interface;
                        if (intf != null && !intf.HasAnnotation(SoalAnnotations.NoWrap) && !intf.HasAnnotation(SoalAnnotations.Rpc))
                        {
                            foreach (var op in intf.Operations)
                            {
                                string key = op.Name;
                                List<ISymbol> symbols = null;
                                if (!typeNames.TryGetValue(key, out symbols))
                                {
                                    symbols = new List<ISymbol>();
                                    typeNames.Add(key, symbols);
                                }
                                symbols.Add((ISymbol)op);
                                key = op.Name + "Response";
                                symbols = null;
                                if (!typeNames.TryGetValue(key, out symbols))
                                {
                                    symbols = new List<ISymbol>();
                                    typeNames.Add(key, symbols);
                                }
                                symbols.Add((ISymbol)op);
                            }
                        }
                        Struct stype = decl as Struct;
                        if (stype != null)
                        {
                            string key = stype.GetXsdName();
                            List<ISymbol> symbols = null;
                            if (!typeNames.TryGetValue(key, out symbols))
                            {
                                symbols = new List<ISymbol>();
                                typeNames.Add(key, symbols);
                            }
                            symbols.Add((ISymbol)stype);
                        }
                        Symbols.Enum etype = decl as Symbols.Enum;
                        if (etype != null)
                        {
                            string key = etype.GetXsdName();
                            List<ISymbol> symbols = null;
                            if (!typeNames.TryGetValue(key, out symbols))
                            {
                                symbols = new List<ISymbol>();
                                typeNames.Add(key, symbols);
                            }
                            symbols.Add((ISymbol)etype);
                        }
                    }
                    foreach (var key in typeNames.Keys)
                    {
                        List<ISymbol> symbols = typeNames[key];
                        if (symbols.Count > 1)
                        {
                            foreach (var symbol in symbols)
                            {
                                this.AddDiagnostic(symbol, SoalGeneratorErrorCode.XsdTypeDefinedMultipleTimes, key);
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
                                this.CheckXsdNamespace(op.Result.Type, (ISymbol)op);
                                foreach (var param in op.Parameters)
                                {
                                    this.CheckXsdNamespace(param.Type, (ISymbol)param);
                                }
                            }
                        }
                        Struct stype = decl as Struct;
                        if (stype != null)
                        {
                            foreach (var prop in stype.Properties)
                            {
                                this.CheckXsdNamespace(prop.Type, (ISymbol)prop);
                            }
                        }
                    }
                }
            }
        }

        private void CheckXsdNamespace(SoalType type, ISymbol symbol)
        {
            if (!type.HasXsdNamespace())
            {
                this.AddDiagnostic(symbol, SoalGeneratorErrorCode.TypeHasNoXsdNamespace);
            }
        }

        public void Generate()
        {
            this.PrepareGeneration();
            if (this.diagnostics.HasAnyErrors()) return;
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

            var namespaces = this.Model.Symbols.OfType<Namespace>().Where(ns => ns.Uri != null).ToList();
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
