using Ecommerce.Domain.Database.Base;

namespace Ecommerce.Domain.Database.Entities
{
    public class Feedbacks : EntityBase
    {
        public Guid ID { get; set; }
        public Guid OrderDetailID { get; set; }
        public string CustomerFeedback { get; set; }
        public int Rating { get; set; }
   
        public virtual OrderDetails OrderDetails { get; set; }
    }
}
