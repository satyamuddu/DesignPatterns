namespace SpecificationPattern.Framework
{
    public interface ISpecification<TEntity>
    {
        public bool IsSatisfiedBy(TEntity entity);
        public ISpecification<TEntity> And(ISpecification<TEntity> specification);
        public ISpecification<TEntity> Or(ISpecification<TEntity> specification);
        public ISpecification<TEntity> Not();
    }
}