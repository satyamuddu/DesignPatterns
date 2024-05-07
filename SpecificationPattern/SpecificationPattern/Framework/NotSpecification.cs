namespace SpecificationPattern.Framework
{
    internal class NotSpecification<TEntity> : Specification<TEntity>
    {
        private Specification<TEntity> specification;

        public NotSpecification(Specification<TEntity> specification)
        {
            this.specification = specification;
        }

        public override bool IsSatisfiedBy(TEntity entity)
        {
            return specification.IsSatisfiedBy(entity);
        }
    }
}