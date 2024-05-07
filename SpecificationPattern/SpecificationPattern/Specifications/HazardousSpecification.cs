using SpecificationPattern.Framework;

namespace SpecificationPattern.Specifications
{
    internal class HazardousSpecification : Specification<Order>
    {
        public HazardousSpecification()
        {
        }

        public override bool IsSatisfiedBy(Order entity)
        {
            bool result = entity.OrderItems.Where(a => a.ContainsHazardousMaterial == false).Any(); ;
            return result;
        }
    }
}