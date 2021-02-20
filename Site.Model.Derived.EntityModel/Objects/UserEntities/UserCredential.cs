namespace Site.Model.Derived.EntityModel.Objects.UserEntities
{
    public class UserCredential<TKey> : BaseEntityModel<TKey>, IEntityModel<TKey>
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool IsDefault { get; set; }
    }
}