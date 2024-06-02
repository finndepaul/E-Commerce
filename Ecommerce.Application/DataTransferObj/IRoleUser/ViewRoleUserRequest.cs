using Ecommerce.Application.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.IRoleUser
{
    public class ViewRoleUserRequest : PaginationRequest
    {
        public string? SearchName { get; set; }
    }
}
