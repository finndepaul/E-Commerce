using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class CartDetails
    {
        public Guid Id { get; set; }
        public Guid CartID { get; set; }
        public Guid ProductID { get; set; }
        public decimal NumberOfProduct { get; set; }
        public decimal TotalMoney { get; set; } // tổng tiền cho 1 sản phẩm 
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // Foreign Key
        public virtual Products? Products { get; set; }
        public virtual Carts? Carts { get; set; }
    }
}
