//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.3
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Donatello.g4 by ANTLR 4.5.3

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Donatello.Services.Antlr.Generated {
using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.3")]
[System.CLSCompliant(false)]
public partial class DonatelloLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, LAMBDA_PARAMETER=9, 
		STRING=10, LONG=11, METHOD_ACCESS=12, FIELD_ACCESS=13, SYMBOL=14, TYPE=15, 
		MATH_OPERATION=16, TRASH=17;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "LAMBDA_PARAMETER", 
		"STRING", "LONG", "METHOD_ACCESS", "FIELD_ACCESS", "SYMBOL", "TYPE", "MATH_OPERATION", 
		"WS", "COMMENT", "TRASH"
	};


	public DonatelloLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

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

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x13");
		sb.Append("\x83\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6");
		sb.Append("\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f");
		sb.Append("\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4");
		sb.Append("\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x3\x2\x3\x2\x3\x3\x3\x3");
		sb.Append("\x3\x4\x3\x4\x3\x5\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3");
		sb.Append("\t\x3\t\x3\t\x3\n\x3\n\x6\n=\n\n\r\n\xE\n>\x3\v\x3\v\x3\v\x3");
		sb.Append("\v\a\v\x45\n\v\f\v\xE\vH\v\v\x3\v\x3\v\x3\f\x5\fM\n\f\x3\f\x6");
		sb.Append("\fP\n\f\r\f\xE\fQ\x3\f\x5\fU\n\f\x3\r\x3\r\x3\r\x3\xE\x3\xE");
		sb.Append("\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x6\xF\x61\n\xF\r\xF\xE\xF\x62");
		sb.Append("\x3\xF\x5\xF\x66\n\xF\x3\x10\x3\x10\x3\x10\x3\x10\x3\x10\x6");
		sb.Append("\x10m\n\x10\r\x10\xE\x10n\x3\x11\x3\x11\x3\x12\x3\x12\x3\x13");
		sb.Append("\x3\x13\x3\x13\x3\x13\a\x13y\n\x13\f\x13\xE\x13|\v\x13\x3\x14");
		sb.Append("\x3\x14\x5\x14\x80\n\x14\x3\x14\x3\x14\x2\x2\x15\x3\x3\x5\x4");
		sb.Append("\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19\xE\x1B\xF");
		sb.Append("\x1D\x10\x1F\x11!\x12#\x2%\x2\'\x13\x3\x2\v\x3\x2\x32;\x3\x2");
		sb.Append("$$\x4\x2NNnn\b\x2..\x30\x30\x32;>?\x43\\\x63|\x4\x2,,@@\x6\x2");
		sb.Append("..>>\x43\\\x63|\x5\x2,-//\x31\x31\a\x2\v\f\xF\xF\"\"..^^\x4");
		sb.Append("\x2\f\f\xF\xF\x8F\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2\x2\a\x3");
		sb.Append("\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3\x2\x2\x2");
		sb.Append("\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2\x2\x2\x2");
		sb.Append("\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2\x2\x2\x1B");
		sb.Append("\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2\x2!\x3\x2");
		sb.Append("\x2\x2\x2\'\x3\x2\x2\x2\x3)\x3\x2\x2\x2\x5+\x3\x2\x2\x2\a-\x3");
		sb.Append("\x2\x2\x2\t/\x3\x2\x2\x2\v\x31\x3\x2\x2\x2\r\x33\x3\x2\x2\x2");
		sb.Append("\xF\x35\x3\x2\x2\x2\x11\x37\x3\x2\x2\x2\x13:\x3\x2\x2\x2\x15");
		sb.Append("@\x3\x2\x2\x2\x17L\x3\x2\x2\x2\x19V\x3\x2\x2\x2\x1BY\x3\x2\x2");
		sb.Append("\x2\x1D\x65\x3\x2\x2\x2\x1Fg\x3\x2\x2\x2!p\x3\x2\x2\x2#r\x3");
		sb.Append("\x2\x2\x2%t\x3\x2\x2\x2\'\x7F\x3\x2\x2\x2)*\a*\x2\x2*\x4\x3");
		sb.Append("\x2\x2\x2+,\a+\x2\x2,\x6\x3\x2\x2\x2-.\a}\x2\x2.\b\x3\x2\x2");
		sb.Append("\x2/\x30\a\x7F\x2\x2\x30\n\x3\x2\x2\x2\x31\x32\a~\x2\x2\x32");
		sb.Append("\f\x3\x2\x2\x2\x33\x34\a]\x2\x2\x34\xE\x3\x2\x2\x2\x35\x36\a");
		sb.Append("_\x2\x2\x36\x10\x3\x2\x2\x2\x37\x38\a^\x2\x2\x38\x39\a*\x2\x2");
		sb.Append("\x39\x12\x3\x2\x2\x2:<\a^\x2\x2;=\t\x2\x2\x2<;\x3\x2\x2\x2=");
		sb.Append(">\x3\x2\x2\x2><\x3\x2\x2\x2>?\x3\x2\x2\x2?\x14\x3\x2\x2\x2@");
		sb.Append("\x46\a$\x2\x2\x41\x45\n\x3\x2\x2\x42\x43\a^\x2\x2\x43\x45\a");
		sb.Append("$\x2\x2\x44\x41\x3\x2\x2\x2\x44\x42\x3\x2\x2\x2\x45H\x3\x2\x2");
		sb.Append("\x2\x46\x44\x3\x2\x2\x2\x46G\x3\x2\x2\x2GI\x3\x2\x2\x2H\x46");
		sb.Append("\x3\x2\x2\x2IJ\a$\x2\x2J\x16\x3\x2\x2\x2KM\a/\x2\x2LK\x3\x2");
		sb.Append("\x2\x2LM\x3\x2\x2\x2MO\x3\x2\x2\x2NP\t\x2\x2\x2ON\x3\x2\x2\x2");
		sb.Append("PQ\x3\x2\x2\x2QO\x3\x2\x2\x2QR\x3\x2\x2\x2RT\x3\x2\x2\x2SU\t");
		sb.Append("\x4\x2\x2TS\x3\x2\x2\x2TU\x3\x2\x2\x2U\x18\x3\x2\x2\x2VW\a\x30");
		sb.Append("\x2\x2WX\x5\x1D\xF\x2X\x1A\x3\x2\x2\x2YZ\a/\x2\x2Z[\x5\x1D\xF");
		sb.Append("\x2[\x1C\x3\x2\x2\x2\\\x61\t\x5\x2\x2]^\a.\x2\x2^\x61\a\"\x2");
		sb.Append("\x2_\x61\t\x6\x2\x2`\\\x3\x2\x2\x2`]\x3\x2\x2\x2`_\x3\x2\x2");
		sb.Append("\x2\x61\x62\x3\x2\x2\x2\x62`\x3\x2\x2\x2\x62\x63\x3\x2\x2\x2");
		sb.Append("\x63\x66\x3\x2\x2\x2\x64\x66\x5!\x11\x2\x65`\x3\x2\x2\x2\x65");
		sb.Append("\x64\x3\x2\x2\x2\x66\x1E\x3\x2\x2\x2gl\a<\x2\x2hm\t\a\x2\x2");
		sb.Append("ij\a.\x2\x2jm\a\"\x2\x2km\a@\x2\x2lh\x3\x2\x2\x2li\x3\x2\x2");
		sb.Append("\x2lk\x3\x2\x2\x2mn\x3\x2\x2\x2nl\x3\x2\x2\x2no\x3\x2\x2\x2");
		sb.Append("o \x3\x2\x2\x2pq\t\b\x2\x2q\"\x3\x2\x2\x2rs\t\t\x2\x2s$\x3\x2");
		sb.Append("\x2\x2tu\a\x31\x2\x2uv\a\x31\x2\x2vz\x3\x2\x2\x2wy\n\n\x2\x2");
		sb.Append("xw\x3\x2\x2\x2y|\x3\x2\x2\x2zx\x3\x2\x2\x2z{\x3\x2\x2\x2{&\x3");
		sb.Append("\x2\x2\x2|z\x3\x2\x2\x2}\x80\x5#\x12\x2~\x80\x5%\x13\x2\x7F");
		sb.Append("}\x3\x2\x2\x2\x7F~\x3\x2\x2\x2\x80\x81\x3\x2\x2\x2\x81\x82\b");
		sb.Append("\x14\x2\x2\x82(\x3\x2\x2\x2\x10\x2>\x44\x46LQT`\x62\x65lnz\x7F");
		sb.Append("\x3\x2\x3\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Donatello.Services.Antlr.Generated