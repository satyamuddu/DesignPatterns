using SpecificationPattern.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern
{
    internal class Order
    {
        public Order()
        {
            OrderItems = new List<Product>();
            OrderItems.Add(new Product() { IsInStock = true, ContainsHazardousMaterial = false });
            OrderItems.Add(new Product() { IsInStock = true, ContainsHazardousMaterial = false });
            ShippingAddress = new Address() { Country = "USA" };
            OrderTotal = 200;
        }
        public Order(List<Product> products, Address address, int total)
        {
            OrderItems = products;
            ShippingAddress = address;
            OrderTotal = total; 
		}
        public virtual Address ShippingAddress { get; set; }
        public int OrderTotal { get; set; }
        public IList<Product> OrderItems { get; private set; }
        public bool IsRush()
        {
            bool isRush = false;
            if (ShippingAddress.Country == "USA")
            {
                if (OrderTotal > 100)
                {
                    if (OrderItems.Count(item => item.IsInStock) == 0)
                    {
                        if (OrderItems.Count(item => item.ContainsHazardousMaterial) == 0)
                        {
                            isRush = true;
                        }

                    }
                }
            }
            return isRush;
        }
        public bool IsRushSpecification()
        {
            var spec = new RushOrderSpecification();
            return spec.IsSatisfiedBy(this);
        }

		internal bool IsHighValueOrder()
		{
			var spec = new HighValueOrderSpecification();
			return spec.IsSatisfiedBy(this);
		}
	}
}
