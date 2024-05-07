// See https://aka.ms/new-console-template for more information
using Visitor;


ObjectStructure o = new ObjectStructure();

o.Attach(new ConcreteElementA());
o.Attach(new ConcreteElementB());
// Create visitor objects
ConcreteVisitor1 v1 = new ConcreteVisitor1();
ConcreteVisitor2 v2 = new ConcreteVisitor2();
// Structure accepting visitors
o.Accept(v1);
o.Accept(v2);
