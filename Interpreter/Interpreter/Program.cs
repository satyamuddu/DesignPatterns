// See https://aka.ms/new-console-template for more information
using Interpreter;

Console.WriteLine("Hello, World!");


//String context = "Lions";
//String context = "Tigers";
//String context = "Bears";
//String context = "Lions Tigers";
//String context = "Lions Bears";
IContext context = new StringContext( "Lions");

IExpression define = BuildIterpreterTree();
Console.WriteLine(context.Data + " is " + define.Interpret(context));

static IExpression BuildIterpreterTree()
{
	IContext lions = new StringContext("Lions");
	IContext tigers = new StringContext("Tigers");
	IContext bears = new StringContext("Bears");
	IExpression lionsExpression = new TerminalExpression(lions);
	IExpression tigersExpression = new TerminalExpression(tigers);
	IExpression bearsExpression = new TerminalExpression(bears);

	// Tigers and Bears
	IExpression alternation1 = new AndExpression(tigersExpression, bearsExpression);

	// Lions or (Tigers and Bears)
	IExpression alternation2 = new OrExpression(lionsExpression, alternation1);
	return new AndExpression(bearsExpression, alternation2);
}
