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
using System;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6")]
[System.CLSCompliant(false)]
public partial class DonatelloParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, LAMBDA_PARAMETER=9, 
		STRING=10, LONG=11, METHOD_ACCESS=12, FIELD_ACCESS=13, SYMBOL=14, TYPE=15, 
		MATH_OPERATION=16, TRASH=17;
	public const int
		RULE_file = 0, RULE_forms = 1, RULE_form = 2, RULE_list = 3, RULE_dictionary = 4, 
		RULE_set = 5, RULE_vector = 6, RULE_lambdaParameter = 7, RULE_lambda = 8, 
		RULE_literal = 9, RULE_string = 10, RULE_number = 11, RULE_methodAccess = 12, 
		RULE_fieldAccess = 13, RULE_symbol = 14, RULE_type = 15;
	public static readonly string[] ruleNames = {
		"file", "forms", "form", "list", "dictionary", "set", "vector", "lambdaParameter", 
		"lambda", "literal", "string", "number", "methodAccess", "fieldAccess", 
		"symbol", "type"
	};

	private static readonly string[] _LiteralNames = {
		null, "'('", "')'", "'{'", "'}'", "'|'", "'['", "']'", "'\\('"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, "LAMBDA_PARAMETER", 
		"STRING", "LONG", "METHOD_ACCESS", "FIELD_ACCESS", "SYMBOL", "TYPE", "MATH_OPERATION", 
		"TRASH"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Donatello.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	static DonatelloParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

	public DonatelloParser(ITokenStream input)
		: base(input)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class FileContext : ParserRuleContext {
		public FormContext[] form() {
			return GetRuleContexts<FormContext>();
		}
		public FormContext form(int i) {
			return GetRuleContext<FormContext>(i);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterFile(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitFile(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFile(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__2) | (1L << T__4) | (1L << T__5) | (1L << T__7) | (1L << LAMBDA_PARAMETER) | (1L << STRING) | (1L << LONG) | (1L << METHOD_ACCESS) | (1L << FIELD_ACCESS) | (1L << SYMBOL) | (1L << TYPE))) != 0)) {
				{
				{
				State = 32; form();
				}
				}
				State = 37;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FormsContext : ParserRuleContext {
		public FormContext[] form() {
			return GetRuleContexts<FormContext>();
		}
		public FormContext form(int i) {
			return GetRuleContext<FormContext>(i);
		}
		public FormsContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_forms; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterForms(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitForms(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitForms(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FormsContext forms() {
		FormsContext _localctx = new FormsContext(Context, State);
		EnterRule(_localctx, 2, RULE_forms);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 41;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__2) | (1L << T__4) | (1L << T__5) | (1L << T__7) | (1L << LAMBDA_PARAMETER) | (1L << STRING) | (1L << LONG) | (1L << METHOD_ACCESS) | (1L << FIELD_ACCESS) | (1L << SYMBOL) | (1L << TYPE))) != 0)) {
				{
				{
				State = 38; form();
				}
				}
				State = 43;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FormContext : ParserRuleContext {
		public LiteralContext literal() {
			return GetRuleContext<LiteralContext>(0);
		}
		public ListContext list() {
			return GetRuleContext<ListContext>(0);
		}
		public LambdaContext lambda() {
			return GetRuleContext<LambdaContext>(0);
		}
		public VectorContext vector() {
			return GetRuleContext<VectorContext>(0);
		}
		public SetContext set() {
			return GetRuleContext<SetContext>(0);
		}
		public DictionaryContext dictionary() {
			return GetRuleContext<DictionaryContext>(0);
		}
		public FormContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_form; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterForm(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitForm(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitForm(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FormContext form() {
		FormContext _localctx = new FormContext(Context, State);
		EnterRule(_localctx, 4, RULE_form);
		try {
			State = 50;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LAMBDA_PARAMETER:
			case STRING:
			case LONG:
			case METHOD_ACCESS:
			case FIELD_ACCESS:
			case SYMBOL:
			case TYPE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 44; literal();
				}
				break;
			case T__0:
				EnterOuterAlt(_localctx, 2);
				{
				State = 45; list();
				}
				break;
			case T__7:
				EnterOuterAlt(_localctx, 3);
				{
				State = 46; lambda();
				}
				break;
			case T__5:
				EnterOuterAlt(_localctx, 4);
				{
				State = 47; vector();
				}
				break;
			case T__4:
				EnterOuterAlt(_localctx, 5);
				{
				State = 48; set();
				}
				break;
			case T__2:
				EnterOuterAlt(_localctx, 6);
				{
				State = 49; dictionary();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ListContext : ParserRuleContext {
		public FormsContext forms() {
			return GetRuleContext<FormsContext>(0);
		}
		public ListContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_list; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterList(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitList(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitList(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ListContext list() {
		ListContext _localctx = new ListContext(Context, State);
		EnterRule(_localctx, 6, RULE_list);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 52; Match(T__0);
			State = 53; forms();
			State = 54; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class DictionaryContext : ParserRuleContext {
		public FormContext[] form() {
			return GetRuleContexts<FormContext>();
		}
		public FormContext form(int i) {
			return GetRuleContext<FormContext>(i);
		}
		public DictionaryContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_dictionary; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterDictionary(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitDictionary(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitDictionary(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public DictionaryContext dictionary() {
		DictionaryContext _localctx = new DictionaryContext(Context, State);
		EnterRule(_localctx, 8, RULE_dictionary);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 56; Match(T__2);
			State = 60;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__2) | (1L << T__4) | (1L << T__5) | (1L << T__7) | (1L << LAMBDA_PARAMETER) | (1L << STRING) | (1L << LONG) | (1L << METHOD_ACCESS) | (1L << FIELD_ACCESS) | (1L << SYMBOL) | (1L << TYPE))) != 0)) {
				{
				{
				State = 57; form();
				}
				}
				State = 62;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 63; Match(T__3);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SetContext : ParserRuleContext {
		public FormContext[] form() {
			return GetRuleContexts<FormContext>();
		}
		public FormContext form(int i) {
			return GetRuleContext<FormContext>(i);
		}
		public SetContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_set; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterSet(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitSet(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSet(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SetContext set() {
		SetContext _localctx = new SetContext(Context, State);
		EnterRule(_localctx, 10, RULE_set);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 65; Match(T__4);
			State = 69;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 66; form();
					}
					} 
				}
				State = 71;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			State = 72; Match(T__4);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class VectorContext : ParserRuleContext {
		public FormContext[] form() {
			return GetRuleContexts<FormContext>();
		}
		public FormContext form(int i) {
			return GetRuleContext<FormContext>(i);
		}
		public VectorContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_vector; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterVector(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitVector(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitVector(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public VectorContext vector() {
		VectorContext _localctx = new VectorContext(Context, State);
		EnterRule(_localctx, 12, RULE_vector);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 74; Match(T__5);
			State = 78;
			ErrorHandler.Sync(this);
			_la = TokenStream.LA(1);
			while ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__2) | (1L << T__4) | (1L << T__5) | (1L << T__7) | (1L << LAMBDA_PARAMETER) | (1L << STRING) | (1L << LONG) | (1L << METHOD_ACCESS) | (1L << FIELD_ACCESS) | (1L << SYMBOL) | (1L << TYPE))) != 0)) {
				{
				{
				State = 75; form();
				}
				}
				State = 80;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
			}
			State = 81; Match(T__6);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LambdaParameterContext : ParserRuleContext {
		public ITerminalNode LAMBDA_PARAMETER() { return GetToken(DonatelloParser.LAMBDA_PARAMETER, 0); }
		public LambdaParameterContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambdaParameter; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterLambdaParameter(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitLambdaParameter(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLambdaParameter(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LambdaParameterContext lambdaParameter() {
		LambdaParameterContext _localctx = new LambdaParameterContext(Context, State);
		EnterRule(_localctx, 14, RULE_lambdaParameter);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 83; Match(LAMBDA_PARAMETER);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LambdaContext : ParserRuleContext {
		public FormsContext forms() {
			return GetRuleContext<FormsContext>(0);
		}
		public LambdaContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_lambda; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterLambda(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitLambda(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLambda(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LambdaContext lambda() {
		LambdaContext _localctx = new LambdaContext(Context, State);
		EnterRule(_localctx, 16, RULE_lambda);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 85; Match(T__7);
			State = 86; forms();
			State = 87; Match(T__1);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class LiteralContext : ParserRuleContext {
		public StringContext @string() {
			return GetRuleContext<StringContext>(0);
		}
		public NumberContext number() {
			return GetRuleContext<NumberContext>(0);
		}
		public MethodAccessContext methodAccess() {
			return GetRuleContext<MethodAccessContext>(0);
		}
		public FieldAccessContext fieldAccess() {
			return GetRuleContext<FieldAccessContext>(0);
		}
		public SymbolContext symbol() {
			return GetRuleContext<SymbolContext>(0);
		}
		public LambdaParameterContext lambdaParameter() {
			return GetRuleContext<LambdaParameterContext>(0);
		}
		public TypeContext type() {
			return GetRuleContext<TypeContext>(0);
		}
		public LiteralContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_literal; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterLiteral(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitLiteral(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLiteral(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public LiteralContext literal() {
		LiteralContext _localctx = new LiteralContext(Context, State);
		EnterRule(_localctx, 18, RULE_literal);
		try {
			State = 96;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case STRING:
				EnterOuterAlt(_localctx, 1);
				{
				State = 89; @string();
				}
				break;
			case LONG:
				EnterOuterAlt(_localctx, 2);
				{
				State = 90; number();
				}
				break;
			case METHOD_ACCESS:
				EnterOuterAlt(_localctx, 3);
				{
				State = 91; methodAccess();
				}
				break;
			case FIELD_ACCESS:
				EnterOuterAlt(_localctx, 4);
				{
				State = 92; fieldAccess();
				}
				break;
			case SYMBOL:
				EnterOuterAlt(_localctx, 5);
				{
				State = 93; symbol();
				}
				break;
			case LAMBDA_PARAMETER:
				EnterOuterAlt(_localctx, 6);
				{
				State = 94; lambdaParameter();
				}
				break;
			case TYPE:
				EnterOuterAlt(_localctx, 7);
				{
				State = 95; type();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class StringContext : ParserRuleContext {
		public ITerminalNode STRING() { return GetToken(DonatelloParser.STRING, 0); }
		public StringContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_string; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterString(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitString(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public StringContext @string() {
		StringContext _localctx = new StringContext(Context, State);
		EnterRule(_localctx, 20, RULE_string);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 98; Match(STRING);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NumberContext : ParserRuleContext {
		public ITerminalNode LONG() { return GetToken(DonatelloParser.LONG, 0); }
		public NumberContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_number; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterNumber(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitNumber(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NumberContext number() {
		NumberContext _localctx = new NumberContext(Context, State);
		EnterRule(_localctx, 22, RULE_number);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 100; Match(LONG);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class MethodAccessContext : ParserRuleContext {
		public ITerminalNode METHOD_ACCESS() { return GetToken(DonatelloParser.METHOD_ACCESS, 0); }
		public MethodAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_methodAccess; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterMethodAccess(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitMethodAccess(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMethodAccess(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MethodAccessContext methodAccess() {
		MethodAccessContext _localctx = new MethodAccessContext(Context, State);
		EnterRule(_localctx, 24, RULE_methodAccess);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 102; Match(METHOD_ACCESS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class FieldAccessContext : ParserRuleContext {
		public ITerminalNode FIELD_ACCESS() { return GetToken(DonatelloParser.FIELD_ACCESS, 0); }
		public FieldAccessContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_fieldAccess; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterFieldAccess(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitFieldAccess(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFieldAccess(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public FieldAccessContext fieldAccess() {
		FieldAccessContext _localctx = new FieldAccessContext(Context, State);
		EnterRule(_localctx, 26, RULE_fieldAccess);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 104; Match(FIELD_ACCESS);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class SymbolContext : ParserRuleContext {
		public ITerminalNode SYMBOL() { return GetToken(DonatelloParser.SYMBOL, 0); }
		public SymbolContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_symbol; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterSymbol(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitSymbol(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitSymbol(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public SymbolContext symbol() {
		SymbolContext _localctx = new SymbolContext(Context, State);
		EnterRule(_localctx, 28, RULE_symbol);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 106; Match(SYMBOL);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class TypeContext : ParserRuleContext {
		public ITerminalNode TYPE() { return GetToken(DonatelloParser.TYPE, 0); }
		public TypeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_type; } }
		public override void EnterRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.EnterType(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			IDonatelloListener typedListener = listener as IDonatelloListener;
			if (typedListener != null) typedListener.ExitType(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IDonatelloVisitor<TResult> typedVisitor = visitor as IDonatelloVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitType(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public TypeContext type() {
		TypeContext _localctx = new TypeContext(Context, State);
		EnterRule(_localctx, 30, RULE_type);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 108; Match(TYPE);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x3\x13");
		sb.Append("q\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6\t\x6\x4");
		sb.Append("\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f\x4\r\t\r");
		sb.Append("\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x3\x2\a\x2");
		sb.Append("$\n\x2\f\x2\xE\x2\'\v\x2\x3\x3\a\x3*\n\x3\f\x3\xE\x3-\v\x3\x3");
		sb.Append("\x4\x3\x4\x3\x4\x3\x4\x3\x4\x3\x4\x5\x4\x35\n\x4\x3\x5\x3\x5");
		sb.Append("\x3\x5\x3\x5\x3\x6\x3\x6\a\x6=\n\x6\f\x6\xE\x6@\v\x6\x3\x6\x3");
		sb.Append("\x6\x3\a\x3\a\a\a\x46\n\a\f\a\xE\aI\v\a\x3\a\x3\a\x3\b\x3\b");
		sb.Append("\a\bO\n\b\f\b\xE\bR\v\b\x3\b\x3\b\x3\t\x3\t\x3\n\x3\n\x3\n\x3");
		sb.Append("\n\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x3\v\x5\v\x63\n\v\x3\f\x3\f");
		sb.Append("\x3\r\x3\r\x3\xE\x3\xE\x3\xF\x3\xF\x3\x10\x3\x10\x3\x11\x3\x11");
		sb.Append("\x3\x11\x2\x2\x12\x2\x4\x6\b\n\f\xE\x10\x12\x14\x16\x18\x1A");
		sb.Append("\x1C\x1E \x2\x2p\x2%\x3\x2\x2\x2\x4+\x3\x2\x2\x2\x6\x34\x3\x2");
		sb.Append("\x2\x2\b\x36\x3\x2\x2\x2\n:\x3\x2\x2\x2\f\x43\x3\x2\x2\x2\xE");
		sb.Append("L\x3\x2\x2\x2\x10U\x3\x2\x2\x2\x12W\x3\x2\x2\x2\x14\x62\x3\x2");
		sb.Append("\x2\x2\x16\x64\x3\x2\x2\x2\x18\x66\x3\x2\x2\x2\x1Ah\x3\x2\x2");
		sb.Append("\x2\x1Cj\x3\x2\x2\x2\x1El\x3\x2\x2\x2 n\x3\x2\x2\x2\"$\x5\x6");
		sb.Append("\x4\x2#\"\x3\x2\x2\x2$\'\x3\x2\x2\x2%#\x3\x2\x2\x2%&\x3\x2\x2");
		sb.Append("\x2&\x3\x3\x2\x2\x2\'%\x3\x2\x2\x2(*\x5\x6\x4\x2)(\x3\x2\x2");
		sb.Append("\x2*-\x3\x2\x2\x2+)\x3\x2\x2\x2+,\x3\x2\x2\x2,\x5\x3\x2\x2\x2");
		sb.Append("-+\x3\x2\x2\x2.\x35\x5\x14\v\x2/\x35\x5\b\x5\x2\x30\x35\x5\x12");
		sb.Append("\n\x2\x31\x35\x5\xE\b\x2\x32\x35\x5\f\a\x2\x33\x35\x5\n\x6\x2");
		sb.Append("\x34.\x3\x2\x2\x2\x34/\x3\x2\x2\x2\x34\x30\x3\x2\x2\x2\x34\x31");
		sb.Append("\x3\x2\x2\x2\x34\x32\x3\x2\x2\x2\x34\x33\x3\x2\x2\x2\x35\a\x3");
		sb.Append("\x2\x2\x2\x36\x37\a\x3\x2\x2\x37\x38\x5\x4\x3\x2\x38\x39\a\x4");
		sb.Append("\x2\x2\x39\t\x3\x2\x2\x2:>\a\x5\x2\x2;=\x5\x6\x4\x2<;\x3\x2");
		sb.Append("\x2\x2=@\x3\x2\x2\x2><\x3\x2\x2\x2>?\x3\x2\x2\x2?\x41\x3\x2");
		sb.Append("\x2\x2@>\x3\x2\x2\x2\x41\x42\a\x6\x2\x2\x42\v\x3\x2\x2\x2\x43");
		sb.Append("G\a\a\x2\x2\x44\x46\x5\x6\x4\x2\x45\x44\x3\x2\x2\x2\x46I\x3");
		sb.Append("\x2\x2\x2G\x45\x3\x2\x2\x2GH\x3\x2\x2\x2HJ\x3\x2\x2\x2IG\x3");
		sb.Append("\x2\x2\x2JK\a\a\x2\x2K\r\x3\x2\x2\x2LP\a\b\x2\x2MO\x5\x6\x4");
		sb.Append("\x2NM\x3\x2\x2\x2OR\x3\x2\x2\x2PN\x3\x2\x2\x2PQ\x3\x2\x2\x2");
		sb.Append("QS\x3\x2\x2\x2RP\x3\x2\x2\x2ST\a\t\x2\x2T\xF\x3\x2\x2\x2UV\a");
		sb.Append("\v\x2\x2V\x11\x3\x2\x2\x2WX\a\n\x2\x2XY\x5\x4\x3\x2YZ\a\x4\x2");
		sb.Append("\x2Z\x13\x3\x2\x2\x2[\x63\x5\x16\f\x2\\\x63\x5\x18\r\x2]\x63");
		sb.Append("\x5\x1A\xE\x2^\x63\x5\x1C\xF\x2_\x63\x5\x1E\x10\x2`\x63\x5\x10");
		sb.Append("\t\x2\x61\x63\x5 \x11\x2\x62[\x3\x2\x2\x2\x62\\\x3\x2\x2\x2");
		sb.Append("\x62]\x3\x2\x2\x2\x62^\x3\x2\x2\x2\x62_\x3\x2\x2\x2\x62`\x3");
		sb.Append("\x2\x2\x2\x62\x61\x3\x2\x2\x2\x63\x15\x3\x2\x2\x2\x64\x65\a");
		sb.Append("\f\x2\x2\x65\x17\x3\x2\x2\x2\x66g\a\r\x2\x2g\x19\x3\x2\x2\x2");
		sb.Append("hi\a\xE\x2\x2i\x1B\x3\x2\x2\x2jk\a\xF\x2\x2k\x1D\x3\x2\x2\x2");
		sb.Append("lm\a\x10\x2\x2m\x1F\x3\x2\x2\x2no\a\x11\x2\x2o!\x3\x2\x2\x2");
		sb.Append("\t%+\x34>GP\x62");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());


}
} // namespace Donatello.Services.Antlr.Generated
