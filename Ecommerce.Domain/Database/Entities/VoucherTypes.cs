using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class VoucherTypes
    {
        public Guid ID { get; set; }
        public Guid VocherID { get; set; }
        public string VocherTypeName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // foreignKey
        public virtual List<Vouchers>? Vocher { get; set; }
    }
}
