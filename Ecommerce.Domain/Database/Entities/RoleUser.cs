using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Database.Entities
{
    public class RoleUser : EntityBase
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public virtual Roles Roles { get; set; }
        public virtual Users Users { get; set; }
    }
}
