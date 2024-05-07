using SpecificationPattern.Framework;

namespace SpecificationPattern.Specifications
{
    internal class DomesticOrderSpecification: Specification<Order>
    {
        public DomesticOrderSpecification()
        {
        }

        public override bool IsSatisfiedBy(Order entity)
        {
            bool result = entity.ShippingAddress.Country == "USA";
            return result;
        }
    }
}