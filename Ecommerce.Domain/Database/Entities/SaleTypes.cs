using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class SaleTypes : EntityBase
    {
        public Guid Id { get; set; }
        public Guid SaleID { get; set; }
        public string SaleTypeName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
    


        // Foreignkey 
        public virtual ICollection<Sales>? Sale { get; set; }
    }
}
