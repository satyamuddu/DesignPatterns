// See https://aka.ms/new-console-template for more information
public interface IVisitor
{
	public abstract void VisitConcreteElementA(
		   ConcreteElementA concreteElementA);
	public abstract void VisitConcreteElementB(
		ConcreteElementB concreteElementB);
}