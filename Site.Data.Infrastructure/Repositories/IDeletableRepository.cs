using Site.Model.Derived.EntityModel;

namespace Site.Data.Infrastructure.Repositories
{
    public interface IDeletableRepository<TEntity, TKey> :
        IRepository<TEntity, TKey> where TEntity : class, IEntityModel<TKey>
    {
        bool Delete(TEntity model);
    }
}