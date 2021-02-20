using Site.Model.Infrastructure;

namespace Site.Data.Infrastructure.RecordStructure
{
    public class RecordBase<TKey> : BaseModel<TKey> ,IRecordBase<TKey>
    {

    }
}