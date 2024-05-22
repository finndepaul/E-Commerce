using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class BillDetails : EntityBase
    {
        public Guid ID { get; set; }
        public Guid BillID { get; set; }
        public Guid ProductID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
  
        // foreignKey 
        public virtual Bills? Bills { get; set; }
        public virtual Products? Products { get; set; }
    }
}
