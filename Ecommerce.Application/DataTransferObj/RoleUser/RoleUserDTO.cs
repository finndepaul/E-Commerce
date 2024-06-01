using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.RoleUser
{
    public class RoleUserDTO
    {
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public EntityStatus Status { get; set; }
    }
}
