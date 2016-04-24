using MetaDslx.Core;
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
                    if (!compiler.Diagnostics.HasErrors())
                    {
                        Model model = compiler.Model;
                        GenJpaInterface(model);
                        /*SoalGenerator generator = new SoalGenerator(compiler.Model, outputDirectory, compiler.Diagnostics, compiler.FileName);
                        generator.SeparateXsdWsdl = separateXsdWsdl;
                        generator.SingleFileWsdl = singleFileWsdl;
                        generator.Generate();*/
                        SoalPrinter printer = new SoalPrinter(compiler.Model.Instances);
                        using (StreamWriter writer = new StreamWriter(fileName+"0"))
                        {
                            writer.WriteLine(printer.Generate());
                        }
                    }
                    foreach (var msg in compiler.Diagnostics.GetMessages(true))
                    {
                        Console.WriteLine(msg);
                    }
                }
            }
            catch(System.Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private static void GenJpaInterface(Model model)
        {
            foreach (Component comp in model.CachedInstances.OfType<Component>().ToList())
            {
                foreach (Database db in comp.Ports.Where(r => r is Service && r.Interface is Database).Select(r => r.Interface).OfType<Database>().ToList())
                {
                    using (new ModelContextScope(model))
                    {
                        foreach (Struct entity in db.Entities)
                        {
                            SoalFactory f = SoalFactory.Instance;
                            Interface repository = f.CreateInterface();
                            repository.Name = entity.Name + "Repository";
                            Service repoServ = f.CreateService();
                            repoServ.OptionalName = "asd"; //							FIXME (read only)
                            repoServ.Interface = repository;
                            repository.Namespace = comp.Namespace;
                            comp.Services.Add(repoServ);

                            // Operations ...
                            {
                                // count()
                                Operation op = f.CreateOperation();
                                op.Name = "count";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Void;
                                repository.Operations.Add(op);
                            }
                            {
                                // delete(id);
                                Operation op = f.CreateOperation();
                                op.Name = "delete";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Void;
                                InputParameter param = f.CreateInputParameter();
                                param.Type = SoalInstance.Long;
                                param.Name = "id";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                            {
                                // delete(entity);
                                Operation op = f.CreateOperation();
                                op.Name = "delete";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Void;
                                InputParameter param = f.CreateInputParameter();
                                param.Type = entity;
                                param.Name = "entity";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                            {
                                // delete(entities);
                                Operation op = f.CreateOperation();
                                op.Name = "delete";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Void;
                                InputParameter param = f.CreateInputParameter();
                                ArrayType array = f.CreateArrayType();
                                array.InnerType = entity;
                                param.Type = array;
                                param.Name = "entities";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                            {
                                // deleteAll();
                                Operation op = f.CreateOperation();
                                op.Name = "deleteAll";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Void;
                                repository.Operations.Add(op);
                            }
                            {
                                // exists(id);
                                Operation op = f.CreateOperation();
                                op.Name = "exists";
                                op.Action = "count";
                                op.Result.Type = SoalInstance.Bool;
                                InputParameter param = f.CreateInputParameter();
                                param.Type = SoalInstance.Long;
                                op.Parameters.Add(param);
                                param.Name = "id";
                                repository.Operations.Add(op);
                            }
                            {
                                // findAll();
                                Operation op = f.CreateOperation();
                                op.Name = "findAll";
                                op.Action = "count";
                                ArrayType array = f.CreateArrayType();
                                array.InnerType = entity;
                                op.Result.Type = array;
                                repository.Operations.Add(op);
                            }
                            {
                                // findAll(ids);
                                Operation op = f.CreateOperation();
                                op.Name = "findAll";
                                op.Action = "count";
                                ArrayType array = f.CreateArrayType();
                                array.InnerType = entity;
                                op.Result.Type = array;
                                InputParameter param = f.CreateInputParameter();
                                ArrayType array2 = f.CreateArrayType();
                                array2.InnerType = SoalInstance.Long;
                                param.Type = array2;
                                param.Name = "ids";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                            {
                                // findOne(id);
                                Operation op = f.CreateOperation();
                                op.Name = "findOne";
                                op.Action = "count";
                                op.Result.Type = entity;
                                InputParameter param = f.CreateInputParameter();
                                param.Type = SoalInstance.Long;
                                param.Name = "id";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                            {
                                // save(entity);
                                Operation op = f.CreateOperation();
                                op.Name = "save";
                                op.Action = "count";
                                op.Result.Type = entity;
                                InputParameter param = f.CreateInputParameter();
                                param.Type = entity;
                                param.Name = "entity";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                            {
                                // save(entities);
                                Operation op = f.CreateOperation();
                                op.Name = "save";
                                op.Action = "count";
                                ArrayType array = f.CreateArrayType();
                                array.InnerType = entity;
                                op.Result.Type = array;
                                InputParameter param = f.CreateInputParameter();
                                ArrayType array2 = f.CreateArrayType();
                                array2.InnerType = entity;
                                param.Type = array2;
                                param.Name = "entities";
                                op.Parameters.Add(param);
                                repository.Operations.Add(op);
                            }
                        }
                    }
                }
            }
        }
    }
}
