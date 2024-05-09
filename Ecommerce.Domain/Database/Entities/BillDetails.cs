using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class BillDetails
    {
        public Guid ID { get; set; }
        public Guid BillID { get; set; }
        public Guid ProductID { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // foreignKey 
        public virtual Bills? Bills { get; set; }
        public virtual Products? Products { get; set; }
    }
}
