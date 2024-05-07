using SpecificationPattern.Framework;

namespace SpecificationPattern.Specifications
{
    internal class InStockSpecification:Specification<Order>
    {
        public InStockSpecification()
        {
        }

        public override bool IsSatisfiedBy(Order entity)
        {
            bool result = entity.OrderItems.Where(a=>a.IsInStock).Any();
            return result;
        }
    }
}