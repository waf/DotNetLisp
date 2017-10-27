//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Donatello.g4 by ANTLR 4.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Donatello.Services.Antlr.Generated {
using Antlr4.Runtime.Misc;
using IParseTreeListener = Antlr4.Runtime.Tree.IParseTreeListener;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete listener for a parse tree produced by
/// <see cref="DonatelloParser"/>.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface IDonatelloListener : IParseTreeListener {
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFile([NotNull] DonatelloParser.FileContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFile([NotNull] DonatelloParser.FileContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterForm([NotNull] DonatelloParser.FormContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitForm([NotNull] DonatelloParser.FormContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterList([NotNull] DonatelloParser.ListContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitList([NotNull] DonatelloParser.ListContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.dictionary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterDictionary([NotNull] DonatelloParser.DictionaryContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.dictionary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitDictionary([NotNull] DonatelloParser.DictionaryContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSet([NotNull] DonatelloParser.SetContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSet([NotNull] DonatelloParser.SetContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.vector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterVector([NotNull] DonatelloParser.VectorContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.vector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitVector([NotNull] DonatelloParser.VectorContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.lambdaParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambdaParameter([NotNull] DonatelloParser.LambdaParameterContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.lambdaParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambdaParameter([NotNull] DonatelloParser.LambdaParameterContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.lambda"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLambda([NotNull] DonatelloParser.LambdaContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.lambda"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLambda([NotNull] DonatelloParser.LambdaContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterLiteral([NotNull] DonatelloParser.LiteralContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitLiteral([NotNull] DonatelloParser.LiteralContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterString([NotNull] DonatelloParser.StringContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitString([NotNull] DonatelloParser.StringContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterNumber([NotNull] DonatelloParser.NumberContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitNumber([NotNull] DonatelloParser.NumberContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.methodAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterMethodAccess([NotNull] DonatelloParser.MethodAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.methodAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitMethodAccess([NotNull] DonatelloParser.MethodAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterFieldAccess([NotNull] DonatelloParser.FieldAccessContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitFieldAccess([NotNull] DonatelloParser.FieldAccessContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterSymbol([NotNull] DonatelloParser.SymbolContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitSymbol([NotNull] DonatelloParser.SymbolContext context);
	/// <summary>
	/// Enter a parse tree produced by <see cref="DonatelloParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void EnterType([NotNull] DonatelloParser.TypeContext context);
	/// <summary>
	/// Exit a parse tree produced by <see cref="DonatelloParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	void ExitType([NotNull] DonatelloParser.TypeContext context);
}
} // namespace Donatello.Services.Antlr.Generated
