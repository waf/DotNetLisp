﻿using Donatello.Services.Compilation;
using Donatello.Services.Parser;
using Donatello.Services.Util;
using Donatello.StandardLibrary;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Donatello.Repl
{
    public class ReadEvalPrintLoop
    {
        public async Task RunAsync()
        {
            var initialState = Task.Run(InitialEvaluationAsync).ConfigureAwait(false);
            DrawBanner();
            ScriptState<object> state = null;
            while (true)
            {
                //read!
                Console.Write("> ");
                string text = Console.ReadLine()?.Trim(); // null if ctrl-c
                if (text == string.Empty) { continue; }
                if (text == "exit" || text == null) { break; }

                try
                {
                    // eval!
                    // convert to roslyn tree
                    var program = AntlrParser.ParseAsRepl(text)
                        .NormalizeWhitespace()
                        .ToFullString();
                    // pass roslyn tree to scripting api
                    state = await (state ?? await initialState)
                        .ContinueWithAsync(program) // roslyn scripting api - continue program with existing instance state
                        .ConfigureAwait(false); // TPL api

                    // print!
                    ReplPrinter.Print(state.ReturnValue);
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine("Error: " + e.Message);
                    if(Debugger.IsAttached)
                    {
                        Console.Error.WriteLine(e.StackTrace);
                    }
                }
            } // loop!
        }

        private static void DrawBanner()
        {
            Console.WriteLine("Welcome to the Donatello REPL. Try typing (+ 2 2) or type 'exit' to leave.");
            Console.WriteLine("For more, see https://github.com/waf/Donatello/blob/master/Readme.md");
            Console.WriteLine();
        }

        /// <summary>
        /// Initial REPL setup and warmup
        /// </summary>
        private async static Task<ScriptState<object>> InitialEvaluationAsync()
        {
            // import required libraries
            var usings = Compiler.DefaultImports.Keys
                .Select(ns => $"using {ns};")
                .StringJoin(" ");
            var references = ScriptOptions.Default.WithReferences(Compiler.GetDefaultReferences());
            var state = await CSharpScript.RunAsync(usings, references).ConfigureAwait(false);

            // do a first run to "warm up" the repl so the user doesn't experience a delay for the first evaluation.
            var warmup = AntlrParser.ParseAsRepl(@"(+ 30 12)")
                .NormalizeWhitespace()
                .ToFullString();
            return await state.ContinueWithAsync(warmup).ConfigureAwait(false);
        }
    }
}
