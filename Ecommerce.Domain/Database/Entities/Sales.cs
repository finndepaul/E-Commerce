using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Sales : EntityBase
    {
        public Guid ID { get; set; }
        public Guid SaleTypeId { get; set; }
        public string? SaleName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
  

        // ForeignKey
        public virtual ICollection<SaleDetails>? SaleDetails { get; set; }
        public virtual SaleTypes? SaleTypes { get; set; }

    }
}
