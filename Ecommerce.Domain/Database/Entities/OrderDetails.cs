using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class OrderDetails : EntityBase
    {
        public Guid ID { get; set; }
        public Guid ProductID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.OrderConfirmed;
        public decimal Shipfee { get; set; }

        public virtual Products? Products { get; set; }
        public virtual Users? Users { get; set; }
        public virtual Feedbacks? Feedbacks { get; set; }
    }
}
