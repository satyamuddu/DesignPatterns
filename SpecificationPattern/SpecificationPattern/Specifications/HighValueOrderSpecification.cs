using SpecificationPattern.Framework;

namespace SpecificationPattern.Specifications
{
	internal class HighValueOrderSpecification : Specification<Order>
	{
		DomesticOrderSpecification domesticOrderSpecification = new DomesticOrderSpecification();
		//RushOrderSpecification rushOrderSpecification = new RushOrderSpecification();
		InStockSpecification inStockSpecification = new InStockSpecification();
		private HazardousSpecification hazardousSpecification = new HazardousSpecification();
		public override bool IsSatisfiedBy(Order entity)
		{
			

			bool result = domesticOrderSpecification
					.And(hazardousSpecification.Not())
					.Or(inStockSpecification)
					.IsSatisfiedBy(entity)
					&& entity.OrderTotal > 100;
			return result;
		}
	}
}