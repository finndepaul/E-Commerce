using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.IRoleUser
{
    public class RoleUserCreateRequest
    {
        public Guid CreatedBy { get; set; }
        public Guid RoleId { get; set; }
    }
}
