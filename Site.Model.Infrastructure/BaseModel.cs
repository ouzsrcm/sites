using System;

namespace Site.Model.Infrastructure
{
    public class BaseModel<TKey> : IModel<TKey>
    {
        public TKey Id { get; set; }
        public Guid UniqueId { get; set; }
        public int? CreatedUser { get; set; }
        public DateTime? CreationDate { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? DeletionDate { get; set; }
        public bool IsActive { get; set; }
    }
}
