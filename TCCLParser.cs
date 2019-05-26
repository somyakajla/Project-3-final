// This code was generated by the Gardens Point Parser Generator
// Copyright (c) Wayne Kelly, John Gough, QUT 2005-2014
// (see accompanying GPPGcopyright.rtf)

// GPPG version 1.5.2
// Machine:  RJL-SURFACE4
// DateTime: 5/5/2017 1:55:19 PM
// UserName: Richard LeBlanc
// Input file <TCCL.grammar.y - 5/4/2017 11:20:58 PM>

// options: conflicts no-lines diagnose & report gplex conflicts

using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using System.Globalization;
using System.Text;
using QUT.Gppg;

namespace ASTBuilder
{
internal enum Token {error=2,EOF=3,STATIC=4,STRUCT=5,QUESTION=6,
    RSLASH=7,MINUSOP=8,NULL=9,INT=10,OP_EQ=11,OP_LT=12,
    COLON=13,OP_LOR=14,ELSE=15,PERCENT=16,THIS=17,CLASS=18,
    PIPE=19,PUBLIC=20,PERIOD=21,HAT=22,COMMA=23,VOID=24,
    TILDE=25,LPAREN=26,RPAREN=27,OP_GE=28,SEMICOLON=29,IF=30,
    NEW=31,WHILE=32,PRIVATE=33,BANG=34,OP_LE=35,AND=36,
    LBRACE=37,RBRACE=38,LBRACKET=39,RBRACKET=40,BOOLEAN=41,INSTANCEOF=42,
    ASTERISK=43,EQUALS=44,PLUSOP=45,RETURN=46,OP_GT=47,OP_NE=48,
    OP_LAND=49,INT_NUMBER=50,IDENTIFIER=51,LITERAL=52,SUPER=53,UNARY=54};

// Abstract base class for GPLEX scanners
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal abstract class ScanBase : AbstractScanner<AST.Node,LexLocation> {
  private LexLocation __yylloc = new LexLocation();
  public override LexLocation yylloc { get { return __yylloc; } set { __yylloc = value; } }
  protected virtual bool yywrap() { return true; }
}

// Utility class for encapsulating token information
[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal class ScanObj {
  public int token;
  public AST.Node yylval;
  public LexLocation yylloc;
  public ScanObj( int t, AST.Node val, LexLocation loc ) {
    this.token = t; this.yylval = val; this.yylloc = loc;
  }
}

[GeneratedCodeAttribute( "Gardens Point Parser Generator", "1.5.2")]
internal partial class TCCLParser: ShiftReduceParser<AST.Node, LexLocation>
{
#pragma warning disable 649
  private static Dictionary<int, string> aliases;
#pragma warning restore 649
  private static Rule[] rules = new Rule[110];
  private static State[] states = new State[175];
  private static string[] nonTerms = new string[] {
      "CompilationUnit", "$accept", "ClassDeclaration", "Modifiers", "Identifier", 
      "ClassBody", "FieldDeclarations", "FieldDeclaration", "FieldVariableDeclaration", 
      "MethodDeclaration", "ConstructorDeclaration", "StaticInitializer", "StructDeclaration", 
      "TypeSpecifier", "FieldVariableDeclarators", "TypeName", "ArraySpecifier", 
      "PrimitiveType", "QualifiedName", "FieldVariableDeclaratorName", "MethodDeclarator", 
      "MethodBody", "MethodDeclaratorName", "ParameterList", "Parameter", "DeclaratorName", 
      "LocalVariableDeclaratorName", "Block", "LocalVariableDeclarationsAndStatements", 
      "LocalVariableDeclarationOrStatement", "LocalVariableDeclarationStatement", 
      "Statement", "LocalVariableDeclarators", "EmptyStatement", "ExpressionStatement", 
      "SelectionStatement", "IterationStatement", "ReturnStatement", "Expression", 
      "ArgumentList", "ArithmeticUnaryOperator", "PrimaryExpression", "NotJustName", 
      "SpecialName", "ComplexPrimary", "ComplexPrimaryNoParenthesis", "Number", 
      "FieldAccess", "MethodCall", "MethodReference", };

  static TCCLParser() {
    states[0] = new State(new int[]{20,119,33,120,4,121},new int[]{-1,1,-3,3,-4,4});
    states[1] = new State(new int[]{3,2});
    states[2] = new State(-1);
    states[3] = new State(-2);
    states[4] = new State(new int[]{18,5,20,116,33,117,4,118});
    states[5] = new State(new int[]{51,20},new int[]{-5,6});
    states[6] = new State(new int[]{37,8},new int[]{-6,7});
    states[7] = new State(-3);
    states[8] = new State(new int[]{38,173,20,119,33,120,4,167},new int[]{-7,9,-8,174,-9,12,-4,14,-10,169,-11,170,-12,171,-13,172});
    states[9] = new State(new int[]{38,10,20,119,33,120,4,167},new int[]{-8,11,-9,12,-4,14,-10,169,-11,170,-12,171,-13,172});
    states[10] = new State(-10);
    states[11] = new State(-13);
    states[12] = new State(new int[]{29,13});
    states[13] = new State(-14);
    states[14] = new State(new int[]{20,116,33,117,4,118,5,113,41,40,10,41,51,20},new int[]{-14,15,-21,164,-16,36,-18,39,-19,161,-5,166,-17,110,-23,152});
    states[15] = new State(new int[]{51,20},new int[]{-15,16,-21,21,-20,150,-5,151,-23,152});
    states[16] = new State(new int[]{23,17,29,-20});
    states[17] = new State(new int[]{51,20},new int[]{-20,18,-5,19});
    states[18] = new State(-29);
    states[19] = new State(-40);
    states[20] = new State(-108);
    states[21] = new State(new int[]{37,24},new int[]{-22,22,-28,23});
    states[22] = new State(-30);
    states[23] = new State(-42);
    states[24] = new State(new int[]{38,148,41,40,10,41,51,20,20,119,33,120,4,121,29,124,45,83,8,84,17,90,9,91,26,93,52,97,50,99,30,129,32,137,46,143,37,24},new int[]{-29,25,-30,149,-31,28,-14,29,-16,36,-18,39,-19,42,-5,80,-17,110,-13,111,-4,112,-32,122,-34,123,-35,125,-39,127,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102,-36,128,-37,136,-38,142,-28,147});
    states[25] = new State(new int[]{38,26,41,40,10,41,51,20,20,119,33,120,4,121,29,124,45,83,8,84,17,90,9,91,26,93,52,97,50,99,30,129,32,137,46,143,37,24},new int[]{-30,27,-31,28,-14,29,-16,36,-18,39,-19,42,-5,80,-17,110,-13,111,-4,112,-32,122,-34,123,-35,125,-39,127,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102,-36,128,-37,136,-38,142,-28,147});
    states[26] = new State(-45);
    states[27] = new State(-48);
    states[28] = new State(-49);
    states[29] = new State(new int[]{51,20},new int[]{-33,30,-27,35,-5,34});
    states[30] = new State(new int[]{29,31,23,32});
    states[31] = new State(-51);
    states[32] = new State(new int[]{51,20},new int[]{-27,33,-5,34});
    states[33] = new State(-54);
    states[34] = new State(-41);
    states[35] = new State(-53);
    states[36] = new State(new int[]{39,37,51,-21});
    states[37] = new State(new int[]{40,38});
    states[38] = new State(-25);
    states[39] = new State(-23);
    states[40] = new State(-26);
    states[41] = new State(-27);
    states[42] = new State(new int[]{21,43,44,45,39,-24,51,-24,14,-90,49,-90,19,-90,22,-90,36,-90,11,-90,48,-90,47,-90,12,-90,35,-90,28,-90,45,-90,8,-90,43,-90,7,-90,16,-90,29,-90,26,-104});
    states[43] = new State(new int[]{51,20},new int[]{-5,44});
    states[44] = new State(-37);
    states[45] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,46,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[46] = new State(new int[]{14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-69,27,-69,23,-69});
    states[47] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,48,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[48] = new State(new int[]{14,-70,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-70,27,-70,23,-70});
    states[49] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,50,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[50] = new State(new int[]{14,-71,49,-71,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-71,27,-71,23,-71});
    states[51] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,52,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[52] = new State(new int[]{14,-72,49,-72,19,-72,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-72,27,-72,23,-72});
    states[53] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,54,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[54] = new State(new int[]{14,-73,49,-73,19,-73,22,-73,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-73,27,-73,23,-73});
    states[55] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,56,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[56] = new State(new int[]{14,-74,49,-74,19,-74,22,-74,36,-74,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-74,27,-74,23,-74});
    states[57] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,58,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[58] = new State(new int[]{14,-75,49,-75,19,-75,22,-75,36,-75,11,-75,48,-75,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-75,27,-75,23,-75});
    states[59] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,60,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[60] = new State(new int[]{14,-76,49,-76,19,-76,22,-76,36,-76,11,-76,48,-76,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-76,27,-76,23,-76});
    states[61] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,62,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[62] = new State(new int[]{14,-77,49,-77,19,-77,22,-77,36,-77,11,-77,48,-77,47,-77,12,-77,35,-77,28,-77,45,69,8,71,43,73,7,75,16,77,29,-77,27,-77,23,-77});
    states[63] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,64,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[64] = new State(new int[]{14,-78,49,-78,19,-78,22,-78,36,-78,11,-78,48,-78,47,-78,12,-78,35,-78,28,-78,45,69,8,71,43,73,7,75,16,77,29,-78,27,-78,23,-78});
    states[65] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,66,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[66] = new State(new int[]{14,-79,49,-79,19,-79,22,-79,36,-79,11,-79,48,-79,47,-79,12,-79,35,-79,28,-79,45,69,8,71,43,73,7,75,16,77,29,-79,27,-79,23,-79});
    states[67] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,68,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[68] = new State(new int[]{14,-80,49,-80,19,-80,22,-80,36,-80,11,-80,48,-80,47,-80,12,-80,35,-80,28,-80,45,69,8,71,43,73,7,75,16,77,29,-80,27,-80,23,-80});
    states[69] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,70,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[70] = new State(new int[]{14,-81,49,-81,19,-81,22,-81,36,-81,11,-81,48,-81,47,-81,12,-81,35,-81,28,-81,45,-81,8,-81,43,73,7,75,16,77,29,-81,27,-81,23,-81});
    states[71] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,72,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[72] = new State(new int[]{14,-82,49,-82,19,-82,22,-82,36,-82,11,-82,48,-82,47,-82,12,-82,35,-82,28,-82,45,-82,8,-82,43,73,7,75,16,77,29,-82,27,-82,23,-82});
    states[73] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,74,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[74] = new State(-83);
    states[75] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,76,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[76] = new State(-84);
    states[77] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,78,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[78] = new State(-85);
    states[79] = new State(new int[]{44,45,21,43,14,-90,49,-90,19,-90,22,-90,36,-90,11,-90,48,-90,47,-90,12,-90,35,-90,28,-90,45,-90,8,-90,43,-90,7,-90,16,-90,29,-90,27,-90,23,-90,26,-104});
    states[80] = new State(-36);
    states[81] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,82,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[82] = new State(-86);
    states[83] = new State(-88);
    states[84] = new State(-89);
    states[85] = new State(-87);
    states[86] = new State(new int[]{21,87,14,-91,49,-91,19,-91,22,-91,36,-91,11,-91,48,-91,47,-91,12,-91,35,-91,28,-91,45,-91,8,-91,43,-91,7,-91,16,-91,29,-91,27,-91,23,-91});
    states[87] = new State(new int[]{51,20},new int[]{-5,88});
    states[88] = new State(-100);
    states[89] = new State(new int[]{21,-92,14,-92,49,-92,19,-92,22,-92,36,-92,11,-92,48,-92,47,-92,12,-92,35,-92,28,-92,45,-92,8,-92,43,-92,7,-92,16,-92,29,-92,27,-92,23,-92,26,-105});
    states[90] = new State(-106);
    states[91] = new State(-107);
    states[92] = new State(-93);
    states[93] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,94,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[94] = new State(new int[]{27,95,14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77});
    states[95] = new State(-94);
    states[96] = new State(new int[]{21,-95,14,-95,49,-95,19,-95,22,-95,36,-95,11,-95,48,-95,47,-95,12,-95,35,-95,28,-95,45,-95,8,-95,43,-95,7,-95,16,-95,29,-95,27,-95,23,-95,26,-103});
    states[97] = new State(-96);
    states[98] = new State(-97);
    states[99] = new State(-109);
    states[100] = new State(-98);
    states[101] = new State(-99);
    states[102] = new State(new int[]{26,103});
    states[103] = new State(new int[]{27,108,51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-40,104,-39,109,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[104] = new State(new int[]{27,105,23,106});
    states[105] = new State(-101);
    states[106] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,107,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[107] = new State(new int[]{14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,27,-68,23,-68});
    states[108] = new State(-102);
    states[109] = new State(new int[]{14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,27,-67,23,-67});
    states[110] = new State(-22);
    states[111] = new State(-52);
    states[112] = new State(new int[]{5,113,20,116,33,117,4,118});
    states[113] = new State(new int[]{51,20},new int[]{-5,114});
    states[114] = new State(new int[]{37,8},new int[]{-6,115});
    states[115] = new State(-19);
    states[116] = new State(-7);
    states[117] = new State(-8);
    states[118] = new State(-9);
    states[119] = new State(-4);
    states[120] = new State(-5);
    states[121] = new State(-6);
    states[122] = new State(-50);
    states[123] = new State(-55);
    states[124] = new State(-61);
    states[125] = new State(new int[]{29,126});
    states[126] = new State(-56);
    states[127] = new State(new int[]{14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77,29,-62});
    states[128] = new State(-57);
    states[129] = new State(new int[]{26,130});
    states[130] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,131,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[131] = new State(new int[]{27,132,14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77});
    states[132] = new State(new int[]{29,124,51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99,30,129,32,137,46,143,37,24},new int[]{-32,133,-34,123,-35,125,-39,127,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102,-36,128,-37,136,-38,142,-28,147});
    states[133] = new State(new int[]{15,134});
    states[134] = new State(new int[]{29,124,51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99,30,129,32,137,46,143,37,24},new int[]{-32,135,-34,123,-35,125,-39,127,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102,-36,128,-37,136,-38,142,-28,147});
    states[135] = new State(-63);
    states[136] = new State(-58);
    states[137] = new State(new int[]{26,138});
    states[138] = new State(new int[]{51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,139,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[139] = new State(new int[]{27,140,14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77});
    states[140] = new State(new int[]{29,124,51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99,30,129,32,137,46,143,37,24},new int[]{-32,141,-34,123,-35,125,-39,127,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102,-36,128,-37,136,-38,142,-28,147});
    states[141] = new State(-64);
    states[142] = new State(-59);
    states[143] = new State(new int[]{29,146,51,20,45,83,8,84,17,90,9,91,26,93,52,97,50,99},new int[]{-39,144,-19,79,-5,80,-41,81,-42,85,-43,86,-44,89,-45,92,-46,96,-47,98,-48,100,-49,101,-50,102});
    states[144] = new State(new int[]{29,145,14,47,49,49,19,51,22,53,36,55,11,57,48,59,47,61,12,63,35,65,28,67,45,69,8,71,43,73,7,75,16,77});
    states[145] = new State(-65);
    states[146] = new State(-66);
    states[147] = new State(-60);
    states[148] = new State(-46);
    states[149] = new State(-47);
    states[150] = new State(-28);
    states[151] = new State(new int[]{23,-40,29,-40,26,-39});
    states[152] = new State(new int[]{26,153});
    states[153] = new State(new int[]{27,162,41,40,10,41,51,20},new int[]{-24,154,-25,163,-14,158,-16,36,-18,39,-19,161,-5,80,-17,110});
    states[154] = new State(new int[]{27,155,23,156});
    states[155] = new State(-31);
    states[156] = new State(new int[]{41,40,10,41,51,20},new int[]{-25,157,-14,158,-16,36,-18,39,-19,161,-5,80,-17,110});
    states[157] = new State(-34);
    states[158] = new State(new int[]{51,20},new int[]{-26,159,-5,160});
    states[159] = new State(-35);
    states[160] = new State(-38);
    states[161] = new State(new int[]{21,43,39,-24,51,-24});
    states[162] = new State(-32);
    states[163] = new State(-33);
    states[164] = new State(new int[]{37,24},new int[]{-28,165});
    states[165] = new State(-43);
    states[166] = new State(new int[]{21,-36,39,-36,51,-36,26,-39});
    states[167] = new State(new int[]{37,24,20,-6,33,-6,4,-6,5,-6,41,-6,10,-6,51,-6},new int[]{-28,168});
    states[168] = new State(-44);
    states[169] = new State(-15);
    states[170] = new State(-16);
    states[171] = new State(-17);
    states[172] = new State(-18);
    states[173] = new State(-11);
    states[174] = new State(-12);

    for (int sNo = 0; sNo < states.Length; sNo++) states[sNo].number = sNo;

    rules[1] = new Rule(-2, new int[]{-1,3});
    rules[2] = new Rule(-1, new int[]{-3});
    rules[3] = new Rule(-3, new int[]{-4,18,-5,-6});
    rules[4] = new Rule(-4, new int[]{20});
    rules[5] = new Rule(-4, new int[]{33});
    rules[6] = new Rule(-4, new int[]{4});
    rules[7] = new Rule(-4, new int[]{-4,20});
    rules[8] = new Rule(-4, new int[]{-4,33});
    rules[9] = new Rule(-4, new int[]{-4,4});
    rules[10] = new Rule(-6, new int[]{37,-7,38});
    rules[11] = new Rule(-6, new int[]{37,38});
    rules[12] = new Rule(-7, new int[]{-8});
    rules[13] = new Rule(-7, new int[]{-7,-8});
    rules[14] = new Rule(-8, new int[]{-9,29});
    rules[15] = new Rule(-8, new int[]{-10});
    rules[16] = new Rule(-8, new int[]{-11});
    rules[17] = new Rule(-8, new int[]{-12});
    rules[18] = new Rule(-8, new int[]{-13});
    rules[19] = new Rule(-13, new int[]{-4,5,-5,-6});
    rules[20] = new Rule(-9, new int[]{-4,-14,-15});
    rules[21] = new Rule(-14, new int[]{-16});
    rules[22] = new Rule(-14, new int[]{-17});
    rules[23] = new Rule(-16, new int[]{-18});
    rules[24] = new Rule(-16, new int[]{-19});
    rules[25] = new Rule(-17, new int[]{-16,39,40});
    rules[26] = new Rule(-18, new int[]{41});
    rules[27] = new Rule(-18, new int[]{10});
    rules[28] = new Rule(-15, new int[]{-20});
    rules[29] = new Rule(-15, new int[]{-15,23,-20});
    rules[30] = new Rule(-10, new int[]{-4,-14,-21,-22});
    rules[31] = new Rule(-21, new int[]{-23,26,-24,27});
    rules[32] = new Rule(-21, new int[]{-23,26,27});
    rules[33] = new Rule(-24, new int[]{-25});
    rules[34] = new Rule(-24, new int[]{-24,23,-25});
    rules[35] = new Rule(-25, new int[]{-14,-26});
    rules[36] = new Rule(-19, new int[]{-5});
    rules[37] = new Rule(-19, new int[]{-19,21,-5});
    rules[38] = new Rule(-26, new int[]{-5});
    rules[39] = new Rule(-23, new int[]{-5});
    rules[40] = new Rule(-20, new int[]{-5});
    rules[41] = new Rule(-27, new int[]{-5});
    rules[42] = new Rule(-22, new int[]{-28});
    rules[43] = new Rule(-11, new int[]{-4,-21,-28});
    rules[44] = new Rule(-12, new int[]{4,-28});
    rules[45] = new Rule(-28, new int[]{37,-29,38});
    rules[46] = new Rule(-28, new int[]{37,38});
    rules[47] = new Rule(-29, new int[]{-30});
    rules[48] = new Rule(-29, new int[]{-29,-30});
    rules[49] = new Rule(-30, new int[]{-31});
    rules[50] = new Rule(-30, new int[]{-32});
    rules[51] = new Rule(-31, new int[]{-14,-33,29});
    rules[52] = new Rule(-31, new int[]{-13});
    rules[53] = new Rule(-33, new int[]{-27});
    rules[54] = new Rule(-33, new int[]{-33,23,-27});
    rules[55] = new Rule(-32, new int[]{-34});
    rules[56] = new Rule(-32, new int[]{-35,29});
    rules[57] = new Rule(-32, new int[]{-36});
    rules[58] = new Rule(-32, new int[]{-37});
    rules[59] = new Rule(-32, new int[]{-38});
    rules[60] = new Rule(-32, new int[]{-28});
    rules[61] = new Rule(-34, new int[]{29});
    rules[62] = new Rule(-35, new int[]{-39});
    rules[63] = new Rule(-36, new int[]{30,26,-39,27,-32,15,-32});
    rules[64] = new Rule(-37, new int[]{32,26,-39,27,-32});
    rules[65] = new Rule(-38, new int[]{46,-39,29});
    rules[66] = new Rule(-38, new int[]{46,29});
    rules[67] = new Rule(-40, new int[]{-39});
    rules[68] = new Rule(-40, new int[]{-40,23,-39});
    rules[69] = new Rule(-39, new int[]{-19,44,-39});
    rules[70] = new Rule(-39, new int[]{-39,14,-39});
    rules[71] = new Rule(-39, new int[]{-39,49,-39});
    rules[72] = new Rule(-39, new int[]{-39,19,-39});
    rules[73] = new Rule(-39, new int[]{-39,22,-39});
    rules[74] = new Rule(-39, new int[]{-39,36,-39});
    rules[75] = new Rule(-39, new int[]{-39,11,-39});
    rules[76] = new Rule(-39, new int[]{-39,48,-39});
    rules[77] = new Rule(-39, new int[]{-39,47,-39});
    rules[78] = new Rule(-39, new int[]{-39,12,-39});
    rules[79] = new Rule(-39, new int[]{-39,35,-39});
    rules[80] = new Rule(-39, new int[]{-39,28,-39});
    rules[81] = new Rule(-39, new int[]{-39,45,-39});
    rules[82] = new Rule(-39, new int[]{-39,8,-39});
    rules[83] = new Rule(-39, new int[]{-39,43,-39});
    rules[84] = new Rule(-39, new int[]{-39,7,-39});
    rules[85] = new Rule(-39, new int[]{-39,16,-39});
    rules[86] = new Rule(-39, new int[]{-41,-39});
    rules[87] = new Rule(-39, new int[]{-42});
    rules[88] = new Rule(-41, new int[]{45});
    rules[89] = new Rule(-41, new int[]{8});
    rules[90] = new Rule(-42, new int[]{-19});
    rules[91] = new Rule(-42, new int[]{-43});
    rules[92] = new Rule(-43, new int[]{-44});
    rules[93] = new Rule(-43, new int[]{-45});
    rules[94] = new Rule(-45, new int[]{26,-39,27});
    rules[95] = new Rule(-45, new int[]{-46});
    rules[96] = new Rule(-46, new int[]{52});
    rules[97] = new Rule(-46, new int[]{-47});
    rules[98] = new Rule(-46, new int[]{-48});
    rules[99] = new Rule(-46, new int[]{-49});
    rules[100] = new Rule(-48, new int[]{-43,21,-5});
    rules[101] = new Rule(-49, new int[]{-50,26,-40,27});
    rules[102] = new Rule(-49, new int[]{-50,26,27});
    rules[103] = new Rule(-50, new int[]{-46});
    rules[104] = new Rule(-50, new int[]{-19});
    rules[105] = new Rule(-50, new int[]{-44});
    rules[106] = new Rule(-44, new int[]{17});
    rules[107] = new Rule(-44, new int[]{9});
    rules[108] = new Rule(-5, new int[]{51});
    rules[109] = new Rule(-47, new int[]{50});
  }

  protected override void Initialize() {
    this.InitSpecialTokens((int)Token.error, (int)Token.EOF);
    this.InitStates(states);
    this.InitRules(rules);
    this.InitNonTerminals(nonTerms);
  }

  protected override void DoAction(int action)
  {
#pragma warning disable 162, 1522
    switch (action)
    {
      case 52: // LocalVariableDeclarationStatement -> StructDeclaration
{ CurrentSemanticValue = new AST.LocalVariableDeclarationStatement(ValueStack[ValueStack.Depth-1] as AST.ClassDeclaration); }
        break;
    }
#pragma warning restore 162, 1522
  }

  protected override string TerminalToString(int terminal)
  {
    if (aliases != null && aliases.ContainsKey(terminal))
        return aliases[terminal];
    else if (((Token)terminal).ToString() != terminal.ToString(CultureInfo.InvariantCulture))
        return ((Token)terminal).ToString();
    else
        return CharToString((char)terminal);
  }

}
}