using MetaDslx.CodeAnalysis;
using MetaDslx.Languages.MetaSymbols.Model;
using MetaDslx.Languages.Soal;
using MetaDslx.Languages.Soal.Generator;
using MetaDslx.Languages.Soal.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoalImport
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string inputFileName = null;
                string outputFileName = null;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                    {
                        if (i + 1 < args.Length)
                        {
                            if (args[i] == "-o")
                            {
                                outputFileName = args[++i];
                            }
                            else
                            {
                                Console.WriteLine("Unknown option: '" + args[i] + "'");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unknown option: '" + args[i] + "'");
                        }
                    }
                    else
                    {
                        inputFileName = args[i];
                    }
                }
                if (inputFileName == null)
                {
                    Console.WriteLine("Usage:");
                    Console.WriteLine("  SoalImport.exe [options] [input.wsdl or input.xsd]");
                    Console.WriteLine("Options:");
                    Console.WriteLine("  -o [output.soal]: output SOAL file");
                    return;
                }
                if (outputFileName == null)
                {
                    outputFileName = Path.ChangeExtension(inputFileName, ".soal");
                }
                if (!File.Exists(inputFileName))
                {
                    Console.WriteLine("Could not find file: " + inputFileName);
                    return;
                }
                var importDiagnostics = new DiagnosticBag();
                var model = SoalImporter.Import(inputFileName, importDiagnostics);
                foreach (var msg in importDiagnostics.AsEnumerable())
                {
                    Console.WriteLine(msg);
                }
                //if (!ModelCompilerContext.Current.Diagnostics.HasErrors())
                {
                    SoalPrinter printer = new SoalPrinter();
                    using (StreamWriter writer = new StreamWriter(outputFileName))
                    {
                        writer.WriteLine(printer.Generate(model.Objects.OfType<Namespace>()));
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        static void ExportPlantUml(Model model, string intfName, string opName)
        {
            var useful = KeepOnlyUseful(model.Objects, intfName, opName);
            var pug = new PlantUmlGenerator();
            var puDiagram = pug.Generate($"{opName}", useful);
            File.WriteAllText($"../../../{intfName}_{opName}.puml", puDiagram);
        }

        static List<IModelObject> KeepOnlyUseful(IEnumerable<IModelObject> objects, string intfName = null, string opName = null)
        {
            var ignore = new HashSet<string>() {  };
            var useful = new List<IModelObject>();
            useful.AddRange(objects.OfType<Interface>().Where(intf => intfName is null || intf.Name == intfName));
            var i = 0;
            while (i < useful.Count)
            {
                var mo = useful[i];
                if (mo is Interface intf)
                {
                    foreach (var op in intf.Operations.Where(o => opName is null || o.Name == opName))
                    {
                        foreach (var p in op.Parameters)
                        {
                            var t = p.Type?.GetCoreType();
                            if (t is not null && !useful.Contains(t)) useful.Add(t);
                        }
                        var rt = op.Result?.Type?.GetCoreType();
                        if (rt is not null && !useful.Contains(rt)) useful.Add(rt);
                        foreach (var ex in op.Exceptions)
                        {
                            if (!useful.Contains(ex)) useful.Add(ex);
                        }
                    }
                }
                else if (mo is Struct st)
                {
                    if (!ignore.Contains(st.Name))
                    {
                        var bt = st.BaseType;
                        if (bt is not null && !useful.Contains(bt)) useful.Add(bt);
                        foreach (var p in st.Properties)
                        {
                            var t = p.Type?.GetCoreType();
                            if (t is not null && !useful.Contains(t)) useful.Add(t);
                        }
                    }
                }
                ++i;
            }
            useful.RemoveAll(mo => mo is Struct str && ignore.Contains(str.Name));
            return useful;
            /*var structs = model.Objects.OfType<Struct>().ToList();
            foreach (var st in structs)
            {
                if (!useful.Contains(st)) model.DeleteObject(st);
            }
            var enums = model.Objects.OfType<MetaDslx.Languages.Soal.Symbols.Enum>().ToList();
            foreach (var enm in enums)
            {
                if (!useful.Contains(enm)) model.DeleteObject(enm);
            }*/
        }
    }
}
