namespace Ecommerce.Domain.Database.Entities
{
    public class OrderDetails
    {
        public Guid ID { get; set; }
        public Guid UserID { get; set; }
        public Guid ProductID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        public virtual Products? Products { get; set; }
        public virtual Users? Users { get; set; }
        public virtual Feedbacks? Feedbacks { get; set; }
    }
}
