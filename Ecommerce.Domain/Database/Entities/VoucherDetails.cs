using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class VoucherDetails
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public Guid VocherID { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // Khóa ngoại 
        public virtual Products Products { get; set; }
        public virtual Vouchers Vouchers { get; set; }

    }
}
