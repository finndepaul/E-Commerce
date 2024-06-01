using Ecommerce.Application.DataTransferObj.Example;
using Ecommerce.Application.DataTransferObj.RoleUser;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IRoleUserRepository
    {
        Task<PaginationResponse<RoleUserDTO>> GetAll(ViewRoleUserRequest request, CancellationToken cancellationToken);
        Task<bool> Create(RoleUser request, CancellationToken cancellationToken);
    }
}
