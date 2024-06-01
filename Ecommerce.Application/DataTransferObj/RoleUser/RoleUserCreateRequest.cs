using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.RoleUser
{
    public class RoleUserCreateRequest
    {
        public Guid CreateBy { get; set; }
        public Guid RoleId { get; set; }
    }
}
