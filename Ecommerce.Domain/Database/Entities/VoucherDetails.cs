using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
        public class VoucherDetails : EntityBase
        {
            public Guid Id { get; set; }
            public Guid ProductID { get; set; }
            public Guid VocherID { get; set; }
            public EntityStatus Status { get; set; } = EntityStatus.Active;
    

            // Khóa ngoại 
            public virtual Products Products { get; set; }
            public virtual Vouchers Vouchers { get; set; }

        }
}
