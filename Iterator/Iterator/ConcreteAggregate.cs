// See https://aka.ms/new-console-template for more information
internal class ConcreteAggregate : Aggregate
{
	private List<object> items = new List<object>();

	public int Count
	{
		get { return items.Count; }
	}
	// Indexer
	public object this[int index]
	{
		get { return items[index]; }
		set { items.Insert(index, value); }
	}

	public override Iterator CreateIterator()
	{
		return new ConcreteIterator(this);
	}
}