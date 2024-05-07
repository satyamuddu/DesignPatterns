// See https://aka.ms/new-console-template for more information
using ChainOfResponsibility;

Console.WriteLine("Hello, World!");
Handler<IType> h1 = new ConcreteHandler1<IType>();
Handler<IType> h2 = new ConcreteHandler2<IType>();
Handler<IType> h3 = new ConcreteHandler3<IType>();
h1.SetSuccessor(h2);
h2.SetSuccessor(h3);


// Generate and process request
int[] requests = { 2, 5, 14, 22, 18, 3, 27, 20 };

List<IType> responses = new List<IType>();

foreach (int request in requests)
{
	IType response = new IntType(request);
	responses.Add(response);
	h1.HandleRequest(response);
}
