// See https://aka.ms/new-console-template for more information
using SpecificationPattern;

Console.WriteLine("Testing Specification Pattern...");

Order order = new Order();
bool b = order.IsRushSpecification();
if (b)
{
	Console.WriteLine("Rush order");
}
else
{
	Console.WriteLine("Not Rush order");
}


TestHighValueOrderSpecification();

void TestHighValueOrderSpecification()
{
	Console.WriteLine("Testing High Value Order Specification ...");

	var OrderItems = new List<Product>();
	OrderItems.Add(new Product() { IsInStock = true, ContainsHazardousMaterial = false });
	OrderItems.Add(new Product() { IsInStock = true, ContainsHazardousMaterial = false });
	var ShippingAddress = new Address() { Country = "USA" };
	var OrderTotal = 200;
	var order = new Order(OrderItems, ShippingAddress, OrderTotal);

	bool b = order.IsHighValueOrder();
	if (b)
	{
		Console.WriteLine("High value order");
	}
	else
	{
		Console.WriteLine("Not High value order");
	}
}
