namespace Ecommerce.Domain.Database.Entities
{
    public class Feedbacks
    {
        public Guid ID { get; set; }
        public Guid OrderDetailID { get; set; }
        public string CustomerFeedback { get; set; }
        public int Rating { get; set; }
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        public virtual OrderDetails OrderDetails { get; set; }
    }
}
