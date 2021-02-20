using System.Collections.Generic;

namespace Site.Model.Derived.EntityModel.Objects.PageEntities
{
    public class Page<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public string Title { get; set; }
        public string SeoKeywords { get; set; }
        public string ShortDescription { get; set; }
        public string Content { get; set; }

        public virtual PageGroup<TKey> PageGroup { get; set; }
        public virtual ICollection<PageTag<TKey>> PageTags { get; set; }
    }
}