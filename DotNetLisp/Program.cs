﻿using CommandLine;
using CommandLine.Text;
using DotNetLisp.Compilation;
using DotNetLisp.Parser;
using DotNetLisp.Repl;
using DotNetLisp.Util;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DotNetLisp
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineOptions();

            if (!CommandLine.Parser.Default.ParseArguments(args, options))
            {
                Console.WriteLine(options.GetUsage());
                return;
            }

            if(options.Inputs.Any())
            {
                CompileFile(options.Inputs.ToArray(), options.Output);
                return;
            }

            var repl = new ReadEvalPrintLoop();
            repl.Run();
        }

        private static void CompileFile(string[] inputFile, string outputFilename)
        {
            var fileContent = (from file in inputFile
                               select new
                               {
                                   NamespaceName = Directory.GetParent(file).Name,
                                   ClassName = Path.GetFileNameWithoutExtension(file),
                                   Content = File.ReadAllText(file)
                               })
                              .ToDictionary(
                                    unit => Tuple.Create(unit.NamespaceName, unit.ClassName),
                                    unit => unit.Content);
            string assemblyName = Path.GetFileNameWithoutExtension(outputFilename);
            string extension = Path.GetExtension(outputFilename);
            var outputKind = extension == "dll" ? OutputType.DynamicallyLinkedLibrary :
                             extension == "exe" ? OutputType.ConsoleApplication :
                             Utility.Throw<OutputType>(new Exception("unknown extension"));
            var bytes = CompileContent(fileContent, assemblyName, outputKind);
            File.WriteAllBytes(outputFilename, bytes);
        }

        public static byte[] CompileContent(
            IDictionary<Tuple<string, string>, string> files,
            string assemblyName,
            OutputType outputKind)
        {
            var compilationUnit = files
                .Select(file => AntlrParser.Parse(file.Value, file.Key.Item1, file.Key.Item2))
                .ToArray();

            var assembly = Compiler.Compile(assemblyName, outputKind, compilationUnit);

            return assembly;
        }

        public static T Run<T>(string program)
        {
            const string namespaceName = "DotNetLispRun";
            const string className = "Runner";
            const string methodName = "Run";

            var result = AntlrParser.Parse(program, namespaceName, className, methodName);
            var bytes = Compiler.Compile(namespaceName, OutputType.DynamicallyLinkedLibrary, result);

            return AssemblyRunner.Run<T>(bytes, namespaceName, className, methodName);
        }

        private class CommandLineOptions
        {
            [OptionList('i', "input", HelpText = "A list of input files")]
            public IList<string> Inputs { get; set; } = new List<string>();

            [Option('o', "output", DefaultValue = "Out.dll", HelpText = "The output DLL name")]
            public string Output { get; set; }

            [HelpOption]
            public string GetUsage()
            {
                return HelpText.AutoBuild(this,
                  (HelpText current) => HelpText.DefaultParsingErrorsHandler(this, current));
            }
        }
    }
}
