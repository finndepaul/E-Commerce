using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Vouchers : EntityBase
    {
        public Guid ID { get; set; }
        public Guid VocherTypeID { get; set; }
        public Guid BillID { get; set; }
        public string? VocherName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
       

        // ForeignKey
        public virtual Bills? Bills { get; set; }
        public virtual VoucherTypes? VoucherTypes { get; set; }
        public virtual ICollection<VoucherDetails>? VoucherDetails { get; set; }
    }
}
