namespace SpecificationPattern.Framework
{
    internal class AndSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        public AndSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right) : base(left, right)
        {
        }

        public override bool IsSatisfiedBy(TEntity entity)
        {
            return left.IsSatisfiedBy(entity) && right.IsSatisfiedBy(entity);
        }
    }
}