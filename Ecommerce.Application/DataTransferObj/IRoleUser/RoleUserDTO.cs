using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.IRoleUser
{
    public class RoleUserDTO
    {
        public Guid Id { get; set; } 
        public string UserName { get; set; } 
        public string RoleName { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public EntityStatus Status { get; set; }
    }
}
