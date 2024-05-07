// See https://aka.ms/new-console-template for more information
public class ConcreteElementB : IElement
{
	public void Accept(IVisitor visitor)
	{
		visitor.VisitConcreteElementB(this);
	}
}