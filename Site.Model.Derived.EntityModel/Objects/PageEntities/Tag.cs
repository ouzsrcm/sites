namespace Site.Model.Derived.EntityModel.Objects.PageEntities
{
    public class Tag<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public string Name { get; set; }
        public string Url { get; set; }
    }
}