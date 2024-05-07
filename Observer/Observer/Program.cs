// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

ConcreteSubject s = new ConcreteSubject();
s.Attach(new ConcreteObserver(s, "X"));
s.Attach(new ConcreteObserver(s, "Y"));
s.Attach(new ConcreteObserver(s, "Z"));
// Change subject and notify observers
s.SubjectState = "ABC";
s.Notify();