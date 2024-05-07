namespace SpecificationPattern.Framework
{
    internal class OrSpecification<TEntity> : CompositeSpecification<TEntity>
    {
        public OrSpecification(ISpecification<TEntity> left, ISpecification<TEntity> right) : base(left, right)
        {
        }

        public override bool IsSatisfiedBy(TEntity entity)
        {
            return left.IsSatisfiedBy(entity) || right.IsSatisfiedBy(entity);
        }
    }
}