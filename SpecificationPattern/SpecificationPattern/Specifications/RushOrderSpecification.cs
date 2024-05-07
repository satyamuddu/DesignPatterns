using SpecificationPattern.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Specifications
{
	internal class RushOrderSpecification : SpecificationPattern.Framework.Specification<Order>
	{
		DomesticOrderSpecification domesticOrderSpecification = new DomesticOrderSpecification();
		HighValueOrderSpecification highValueOrderSpecification = new HighValueOrderSpecification();
		InStockSpecification inStockSpecification = new InStockSpecification();
		HazardousSpecification hazardousSpecification = new HazardousSpecification();
		public RushOrderSpecification() { }

		public override bool IsSatisfiedBy(Order entity)
		{
		
			return domesticOrderSpecification
				.And(highValueOrderSpecification)
				.And(inStockSpecification)
				.And(hazardousSpecification.Not())
				.IsSatisfiedBy(entity);
		}
	}
}
