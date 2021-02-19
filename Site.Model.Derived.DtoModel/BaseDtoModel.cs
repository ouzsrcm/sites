using Site.Model.Infrastructure;

namespace Site.Model.Derived.DtoModel
{
    public abstract class BaseDtoModel<TKey> : BaseModel<TKey>, IDtoModel<TKey>
    {

    }
}