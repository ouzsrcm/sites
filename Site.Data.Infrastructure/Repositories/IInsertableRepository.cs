using Site.Model.Derived.EntityModel;

namespace Site.Data.Infrastructure.Repositories
{
    public interface IInsertableRepository<TEntity, TKey> : 
        IRepository<TEntity, TKey> where TEntity : class, IEntityModel<TKey>
    {
        TEntity Insert(TEntity model);
    }
}