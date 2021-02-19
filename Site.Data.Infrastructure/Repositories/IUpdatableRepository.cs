using Site.Model.Derived.EntityModel;

namespace Site.Data.Infrastructure.Repositories
{
    public interface IUpdatableRepository<TEntity, TKey> :
        IRepository<TEntity, TKey> where TEntity : class, IEntityModel<TKey>
    {
        TEntity Update(TEntity model);
    }
}