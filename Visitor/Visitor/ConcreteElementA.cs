// See https://aka.ms/new-console-template for more information
public class ConcreteElementA : IElement
{
	public void Accept(IVisitor visitor)
	{
		visitor.VisitConcreteElementA(this);
	}
}