using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.User.Request
{
    public class ViewUserRequest : PaginationRequest
    {
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public string? Username { get; set; }
        public EntityStatus? Status { get; set; } = EntityStatus.Active;
    }
}
