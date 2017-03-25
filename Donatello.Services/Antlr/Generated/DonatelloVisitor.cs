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
#pragma warning disable 3021
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;

/// <summary>
/// This interface defines a complete generic visitor for a parse tree produced
/// by <see cref="DonatelloParser"/>.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public interface IDonatelloVisitor<Result> : IParseTreeVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.file"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFile([NotNull] DonatelloParser.FileContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.forms"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForms([NotNull] DonatelloParser.FormsContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.form"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitForm([NotNull] DonatelloParser.FormContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.list"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitList([NotNull] DonatelloParser.ListContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.dictionary"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitDictionary([NotNull] DonatelloParser.DictionaryContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.set"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSet([NotNull] DonatelloParser.SetContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.vector"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitVector([NotNull] DonatelloParser.VectorContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.lambdaParameter"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambdaParameter([NotNull] DonatelloParser.LambdaParameterContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.lambda"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLambda([NotNull] DonatelloParser.LambdaContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.literal"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitLiteral([NotNull] DonatelloParser.LiteralContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.string"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitString([NotNull] DonatelloParser.StringContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.number"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitNumber([NotNull] DonatelloParser.NumberContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.methodAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitMethodAccess([NotNull] DonatelloParser.MethodAccessContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.fieldAccess"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitFieldAccess([NotNull] DonatelloParser.FieldAccessContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.symbol"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitSymbol([NotNull] DonatelloParser.SymbolContext context);
	/// <summary>
	/// Visit a parse tree produced by <see cref="DonatelloParser.type"/>.
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	Result VisitType([NotNull] DonatelloParser.TypeContext context);
}
} // namespace Donatello.Services.Antlr.Generated
