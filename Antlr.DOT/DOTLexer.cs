//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.5.2
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from DOT.g4 by ANTLR 4.5.2

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Antlr.DOT {
using System;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.5.2")]
[System.CLSCompliant(false)]
public partial class DOTLexer : Lexer {
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, STRICT=11, GRAPH=12, DIGRAPH=13, NODE=14, EDGE=15, SUBGRAPH=16, 
		NUMBER=17, STRING=18, ID=19, HTML_STRING=20, COMMENT=21, LINE_COMMENT=22, 
		PREPROC=23, WS=24;
	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"T__9", "STRICT", "GRAPH", "DIGRAPH", "NODE", "EDGE", "SUBGRAPH", "NUMBER", 
		"DIGIT", "STRING", "ID", "LETTER", "HTML_STRING", "TAG", "COMMENT", "LINE_COMMENT", 
		"PREPROC", "WS"
	};


	public DOTLexer(ICharStream input)
		: base(input)
	{
		Interpreter = new LexerATNSimulator(this,_ATN);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "'}'", "';'", "'='", "'['", "']'", "','", "'->'", "'--'", 
		"':'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, "STRICT", 
		"GRAPH", "DIGRAPH", "NODE", "EDGE", "SUBGRAPH", "NUMBER", "STRING", "ID", 
		"HTML_STRING", "COMMENT", "LINE_COMMENT", "PREPROC", "WS"
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

	public override string GrammarFileName { get { return "DOT.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return _serializedATN; } }

	private static string _serializedATN = _serializeATN();
	private static string _serializeATN()
	{
	    StringBuilder sb = new StringBuilder();
	    sb.Append("\x3\x430\xD6D1\x8206\xAD2D\x4417\xAEF1\x8D80\xAADD\x2\x1A");
		sb.Append("\xEA\b\x1\x4\x2\t\x2\x4\x3\t\x3\x4\x4\t\x4\x4\x5\t\x5\x4\x6");
		sb.Append("\t\x6\x4\a\t\a\x4\b\t\b\x4\t\t\t\x4\n\t\n\x4\v\t\v\x4\f\t\f");
		sb.Append("\x4\r\t\r\x4\xE\t\xE\x4\xF\t\xF\x4\x10\t\x10\x4\x11\t\x11\x4");
		sb.Append("\x12\t\x12\x4\x13\t\x13\x4\x14\t\x14\x4\x15\t\x15\x4\x16\t\x16");
		sb.Append("\x4\x17\t\x17\x4\x18\t\x18\x4\x19\t\x19\x4\x1A\t\x1A\x4\x1B");
		sb.Append("\t\x1B\x4\x1C\t\x1C\x3\x2\x3\x2\x3\x3\x3\x3\x3\x4\x3\x4\x3\x5");
		sb.Append("\x3\x5\x3\x6\x3\x6\x3\a\x3\a\x3\b\x3\b\x3\t\x3\t\x3\t\x3\n\x3");
		sb.Append("\n\x3\n\x3\v\x3\v\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\f\x3\r\x3");
		sb.Append("\r\x3\r\x3\r\x3\r\x3\r\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3\xE\x3");
		sb.Append("\xE\x3\xE\x3\xF\x3\xF\x3\xF\x3\xF\x3\xF\x3\x10\x3\x10\x3\x10");
		sb.Append("\x3\x10\x3\x10\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3\x11\x3");
		sb.Append("\x11\x3\x11\x3\x11\x3\x12\x5\x12y\n\x12\x3\x12\x3\x12\x6\x12");
		sb.Append("}\n\x12\r\x12\xE\x12~\x3\x12\x6\x12\x82\n\x12\r\x12\xE\x12\x83");
		sb.Append("\x3\x12\x3\x12\a\x12\x88\n\x12\f\x12\xE\x12\x8B\v\x12\x5\x12");
		sb.Append("\x8D\n\x12\x5\x12\x8F\n\x12\x3\x13\x3\x13\x3\x14\x3\x14\x3\x14");
		sb.Append("\x3\x14\a\x14\x97\n\x14\f\x14\xE\x14\x9A\v\x14\x3\x14\x3\x14");
		sb.Append("\x3\x15\x3\x15\x3\x15\a\x15\xA1\n\x15\f\x15\xE\x15\xA4\v\x15");
		sb.Append("\x3\x16\x3\x16\x3\x17\x3\x17\x3\x17\a\x17\xAB\n\x17\f\x17\xE");
		sb.Append("\x17\xAE\v\x17\x3\x17\x3\x17\x3\x18\x3\x18\a\x18\xB4\n\x18\f");
		sb.Append("\x18\xE\x18\xB7\v\x18\x3\x18\x3\x18\x3\x19\x3\x19\x3\x19\x3");
		sb.Append("\x19\a\x19\xBF\n\x19\f\x19\xE\x19\xC2\v\x19\x3\x19\x3\x19\x3");
		sb.Append("\x19\x3\x19\x3\x19\x3\x1A\x3\x1A\x3\x1A\x3\x1A\a\x1A\xCD\n\x1A");
		sb.Append("\f\x1A\xE\x1A\xD0\v\x1A\x3\x1A\x5\x1A\xD3\n\x1A\x3\x1A\x3\x1A");
		sb.Append("\x3\x1A\x3\x1A\x3\x1B\x3\x1B\a\x1B\xDB\n\x1B\f\x1B\xE\x1B\xDE");
		sb.Append("\v\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1B\x3\x1C\x6\x1C\xE5\n\x1C\r");
		sb.Append("\x1C\xE\x1C\xE6\x3\x1C\x3\x1C\a\x98\xB5\xC0\xCE\xDC\x2\x1D\x3");
		sb.Append("\x3\x5\x4\a\x5\t\x6\v\a\r\b\xF\t\x11\n\x13\v\x15\f\x17\r\x19");
		sb.Append("\xE\x1B\xF\x1D\x10\x1F\x11!\x12#\x13%\x2\'\x14)\x15+\x2-\x16");
		sb.Append("/\x2\x31\x17\x33\x18\x35\x19\x37\x1A\x3\x2\x15\x4\x2UUuu\x4");
		sb.Append("\x2VVvv\x4\x2TTtt\x4\x2KKkk\x4\x2\x45\x45\x65\x65\x4\x2IIii");
		sb.Append("\x4\x2\x43\x43\x63\x63\x4\x2RRrr\x4\x2JJjj\x4\x2\x46\x46\x66");
		sb.Append("\x66\x4\x2PPpp\x4\x2QQqq\x4\x2GGgg\x4\x2WWww\x4\x2\x44\x44\x64");
		sb.Append("\x64\x3\x2\x32;\x6\x2\x43\\\x61\x61\x63|\x82\x101\x4\x2>>@@");
		sb.Append("\x5\x2\v\f\xF\xF\"\"\xF8\x2\x3\x3\x2\x2\x2\x2\x5\x3\x2\x2\x2");
		sb.Append("\x2\a\x3\x2\x2\x2\x2\t\x3\x2\x2\x2\x2\v\x3\x2\x2\x2\x2\r\x3");
		sb.Append("\x2\x2\x2\x2\xF\x3\x2\x2\x2\x2\x11\x3\x2\x2\x2\x2\x13\x3\x2");
		sb.Append("\x2\x2\x2\x15\x3\x2\x2\x2\x2\x17\x3\x2\x2\x2\x2\x19\x3\x2\x2");
		sb.Append("\x2\x2\x1B\x3\x2\x2\x2\x2\x1D\x3\x2\x2\x2\x2\x1F\x3\x2\x2\x2");
		sb.Append("\x2!\x3\x2\x2\x2\x2#\x3\x2\x2\x2\x2\'\x3\x2\x2\x2\x2)\x3\x2");
		sb.Append("\x2\x2\x2-\x3\x2\x2\x2\x2\x31\x3\x2\x2\x2\x2\x33\x3\x2\x2\x2");
		sb.Append("\x2\x35\x3\x2\x2\x2\x2\x37\x3\x2\x2\x2\x3\x39\x3\x2\x2\x2\x5");
		sb.Append(";\x3\x2\x2\x2\a=\x3\x2\x2\x2\t?\x3\x2\x2\x2\v\x41\x3\x2\x2\x2");
		sb.Append("\r\x43\x3\x2\x2\x2\xF\x45\x3\x2\x2\x2\x11G\x3\x2\x2\x2\x13J");
		sb.Append("\x3\x2\x2\x2\x15M\x3\x2\x2\x2\x17O\x3\x2\x2\x2\x19V\x3\x2\x2");
		sb.Append("\x2\x1B\\\x3\x2\x2\x2\x1D\x64\x3\x2\x2\x2\x1Fi\x3\x2\x2\x2!");
		sb.Append("n\x3\x2\x2\x2#x\x3\x2\x2\x2%\x90\x3\x2\x2\x2\'\x92\x3\x2\x2");
		sb.Append("\x2)\x9D\x3\x2\x2\x2+\xA5\x3\x2\x2\x2-\xA7\x3\x2\x2\x2/\xB1");
		sb.Append("\x3\x2\x2\x2\x31\xBA\x3\x2\x2\x2\x33\xC8\x3\x2\x2\x2\x35\xD8");
		sb.Append("\x3\x2\x2\x2\x37\xE4\x3\x2\x2\x2\x39:\a}\x2\x2:\x4\x3\x2\x2");
		sb.Append("\x2;<\a\x7F\x2\x2<\x6\x3\x2\x2\x2=>\a=\x2\x2>\b\x3\x2\x2\x2");
		sb.Append("?@\a?\x2\x2@\n\x3\x2\x2\x2\x41\x42\a]\x2\x2\x42\f\x3\x2\x2\x2");
		sb.Append("\x43\x44\a_\x2\x2\x44\xE\x3\x2\x2\x2\x45\x46\a.\x2\x2\x46\x10");
		sb.Append("\x3\x2\x2\x2GH\a/\x2\x2HI\a@\x2\x2I\x12\x3\x2\x2\x2JK\a/\x2");
		sb.Append("\x2KL\a/\x2\x2L\x14\x3\x2\x2\x2MN\a<\x2\x2N\x16\x3\x2\x2\x2");
		sb.Append("OP\t\x2\x2\x2PQ\t\x3\x2\x2QR\t\x4\x2\x2RS\t\x5\x2\x2ST\t\x6");
		sb.Append("\x2\x2TU\t\x3\x2\x2U\x18\x3\x2\x2\x2VW\t\a\x2\x2WX\t\x4\x2\x2");
		sb.Append("XY\t\b\x2\x2YZ\t\t\x2\x2Z[\t\n\x2\x2[\x1A\x3\x2\x2\x2\\]\t\v");
		sb.Append("\x2\x2]^\t\x5\x2\x2^_\t\a\x2\x2_`\t\x4\x2\x2`\x61\t\b\x2\x2");
		sb.Append("\x61\x62\t\t\x2\x2\x62\x63\t\n\x2\x2\x63\x1C\x3\x2\x2\x2\x64");
		sb.Append("\x65\t\f\x2\x2\x65\x66\t\r\x2\x2\x66g\t\v\x2\x2gh\t\xE\x2\x2");
		sb.Append("h\x1E\x3\x2\x2\x2ij\t\xE\x2\x2jk\t\v\x2\x2kl\t\a\x2\x2lm\t\xE");
		sb.Append("\x2\x2m \x3\x2\x2\x2no\t\x2\x2\x2op\t\xF\x2\x2pq\t\x10\x2\x2");
		sb.Append("qr\t\a\x2\x2rs\t\x4\x2\x2st\t\b\x2\x2tu\t\t\x2\x2uv\t\n\x2\x2");
		sb.Append("v\"\x3\x2\x2\x2wy\a/\x2\x2xw\x3\x2\x2\x2xy\x3\x2\x2\x2y\x8E");
		sb.Append("\x3\x2\x2\x2z|\a\x30\x2\x2{}\x5%\x13\x2|{\x3\x2\x2\x2}~\x3\x2");
		sb.Append("\x2\x2~|\x3\x2\x2\x2~\x7F\x3\x2\x2\x2\x7F\x8F\x3\x2\x2\x2\x80");
		sb.Append("\x82\x5%\x13\x2\x81\x80\x3\x2\x2\x2\x82\x83\x3\x2\x2\x2\x83");
		sb.Append("\x81\x3\x2\x2\x2\x83\x84\x3\x2\x2\x2\x84\x8C\x3\x2\x2\x2\x85");
		sb.Append("\x89\a\x30\x2\x2\x86\x88\x5%\x13\x2\x87\x86\x3\x2\x2\x2\x88");
		sb.Append("\x8B\x3\x2\x2\x2\x89\x87\x3\x2\x2\x2\x89\x8A\x3\x2\x2\x2\x8A");
		sb.Append("\x8D\x3\x2\x2\x2\x8B\x89\x3\x2\x2\x2\x8C\x85\x3\x2\x2\x2\x8C");
		sb.Append("\x8D\x3\x2\x2\x2\x8D\x8F\x3\x2\x2\x2\x8Ez\x3\x2\x2\x2\x8E\x81");
		sb.Append("\x3\x2\x2\x2\x8F$\x3\x2\x2\x2\x90\x91\t\x11\x2\x2\x91&\x3\x2");
		sb.Append("\x2\x2\x92\x98\a$\x2\x2\x93\x94\a^\x2\x2\x94\x97\a$\x2\x2\x95");
		sb.Append("\x97\v\x2\x2\x2\x96\x93\x3\x2\x2\x2\x96\x95\x3\x2\x2\x2\x97");
		sb.Append("\x9A\x3\x2\x2\x2\x98\x99\x3\x2\x2\x2\x98\x96\x3\x2\x2\x2\x99");
		sb.Append("\x9B\x3\x2\x2\x2\x9A\x98\x3\x2\x2\x2\x9B\x9C\a$\x2\x2\x9C(\x3");
		sb.Append("\x2\x2\x2\x9D\xA2\x5+\x16\x2\x9E\xA1\x5+\x16\x2\x9F\xA1\x5%");
		sb.Append("\x13\x2\xA0\x9E\x3\x2\x2\x2\xA0\x9F\x3\x2\x2\x2\xA1\xA4\x3\x2");
		sb.Append("\x2\x2\xA2\xA0\x3\x2\x2\x2\xA2\xA3\x3\x2\x2\x2\xA3*\x3\x2\x2");
		sb.Append("\x2\xA4\xA2\x3\x2\x2\x2\xA5\xA6\t\x12\x2\x2\xA6,\x3\x2\x2\x2");
		sb.Append("\xA7\xAC\a>\x2\x2\xA8\xAB\x5/\x18\x2\xA9\xAB\n\x13\x2\x2\xAA");
		sb.Append("\xA8\x3\x2\x2\x2\xAA\xA9\x3\x2\x2\x2\xAB\xAE\x3\x2\x2\x2\xAC");
		sb.Append("\xAA\x3\x2\x2\x2\xAC\xAD\x3\x2\x2\x2\xAD\xAF\x3\x2\x2\x2\xAE");
		sb.Append("\xAC\x3\x2\x2\x2\xAF\xB0\a@\x2\x2\xB0.\x3\x2\x2\x2\xB1\xB5\a");
		sb.Append(">\x2\x2\xB2\xB4\v\x2\x2\x2\xB3\xB2\x3\x2\x2\x2\xB4\xB7\x3\x2");
		sb.Append("\x2\x2\xB5\xB6\x3\x2\x2\x2\xB5\xB3\x3\x2\x2\x2\xB6\xB8\x3\x2");
		sb.Append("\x2\x2\xB7\xB5\x3\x2\x2\x2\xB8\xB9\a@\x2\x2\xB9\x30\x3\x2\x2");
		sb.Append("\x2\xBA\xBB\a\x31\x2\x2\xBB\xBC\a,\x2\x2\xBC\xC0\x3\x2\x2\x2");
		sb.Append("\xBD\xBF\v\x2\x2\x2\xBE\xBD\x3\x2\x2\x2\xBF\xC2\x3\x2\x2\x2");
		sb.Append("\xC0\xC1\x3\x2\x2\x2\xC0\xBE\x3\x2\x2\x2\xC1\xC3\x3\x2\x2\x2");
		sb.Append("\xC2\xC0\x3\x2\x2\x2\xC3\xC4\a,\x2\x2\xC4\xC5\a\x31\x2\x2\xC5");
		sb.Append("\xC6\x3\x2\x2\x2\xC6\xC7\b\x19\x2\x2\xC7\x32\x3\x2\x2\x2\xC8");
		sb.Append("\xC9\a\x31\x2\x2\xC9\xCA\a\x31\x2\x2\xCA\xCE\x3\x2\x2\x2\xCB");
		sb.Append("\xCD\v\x2\x2\x2\xCC\xCB\x3\x2\x2\x2\xCD\xD0\x3\x2\x2\x2\xCE");
		sb.Append("\xCF\x3\x2\x2\x2\xCE\xCC\x3\x2\x2\x2\xCF\xD2\x3\x2\x2\x2\xD0");
		sb.Append("\xCE\x3\x2\x2\x2\xD1\xD3\a\xF\x2\x2\xD2\xD1\x3\x2\x2\x2\xD2");
		sb.Append("\xD3\x3\x2\x2\x2\xD3\xD4\x3\x2\x2\x2\xD4\xD5\a\f\x2\x2\xD5\xD6");
		sb.Append("\x3\x2\x2\x2\xD6\xD7\b\x1A\x2\x2\xD7\x34\x3\x2\x2\x2\xD8\xDC");
		sb.Append("\a%\x2\x2\xD9\xDB\v\x2\x2\x2\xDA\xD9\x3\x2\x2\x2\xDB\xDE\x3");
		sb.Append("\x2\x2\x2\xDC\xDD\x3\x2\x2\x2\xDC\xDA\x3\x2\x2\x2\xDD\xDF\x3");
		sb.Append("\x2\x2\x2\xDE\xDC\x3\x2\x2\x2\xDF\xE0\a\f\x2\x2\xE0\xE1\x3\x2");
		sb.Append("\x2\x2\xE1\xE2\b\x1B\x2\x2\xE2\x36\x3\x2\x2\x2\xE3\xE5\t\x14");
		sb.Append("\x2\x2\xE4\xE3\x3\x2\x2\x2\xE5\xE6\x3\x2\x2\x2\xE6\xE4\x3\x2");
		sb.Append("\x2\x2\xE6\xE7\x3\x2\x2\x2\xE7\xE8\x3\x2\x2\x2\xE8\xE9\b\x1C");
		sb.Append("\x2\x2\xE9\x38\x3\x2\x2\x2\x15\x2x~\x83\x89\x8C\x8E\x96\x98");
		sb.Append("\xA0\xA2\xAA\xAC\xB5\xC0\xCE\xD2\xDC\xE6\x3\b\x2\x2");
	    return sb.ToString();
	}

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN.ToCharArray());
}
} // namespace Antlr.DOT