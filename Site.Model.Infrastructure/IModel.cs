using System;

namespace Site.Model.Infrastructure
{
    public interface IModel<TKey>
    {
        TKey Id { get; set; }
        Guid UniqueId { get; set; }

        int? CreatedUser { get; set; }
        DateTime? CreationDate { get; set; }

        bool? IsDeleted { get; set; }
        DateTime? DeletionDate { get; set; }

        bool IsActive { get; set; }
    }
}
