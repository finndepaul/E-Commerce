using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Roles : EntityBase
    {
        public Guid ID { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
    

        // ForeignKey
        public virtual ICollection<RoleUser>? RoleUsers { get; set; }

    }
}
