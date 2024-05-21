using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Address : EntityBase
    {
        public Guid Id { get; set; }
        public string UserAddress { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        // khóa ngọại 
        public virtual Users User { get; set; }

    }
}
