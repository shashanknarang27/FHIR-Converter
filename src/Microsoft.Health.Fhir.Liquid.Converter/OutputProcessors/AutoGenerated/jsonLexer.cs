//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.8
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from json.g4 by ANTLR 4.8

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.8")]
[System.CLSCompliant(false)]
public partial class jsonLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		STRING=10, NUMBER=11, WS=12;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "T__5", "T__6", "T__7", "T__8", 
		"STRING", "ESC", "UNICODE", "HEX", "SAFECODEPOINT", "NUMBER", "INT", "EXP", 
		"WS"
	};


	public jsonLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public jsonLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	private static readonly string[] _LiteralNames = {
		null, "'{'", "','", "'}'", "':'", "'['", "']'", "'true'", "'false'", "'null'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, "STRING", 
		"NUMBER", "WS"
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

	public override string GrammarFileName { get { return "json.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static jsonLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\xE', '\x82', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x4', '\x3', '\x4', '\x3', '\x5', '\x3', '\x5', '\x3', '\x6', '\x3', 
		'\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', '\x3', '\b', '\x3', '\b', 
		'\x3', '\b', '\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\t', '\x3', 
		'\t', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', '\n', 
		'\x3', '\n', '\x3', '\n', '\x3', '\v', '\x3', '\v', '\x3', '\v', '\a', 
		'\v', 'G', '\n', '\v', '\f', '\v', '\xE', '\v', 'J', '\v', '\v', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\f', '\x5', '\f', 
		'Q', '\n', '\f', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', '\r', '\x3', 
		'\r', '\x3', '\r', '\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\x10', '\x5', '\x10', '^', '\n', '\x10', '\x3', '\x10', '\x3', 
		'\x10', '\x3', '\x10', '\x6', '\x10', '\x63', '\n', '\x10', '\r', '\x10', 
		'\xE', '\x10', '\x64', '\x5', '\x10', 'g', '\n', '\x10', '\x3', '\x10', 
		'\x5', '\x10', 'j', '\n', '\x10', '\x3', '\x11', '\x3', '\x11', '\x3', 
		'\x11', '\a', '\x11', 'o', '\n', '\x11', '\f', '\x11', '\xE', '\x11', 
		'r', '\v', '\x11', '\x5', '\x11', 't', '\n', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\x5', '\x12', 'x', '\n', '\x12', '\x3', '\x12', '\x3', '\x12', 
		'\x3', '\x13', '\x6', '\x13', '}', '\n', '\x13', '\r', '\x13', '\xE', 
		'\x13', '~', '\x3', '\x13', '\x3', '\x13', '\x2', '\x2', '\x14', '\x3', 
		'\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', '\r', '\b', 
		'\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', '\x2', 
		'\x19', '\x2', '\x1B', '\x2', '\x1D', '\x2', '\x1F', '\r', '!', '\x2', 
		'#', '\x2', '%', '\xE', '\x3', '\x2', '\n', '\n', '\x2', '$', '$', '\x31', 
		'\x31', '^', '^', '\x64', '\x64', 'h', 'h', 'p', 'p', 't', 't', 'v', 'v', 
		'\x5', '\x2', '\x32', ';', '\x43', 'H', '\x63', 'h', '\x5', '\x2', '\x2', 
		'!', '$', '$', '^', '^', '\x3', '\x2', '\x32', ';', '\x3', '\x2', '\x33', 
		';', '\x4', '\x2', 'G', 'G', 'g', 'g', '\x4', '\x2', '-', '-', '/', '/', 
		'\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', '\x2', '\x86', '\x2', 
		'\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', '\t', '\x3', '\x2', 
		'\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', '\x2', '\r', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x3', '\'', 
		'\x3', '\x2', '\x2', '\x2', '\x5', ')', '\x3', '\x2', '\x2', '\x2', '\a', 
		'+', '\x3', '\x2', '\x2', '\x2', '\t', '-', '\x3', '\x2', '\x2', '\x2', 
		'\v', '/', '\x3', '\x2', '\x2', '\x2', '\r', '\x31', '\x3', '\x2', '\x2', 
		'\x2', '\xF', '\x33', '\x3', '\x2', '\x2', '\x2', '\x11', '\x38', '\x3', 
		'\x2', '\x2', '\x2', '\x13', '>', '\x3', '\x2', '\x2', '\x2', '\x15', 
		'\x43', '\x3', '\x2', '\x2', '\x2', '\x17', 'M', '\x3', '\x2', '\x2', 
		'\x2', '\x19', 'R', '\x3', '\x2', '\x2', '\x2', '\x1B', 'X', '\x3', '\x2', 
		'\x2', '\x2', '\x1D', 'Z', '\x3', '\x2', '\x2', '\x2', '\x1F', ']', '\x3', 
		'\x2', '\x2', '\x2', '!', 's', '\x3', '\x2', '\x2', '\x2', '#', 'u', '\x3', 
		'\x2', '\x2', '\x2', '%', '|', '\x3', '\x2', '\x2', '\x2', '\'', '(', 
		'\a', '}', '\x2', '\x2', '(', '\x4', '\x3', '\x2', '\x2', '\x2', ')', 
		'*', '\a', '.', '\x2', '\x2', '*', '\x6', '\x3', '\x2', '\x2', '\x2', 
		'+', ',', '\a', '\x7F', '\x2', '\x2', ',', '\b', '\x3', '\x2', '\x2', 
		'\x2', '-', '.', '\a', '<', '\x2', '\x2', '.', '\n', '\x3', '\x2', '\x2', 
		'\x2', '/', '\x30', '\a', ']', '\x2', '\x2', '\x30', '\f', '\x3', '\x2', 
		'\x2', '\x2', '\x31', '\x32', '\a', '_', '\x2', '\x2', '\x32', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x33', '\x34', '\a', 'v', '\x2', '\x2', '\x34', 
		'\x35', '\a', 't', '\x2', '\x2', '\x35', '\x36', '\a', 'w', '\x2', '\x2', 
		'\x36', '\x37', '\a', 'g', '\x2', '\x2', '\x37', '\x10', '\x3', '\x2', 
		'\x2', '\x2', '\x38', '\x39', '\a', 'h', '\x2', '\x2', '\x39', ':', '\a', 
		'\x63', '\x2', '\x2', ':', ';', '\a', 'n', '\x2', '\x2', ';', '<', '\a', 
		'u', '\x2', '\x2', '<', '=', '\a', 'g', '\x2', '\x2', '=', '\x12', '\x3', 
		'\x2', '\x2', '\x2', '>', '?', '\a', 'p', '\x2', '\x2', '?', '@', '\a', 
		'w', '\x2', '\x2', '@', '\x41', '\a', 'n', '\x2', '\x2', '\x41', '\x42', 
		'\a', 'n', '\x2', '\x2', '\x42', '\x14', '\x3', '\x2', '\x2', '\x2', '\x43', 
		'H', '\a', '$', '\x2', '\x2', '\x44', 'G', '\x5', '\x17', '\f', '\x2', 
		'\x45', 'G', '\x5', '\x1D', '\xF', '\x2', '\x46', '\x44', '\x3', '\x2', 
		'\x2', '\x2', '\x46', '\x45', '\x3', '\x2', '\x2', '\x2', 'G', 'J', '\x3', 
		'\x2', '\x2', '\x2', 'H', '\x46', '\x3', '\x2', '\x2', '\x2', 'H', 'I', 
		'\x3', '\x2', '\x2', '\x2', 'I', 'K', '\x3', '\x2', '\x2', '\x2', 'J', 
		'H', '\x3', '\x2', '\x2', '\x2', 'K', 'L', '\a', '$', '\x2', '\x2', 'L', 
		'\x16', '\x3', '\x2', '\x2', '\x2', 'M', 'P', '\a', '^', '\x2', '\x2', 
		'N', 'Q', '\t', '\x2', '\x2', '\x2', 'O', 'Q', '\x5', '\x19', '\r', '\x2', 
		'P', 'N', '\x3', '\x2', '\x2', '\x2', 'P', 'O', '\x3', '\x2', '\x2', '\x2', 
		'Q', '\x18', '\x3', '\x2', '\x2', '\x2', 'R', 'S', '\a', 'w', '\x2', '\x2', 
		'S', 'T', '\x5', '\x1B', '\xE', '\x2', 'T', 'U', '\x5', '\x1B', '\xE', 
		'\x2', 'U', 'V', '\x5', '\x1B', '\xE', '\x2', 'V', 'W', '\x5', '\x1B', 
		'\xE', '\x2', 'W', '\x1A', '\x3', '\x2', '\x2', '\x2', 'X', 'Y', '\t', 
		'\x3', '\x2', '\x2', 'Y', '\x1C', '\x3', '\x2', '\x2', '\x2', 'Z', '[', 
		'\n', '\x4', '\x2', '\x2', '[', '\x1E', '\x3', '\x2', '\x2', '\x2', '\\', 
		'^', '\a', '/', '\x2', '\x2', ']', '\\', '\x3', '\x2', '\x2', '\x2', ']', 
		'^', '\x3', '\x2', '\x2', '\x2', '^', '_', '\x3', '\x2', '\x2', '\x2', 
		'_', '\x66', '\x5', '!', '\x11', '\x2', '`', '\x62', '\a', '\x30', '\x2', 
		'\x2', '\x61', '\x63', '\t', '\x5', '\x2', '\x2', '\x62', '\x61', '\x3', 
		'\x2', '\x2', '\x2', '\x63', '\x64', '\x3', '\x2', '\x2', '\x2', '\x64', 
		'\x62', '\x3', '\x2', '\x2', '\x2', '\x64', '\x65', '\x3', '\x2', '\x2', 
		'\x2', '\x65', 'g', '\x3', '\x2', '\x2', '\x2', '\x66', '`', '\x3', '\x2', 
		'\x2', '\x2', '\x66', 'g', '\x3', '\x2', '\x2', '\x2', 'g', 'i', '\x3', 
		'\x2', '\x2', '\x2', 'h', 'j', '\x5', '#', '\x12', '\x2', 'i', 'h', '\x3', 
		'\x2', '\x2', '\x2', 'i', 'j', '\x3', '\x2', '\x2', '\x2', 'j', ' ', '\x3', 
		'\x2', '\x2', '\x2', 'k', 't', '\a', '\x32', '\x2', '\x2', 'l', 'p', '\t', 
		'\x6', '\x2', '\x2', 'm', 'o', '\t', '\x5', '\x2', '\x2', 'n', 'm', '\x3', 
		'\x2', '\x2', '\x2', 'o', 'r', '\x3', '\x2', '\x2', '\x2', 'p', 'n', '\x3', 
		'\x2', '\x2', '\x2', 'p', 'q', '\x3', '\x2', '\x2', '\x2', 'q', 't', '\x3', 
		'\x2', '\x2', '\x2', 'r', 'p', '\x3', '\x2', '\x2', '\x2', 's', 'k', '\x3', 
		'\x2', '\x2', '\x2', 's', 'l', '\x3', '\x2', '\x2', '\x2', 't', '\"', 
		'\x3', '\x2', '\x2', '\x2', 'u', 'w', '\t', '\a', '\x2', '\x2', 'v', 'x', 
		'\t', '\b', '\x2', '\x2', 'w', 'v', '\x3', '\x2', '\x2', '\x2', 'w', 'x', 
		'\x3', '\x2', '\x2', '\x2', 'x', 'y', '\x3', '\x2', '\x2', '\x2', 'y', 
		'z', '\x5', '!', '\x11', '\x2', 'z', '$', '\x3', '\x2', '\x2', '\x2', 
		'{', '}', '\t', '\t', '\x2', '\x2', '|', '{', '\x3', '\x2', '\x2', '\x2', 
		'}', '~', '\x3', '\x2', '\x2', '\x2', '~', '|', '\x3', '\x2', '\x2', '\x2', 
		'~', '\x7F', '\x3', '\x2', '\x2', '\x2', '\x7F', '\x80', '\x3', '\x2', 
		'\x2', '\x2', '\x80', '\x81', '\b', '\x13', '\x2', '\x2', '\x81', '&', 
		'\x3', '\x2', '\x2', '\x2', '\xE', '\x2', '\x46', 'H', 'P', ']', '\x64', 
		'\x66', 'i', 'p', 's', 'w', '~', '\x3', '\b', '\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
