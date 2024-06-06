using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.IRoleUser
{
    public class RoleUserUpdateRequest
    {
        public Guid Id { get; set; }
        public Guid RoleId { get; set; }
        public Guid CreatedBy { get; set; }
        public Guid ModifiedBy { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
    }
}
