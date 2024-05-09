using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Sales
    {
        public Guid ID { get; set; }
        public Guid SaleTypeId { get; set; }
        public string? SaleName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // ForeignKey
        public virtual ICollection<SaleDetails>? SaleDetails { get; set; }
        public virtual SaleTypes? SaleTypes { get; set; }

    }
}
