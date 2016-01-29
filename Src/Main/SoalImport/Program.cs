using MetaDslx.Core;
using MetaDslx.Soal;
using System;
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
                Model model = new Model();
                using (ModelContextScope scope = new ModelContextScope(model))
                {
                    SoalImporter.Import(inputFileName);
                    foreach (var msg in ModelCompilerContext.Current.Diagnostics.GetMessages(true))
                    {
                        Console.WriteLine(msg);
                    }
                    SoalPrinter printer = new SoalPrinter(model.Instances);
                    using (StreamWriter writer = new StreamWriter(outputFileName))
                    {
                        writer.WriteLine(printer.Generate());
                    }
                }
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
