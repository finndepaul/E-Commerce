using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class CartDetails : EntityBase
    {
        public Guid Id { get; set; }
        public Guid CartID { get; set; }
        public Guid ProductID { get; set; }
        public decimal NumberOfProduct { get; set; }
        public decimal TotalMoney { get; set; } // tổng tiền cho 1 sản phẩm 
        public EntityStatus Status { get; set; } = EntityStatus.Active;
  

        // Foreign Key
        public virtual Products? Products { get; set; }
        public virtual Carts? Carts { get; set; }
    }
}
