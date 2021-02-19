using Site.Model.Derived.EntityModel;

namespace Site.Data.Infrastructure.Repositories
{
    public interface IRepository<TEntity, TKey> where TEntity : class, IEntityModel<TKey>
    {

    }
}
