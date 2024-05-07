// See https://aka.ms/new-console-template for more information
using State;

Console.WriteLine("Hello, World!");
var context = new Context(new ConcreteStateA());
// Issue requests, which toggles state
context.Request();
context.Request();
context.Request();
context.Request();