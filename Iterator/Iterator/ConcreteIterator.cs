// See https://aka.ms/new-console-template for more information
internal class ConcreteIterator : Iterator
{
	private ConcreteAggregate concreteAggregate;
	private int current = 0;

	public ConcreteIterator(ConcreteAggregate concreteAggregate)
	{
		this.concreteAggregate = concreteAggregate;
	}

	public override object CurrentItem()
	{
		return concreteAggregate[current];
	}

	public override object First()
	{
		return concreteAggregate[0];
	}

	public override bool IsDone()
	{
		return current>=concreteAggregate.Count;
	}

	public override object Next()
	{
		object ret = null;
		if (current < concreteAggregate.Count - 1)
		{
			ret = concreteAggregate[++current];
		}
		return ret;
	}
}