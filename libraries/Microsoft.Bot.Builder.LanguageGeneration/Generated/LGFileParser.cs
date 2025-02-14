//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.11.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from LGFileParser.g4 by ANTLR 4.11.1

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

#pragma warning disable 3021
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.11.1")]
[System.CLSCompliant(false)]
public partial class LGFileParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		NEWLINE=1, OPTION=2, COMMENT=3, IMPORT=4, TEMPLATE_NAME_LINE=5, INLINE_MULTILINE=6, 
		MULTILINE_PREFIX=7, TEMPLATE_BODY=8, INVALID_LINE=9, MULTILINE_SUFFIX=10, 
		ESCAPE_CHARACTER=11, MULTILINE_TEXT=12;
	public const int
		RULE_file = 0, RULE_paragraph = 1, RULE_commentDefinition = 2, RULE_importDefinition = 3, 
		RULE_optionDefinition = 4, RULE_errorDefinition = 5, RULE_templateDefinition = 6, 
		RULE_templateNameLine = 7, RULE_templateBody = 8, RULE_templateBodyLine = 9;
	public static readonly string[] ruleNames = {
		"file", "paragraph", "commentDefinition", "importDefinition", "optionDefinition", 
		"errorDefinition", "templateDefinition", "templateNameLine", "templateBody", 
		"templateBodyLine"
	};

	private static readonly string[] _LiteralNames = {
		null, null, null, null, null, null, null, null, null, null, "'```'"
	};
	private static readonly string[] _SymbolicNames = {
		null, "NEWLINE", "OPTION", "COMMENT", "IMPORT", "TEMPLATE_NAME_LINE", 
		"INLINE_MULTILINE", "MULTILINE_PREFIX", "TEMPLATE_BODY", "INVALID_LINE", 
		"MULTILINE_SUFFIX", "ESCAPE_CHARACTER", "MULTILINE_TEXT"
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

	public override string GrammarFileName { get { return "LGFileParser.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override int[] SerializedAtn { get { return _serializedATN; } }

	static LGFileParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public LGFileParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public LGFileParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

	public partial class FileContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode Eof() { return GetToken(LGFileParser.Eof, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ParagraphContext[] paragraph() {
			return GetRuleContexts<ParagraphContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public ParagraphContext paragraph(int i) {
			return GetRuleContext<ParagraphContext>(i);
		}
		public FileContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_file; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterFile(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitFile(this);
		}
	}

	[RuleVersion(0)]
	public FileContext file() {
		FileContext _localctx = new FileContext(Context, State);
		EnterRule(_localctx, 0, RULE_file);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 21;
			ErrorHandler.Sync(this);
			_alt = 1+1;
			do {
				switch (_alt) {
				case 1+1:
					{
					{
					State = 20;
					paragraph();
					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 23;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,0,Context);
			} while ( _alt!=1 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER );
			State = 25;
			Match(Eof);
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

	public partial class ParagraphContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TemplateDefinitionContext templateDefinition() {
			return GetRuleContext<TemplateDefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ImportDefinitionContext importDefinition() {
			return GetRuleContext<ImportDefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public OptionDefinitionContext optionDefinition() {
			return GetRuleContext<OptionDefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ErrorDefinitionContext errorDefinition() {
			return GetRuleContext<ErrorDefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public CommentDefinitionContext commentDefinition() {
			return GetRuleContext<CommentDefinitionContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		public ParagraphContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_paragraph; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterParagraph(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitParagraph(this);
		}
	}

	[RuleVersion(0)]
	public ParagraphContext paragraph() {
		ParagraphContext _localctx = new ParagraphContext(Context, State);
		EnterRule(_localctx, 2, RULE_paragraph);
		try {
			State = 33;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case TEMPLATE_NAME_LINE:
				EnterOuterAlt(_localctx, 1);
				{
				State = 27;
				templateDefinition();
				}
				break;
			case IMPORT:
				EnterOuterAlt(_localctx, 2);
				{
				State = 28;
				importDefinition();
				}
				break;
			case OPTION:
				EnterOuterAlt(_localctx, 3);
				{
				State = 29;
				optionDefinition();
				}
				break;
			case INVALID_LINE:
				EnterOuterAlt(_localctx, 4);
				{
				State = 30;
				errorDefinition();
				}
				break;
			case COMMENT:
				EnterOuterAlt(_localctx, 5);
				{
				State = 31;
				commentDefinition();
				}
				break;
			case NEWLINE:
				EnterOuterAlt(_localctx, 6);
				{
				State = 32;
				Match(NEWLINE);
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

	public partial class CommentDefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode COMMENT() { return GetToken(LGFileParser.COMMENT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		public CommentDefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_commentDefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterCommentDefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitCommentDefinition(this);
		}
	}

	[RuleVersion(0)]
	public CommentDefinitionContext commentDefinition() {
		CommentDefinitionContext _localctx = new CommentDefinitionContext(Context, State);
		EnterRule(_localctx, 4, RULE_commentDefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 35;
			Match(COMMENT);
			State = 37;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{
				State = 36;
				Match(NEWLINE);
				}
				break;
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

	public partial class ImportDefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode IMPORT() { return GetToken(LGFileParser.IMPORT, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		public ImportDefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_importDefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterImportDefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitImportDefinition(this);
		}
	}

	[RuleVersion(0)]
	public ImportDefinitionContext importDefinition() {
		ImportDefinitionContext _localctx = new ImportDefinitionContext(Context, State);
		EnterRule(_localctx, 6, RULE_importDefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39;
			Match(IMPORT);
			State = 41;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				{
				State = 40;
				Match(NEWLINE);
				}
				break;
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

	public partial class OptionDefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode OPTION() { return GetToken(LGFileParser.OPTION, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		public OptionDefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_optionDefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterOptionDefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitOptionDefinition(this);
		}
	}

	[RuleVersion(0)]
	public OptionDefinitionContext optionDefinition() {
		OptionDefinitionContext _localctx = new OptionDefinitionContext(Context, State);
		EnterRule(_localctx, 8, RULE_optionDefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 43;
			Match(OPTION);
			State = 45;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,4,Context) ) {
			case 1:
				{
				State = 44;
				Match(NEWLINE);
				}
				break;
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

	public partial class ErrorDefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INVALID_LINE() { return GetToken(LGFileParser.INVALID_LINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		public ErrorDefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_errorDefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterErrorDefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitErrorDefinition(this);
		}
	}

	[RuleVersion(0)]
	public ErrorDefinitionContext errorDefinition() {
		ErrorDefinitionContext _localctx = new ErrorDefinitionContext(Context, State);
		EnterRule(_localctx, 10, RULE_errorDefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 47;
			Match(INVALID_LINE);
			State = 49;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				{
				State = 48;
				Match(NEWLINE);
				}
				break;
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

	public partial class TemplateDefinitionContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TemplateNameLineContext templateNameLine() {
			return GetRuleContext<TemplateNameLineContext>(0);
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemplateBodyContext templateBody() {
			return GetRuleContext<TemplateBodyContext>(0);
		}
		public TemplateDefinitionContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateDefinition; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterTemplateDefinition(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitTemplateDefinition(this);
		}
	}

	[RuleVersion(0)]
	public TemplateDefinitionContext templateDefinition() {
		TemplateDefinitionContext _localctx = new TemplateDefinitionContext(Context, State);
		EnterRule(_localctx, 12, RULE_templateDefinition);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 51;
			templateNameLine();
			State = 52;
			templateBody();
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

	public partial class TemplateNameLineContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMPLATE_NAME_LINE() { return GetToken(LGFileParser.TEMPLATE_NAME_LINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		public TemplateNameLineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateNameLine; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterTemplateNameLine(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitTemplateNameLine(this);
		}
	}

	[RuleVersion(0)]
	public TemplateNameLineContext templateNameLine() {
		TemplateNameLineContext _localctx = new TemplateNameLineContext(Context, State);
		EnterRule(_localctx, 14, RULE_templateNameLine);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 54;
			Match(TEMPLATE_NAME_LINE);
			State = 56;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
			case 1:
				{
				State = 55;
				Match(NEWLINE);
				}
				break;
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

	public partial class TemplateBodyContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public TemplateBodyLineContext[] templateBodyLine() {
			return GetRuleContexts<TemplateBodyLineContext>();
		}
		[System.Diagnostics.DebuggerNonUserCode] public TemplateBodyLineContext templateBodyLine(int i) {
			return GetRuleContext<TemplateBodyLineContext>(i);
		}
		public TemplateBodyContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateBody; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterTemplateBody(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitTemplateBody(this);
		}
	}

	[RuleVersion(0)]
	public TemplateBodyContext templateBody() {
		TemplateBodyContext _localctx = new TemplateBodyContext(Context, State);
		EnterRule(_localctx, 16, RULE_templateBody);
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 61;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					{
					{
					State = 58;
					templateBodyLine();
					}
					} 
				}
				State = 63;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
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

	public partial class TemplateBodyLineContext : ParserRuleContext {
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode TEMPLATE_BODY() { return GetToken(LGFileParser.TEMPLATE_BODY, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode INLINE_MULTILINE() { return GetToken(LGFileParser.INLINE_MULTILINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode NEWLINE() { return GetToken(LGFileParser.NEWLINE, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MULTILINE_PREFIX() { return GetToken(LGFileParser.MULTILINE_PREFIX, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MULTILINE_SUFFIX() { return GetToken(LGFileParser.MULTILINE_SUFFIX, 0); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] MULTILINE_TEXT() { return GetTokens(LGFileParser.MULTILINE_TEXT); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode MULTILINE_TEXT(int i) {
			return GetToken(LGFileParser.MULTILINE_TEXT, i);
		}
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode[] ESCAPE_CHARACTER() { return GetTokens(LGFileParser.ESCAPE_CHARACTER); }
		[System.Diagnostics.DebuggerNonUserCode] public ITerminalNode ESCAPE_CHARACTER(int i) {
			return GetToken(LGFileParser.ESCAPE_CHARACTER, i);
		}
		public TemplateBodyLineContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_templateBodyLine; } }
		[System.Diagnostics.DebuggerNonUserCode]
		public override void EnterRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.EnterTemplateBodyLine(this);
		}
		[System.Diagnostics.DebuggerNonUserCode]
		public override void ExitRule(IParseTreeListener listener) {
			ILGFileParserListener typedListener = listener as ILGFileParserListener;
			if (typedListener != null) typedListener.ExitTemplateBodyLine(this);
		}
	}

	[RuleVersion(0)]
	public TemplateBodyLineContext templateBodyLine() {
		TemplateBodyLineContext _localctx = new TemplateBodyLineContext(Context, State);
		EnterRule(_localctx, 18, RULE_templateBodyLine);
		int _la;
		try {
			State = 82;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case INLINE_MULTILINE:
			case MULTILINE_PREFIX:
			case TEMPLATE_BODY:
				EnterOuterAlt(_localctx, 1);
				{
				{
				State = 76;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case TEMPLATE_BODY:
					{
					State = 64;
					Match(TEMPLATE_BODY);
					}
					break;
				case INLINE_MULTILINE:
					{
					State = 65;
					Match(INLINE_MULTILINE);
					}
					break;
				case MULTILINE_PREFIX:
					{
					{
					State = 66;
					Match(MULTILINE_PREFIX);
					State = 70;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==ESCAPE_CHARACTER || _la==MULTILINE_TEXT) {
						{
						{
						State = 67;
						_la = TokenStream.LA(1);
						if ( !(_la==ESCAPE_CHARACTER || _la==MULTILINE_TEXT) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						}
						}
						State = 72;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					State = 74;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					if (_la==MULTILINE_SUFFIX) {
						{
						State = 73;
						Match(MULTILINE_SUFFIX);
						}
					}

					}
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 79;
				ErrorHandler.Sync(this);
				switch ( Interpreter.AdaptivePredict(TokenStream,11,Context) ) {
				case 1:
					{
					State = 78;
					Match(NEWLINE);
					}
					break;
				}
				}
				}
				break;
			case NEWLINE:
				EnterOuterAlt(_localctx, 2);
				{
				State = 81;
				Match(NEWLINE);
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

	private static int[] _serializedATN = {
		4,1,12,85,2,0,7,0,2,1,7,1,2,2,7,2,2,3,7,3,2,4,7,4,2,5,7,5,2,6,7,6,2,7,
		7,7,2,8,7,8,2,9,7,9,1,0,4,0,22,8,0,11,0,12,0,23,1,0,1,0,1,1,1,1,1,1,1,
		1,1,1,1,1,3,1,34,8,1,1,2,1,2,3,2,38,8,2,1,3,1,3,3,3,42,8,3,1,4,1,4,3,4,
		46,8,4,1,5,1,5,3,5,50,8,5,1,6,1,6,1,6,1,7,1,7,3,7,57,8,7,1,8,5,8,60,8,
		8,10,8,12,8,63,9,8,1,9,1,9,1,9,1,9,5,9,69,8,9,10,9,12,9,72,9,9,1,9,3,9,
		75,8,9,3,9,77,8,9,1,9,3,9,80,8,9,1,9,3,9,83,8,9,1,9,1,23,0,10,0,2,4,6,
		8,10,12,14,16,18,0,1,1,0,11,12,92,0,21,1,0,0,0,2,33,1,0,0,0,4,35,1,0,0,
		0,6,39,1,0,0,0,8,43,1,0,0,0,10,47,1,0,0,0,12,51,1,0,0,0,14,54,1,0,0,0,
		16,61,1,0,0,0,18,82,1,0,0,0,20,22,3,2,1,0,21,20,1,0,0,0,22,23,1,0,0,0,
		23,24,1,0,0,0,23,21,1,0,0,0,24,25,1,0,0,0,25,26,5,0,0,1,26,1,1,0,0,0,27,
		34,3,12,6,0,28,34,3,6,3,0,29,34,3,8,4,0,30,34,3,10,5,0,31,34,3,4,2,0,32,
		34,5,1,0,0,33,27,1,0,0,0,33,28,1,0,0,0,33,29,1,0,0,0,33,30,1,0,0,0,33,
		31,1,0,0,0,33,32,1,0,0,0,34,3,1,0,0,0,35,37,5,3,0,0,36,38,5,1,0,0,37,36,
		1,0,0,0,37,38,1,0,0,0,38,5,1,0,0,0,39,41,5,4,0,0,40,42,5,1,0,0,41,40,1,
		0,0,0,41,42,1,0,0,0,42,7,1,0,0,0,43,45,5,2,0,0,44,46,5,1,0,0,45,44,1,0,
		0,0,45,46,1,0,0,0,46,9,1,0,0,0,47,49,5,9,0,0,48,50,5,1,0,0,49,48,1,0,0,
		0,49,50,1,0,0,0,50,11,1,0,0,0,51,52,3,14,7,0,52,53,3,16,8,0,53,13,1,0,
		0,0,54,56,5,5,0,0,55,57,5,1,0,0,56,55,1,0,0,0,56,57,1,0,0,0,57,15,1,0,
		0,0,58,60,3,18,9,0,59,58,1,0,0,0,60,63,1,0,0,0,61,59,1,0,0,0,61,62,1,0,
		0,0,62,17,1,0,0,0,63,61,1,0,0,0,64,77,5,8,0,0,65,77,5,6,0,0,66,70,5,7,
		0,0,67,69,7,0,0,0,68,67,1,0,0,0,69,72,1,0,0,0,70,68,1,0,0,0,70,71,1,0,
		0,0,71,74,1,0,0,0,72,70,1,0,0,0,73,75,5,10,0,0,74,73,1,0,0,0,74,75,1,0,
		0,0,75,77,1,0,0,0,76,64,1,0,0,0,76,65,1,0,0,0,76,66,1,0,0,0,77,79,1,0,
		0,0,78,80,5,1,0,0,79,78,1,0,0,0,79,80,1,0,0,0,80,83,1,0,0,0,81,83,5,1,
		0,0,82,76,1,0,0,0,82,81,1,0,0,0,83,19,1,0,0,0,13,23,33,37,41,45,49,56,
		61,70,74,76,79,82
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
