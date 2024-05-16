using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class ProductTypes : EntityBase
    {
        public Guid ID { get; set; }
        public string ProductsTypeName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
 
        // ForeignKey
        public virtual ICollection<Products>? Product { get; set; }
    }
}
