namespace Site.Model.Derived.EntityModel.Objects.PageEntities
{
    public class PageTag<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public int PageId { get; set; }
        public int TagId { get; set; }

        public virtual Page<TKey> Page { get; set; }
        public virtual Tag<TKey> Tag { get; set; }
    }
}
