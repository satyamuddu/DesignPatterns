// See https://aka.ms/new-console-template for more information
using System.Xml.Linq;

internal class ObjectStructure
{
	public ObjectStructure()
	{
	}
	List<IElement> IElements = new List<IElement>();
	public void Attach(IElement IElement)
	{
		IElements.Add(IElement);
	}
	public void Detach(IElement IElement)
	{
		IElements.Remove(IElement);
	}
	public void Accept(IVisitor visitor)
	{
		foreach (IElement IElement in IElements)
		{
			IElement.Accept(visitor);
		}
	}
}