﻿using CommandLine;
using CommandLine.Text;
using CommandLineParser = CommandLine.Parser;
using Donatello.Build;
using Donatello.Repl;
using Donatello.Services.Compilation;
using Donatello.Services.Parser;
using Donatello.Services.Util;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Donatello
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var options = new CommandLineOptions();

            if (!CommandLineParser.Default.ParseArguments(args, options))
            {
                Console.WriteLine(options.GetUsage());
                return;
            }

            if(options.Inputs.Any())
            {
                FileBuilder.CompileFile(options.Inputs.ToArray(), options.References.ToArray(), options.Output);
                return;
            }

            new ReadEvalPrintLoop()
                .RunAsync()
                .Wait();
        }

        /// <summary>
        /// Run the provided donatello program and return the result.
        /// </summary>
        /// <typeparam name="T">The expected return type</typeparam>
        /// <param name="program">The donatello source code</param>
        /// <returns>the return value of the program</returns>
        public static T Run<T>(string program)
        {
            const string namespaceName = "DonatelloRun";
            const string className = "Runner";
            const string methodName = "Run";

            var result = AntlrParser.ParseAsClass(program, namespaceName, className, methodName) as CompilationUnitSyntax;
            var bytes = Compiler.Compile(namespaceName, new string[0], OutputType.DynamicallyLinkedLibrary, result);

            return AssemblyRunner.Run<T>(bytes, namespaceName, className, methodName);
        }

        /// <summary>
        /// Command line flag schema
        /// </summary>
        private class CommandLineOptions
        {
            [OptionList('i', "input", HelpText = "A list of input files")]
            public IList<string> Inputs { get; set; } = new List<string>();

            [Option('o', "output", DefaultValue = "Out.exe", HelpText = "The output DLL name")]
            public string Output { get; set; }

            [OptionList('r', "references", HelpText = "The DLLs to reference")]
            public IList<string> References { get; set; } = new List<string>();

            [HelpOption]
            public string GetUsage()
            {
                return HelpText.AutoBuild(this,
                    current => HelpText.DefaultParsingErrorsHandler(this, current));
            }
        }
    }
}
