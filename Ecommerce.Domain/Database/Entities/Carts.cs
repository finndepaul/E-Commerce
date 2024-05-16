using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Carts : EntityBase
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public decimal TotalMoney { get; set; } // Tổng tiền toàn bộ giỏ hàng 
        public EntityStatus Status { get; set; } = EntityStatus.Active;
      

        // ForeignKey 
        public virtual Users Users { get; set; }
        public virtual ICollection<CartDetails>? CartDetails { get; set; }
    }
}
