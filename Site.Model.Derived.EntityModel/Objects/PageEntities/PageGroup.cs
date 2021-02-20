using System.Collections.Generic;

namespace Site.Model.Derived.EntityModel.Objects.PageEntities
{
    public class PageGroup<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public string Name { get; set; }

        public virtual ICollection<Page<TKey>> Pages { get; set; }
    }
}