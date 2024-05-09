using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class SaleTypes
    {
        public Guid Id { get; set; }
        public Guid SaleID { get; set; }
        public string SaleTypeName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;


        // Foreignkey 
        public virtual ICollection<Sales>? Sale { get; set; }
    }
}
