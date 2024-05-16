using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class SaleDetails : EntityBase
    {
        public Guid ID { get; set; }
        public Guid IdSale { get; set; }
        public Guid IdProduct { get; set; }
        public decimal Discount { get; set; }
        public int CountProduct { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
     

        // khóa ngoại 
        public virtual Sales? Sales { get; set; }
        public virtual Products? Products { get; set; }
    }
}
