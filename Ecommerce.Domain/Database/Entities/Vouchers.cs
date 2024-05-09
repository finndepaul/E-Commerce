using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Vouchers
    {
        public Guid ID { get; set; }
        public Guid VocherTypeID { get; set; }
        public Guid BillID { get; set; }
        public string? VocherName { get; set; }
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
        public virtual Bills? Bills { get; set; }
        public virtual VoucherTypes? VoucherTypes { get; set; }
        public virtual ICollection<VoucherDetails>? VoucherDetails { get; set; }
    }
}
