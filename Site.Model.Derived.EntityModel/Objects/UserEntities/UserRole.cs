using Site.Model.Derived.EntityModel.Objects.RoleEntities;
namespace Site.Model.Derived.EntityModel.Objects.UserEntities
{
    public class UserRole<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public int RoleId { get; set; }
        public int UserId { get; set; }
        public virtual Role<TKey> Role { get; set; }
    }
}