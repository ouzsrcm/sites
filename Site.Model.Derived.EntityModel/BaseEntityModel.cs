using Site.Model.Infrastructure;

namespace Site.Model.Derived.EntityModel
{
    public abstract class BaseEntityModel<TKey> : BaseModel<TKey>, IEntityModel<TKey>
    {
    }
}
