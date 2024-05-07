// See https://aka.ms/new-console-template for more information
internal interface IElement
{
	void Accept(IVisitor visitor);
}