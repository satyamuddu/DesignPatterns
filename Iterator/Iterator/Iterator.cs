// See https://aka.ms/new-console-template for more information
public abstract class Iterator
{
	public abstract object First();
	public abstract object Next();
	public abstract bool IsDone();
	public abstract object CurrentItem();
}