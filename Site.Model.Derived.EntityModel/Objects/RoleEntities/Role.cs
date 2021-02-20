namespace Site.Model.Derived.EntityModel.Objects.RoleEntities
{
    public class Role<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public string Name { get; set; }
    }
}