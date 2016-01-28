using MetaDslx.Soal;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soal
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = null;
                string outputDirectory = null;
                bool separateXsdWsdl = false;
                bool singleFileWsdl = false;
                for (int i = 0; i < args.Length; i++)
                {
                    if (args[i].StartsWith("-"))
                    {
                        if (args[i] == "-separateXsdWsdl")
                        {
                            separateXsdWsdl = true;
                        }
                        else if (args[i] == "-singleFileWsdl")
                        {
                            singleFileWsdl = true;
                        }
                        else if (i + 1 < args.Length)
                        {
                            if (args[i] == "-o")
                            {
                                outputDirectory = args[++i];
                            }
                            else 
                            {
                                Console.WriteLine("Unknown option: '"+args[i]+"'");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Unknown option: '" + args[i] + "'");
                        }
                    }
                    else
                    {
                        fileName = args[i];
                    }
                }
                if (fileName == null)
                {
                    Console.WriteLine("Usage:");
                    Console.WriteLine("  Soal.exe [options] [input.soal]");
                    Console.WriteLine("Options:");
                    Console.WriteLine("  -o [dir]: output directory");
                    Console.WriteLine("  -separateXsdWsdl: separate XSD and WSDL files into different directories");
                    Console.WriteLine("  -singleFileWsdl: include XSD code into the WSDL");
                    return;
                }
                if (outputDirectory == null)
                {
                    outputDirectory = Directory.GetCurrentDirectory();
                }
                if (!File.Exists(fileName))
                {
                    Console.WriteLine("Could not find file: "+fileName);
                    return;
                }
                if (singleFileWsdl && separateXsdWsdl)
                {
                    Console.WriteLine("Warning: conflicting options '-separateXsdWsdl' and '-singleFileWsdl'. '-singleFileWsdl' will be used.");
                }
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string source = reader.ReadToEnd();
                    SoalCompiler compiler = new SoalCompiler(source, Path.GetFileName(fileName));
                    compiler.Compile();
                    foreach (var msg in compiler.Diagnostics.GetMessages(true))
                    {
                        Console.WriteLine(msg);
                    }
                    if (!compiler.Diagnostics.HasErrors())
                    {
                        SoalGenerator generator = new SoalGenerator(compiler.Model, outputDirectory, compiler.Diagnostics, compiler.FileName);
                        generator.SeparateXsdWsdl = separateXsdWsdl;
                        generator.SingleFileWsdl = singleFileWsdl;
                        generator.Generate();
                        SoalPrinter printer = new SoalPrinter(compiler.Model.Instances);
                        using (StreamWriter writer = new StreamWriter(fileName+"0"))
                        {
                            writer.WriteLine(printer.Generate());
                        }
                    }
                }
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
