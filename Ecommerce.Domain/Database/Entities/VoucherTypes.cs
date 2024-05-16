using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class VoucherTypes : EntityBase
    {
        public Guid ID { get; set; }
        public Guid VocherID { get; set; }
        public string VocherTypeName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
   

        // foreignKey
        public virtual List<Vouchers>? Vocher { get; set; }
    }
}
