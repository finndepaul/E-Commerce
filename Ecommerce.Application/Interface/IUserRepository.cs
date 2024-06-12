using Ecommerce.Application.DataTransferObj.User.Request;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IUserRepository
    {
        Task<ErrorMessage> Register(Users users, CancellationToken cancellationToken);
        Task<PaginationResponse<UserDto>>  GetAllUsers(ViewUserRequest request,CancellationToken cancellationToken);
        Task<UserDto> GetUserById(Guid id, CancellationToken cancellationToken);
        Task<ErrorMessage> UpdateUser(UserUpdateRequest request, CancellationToken cancellationToken);
        Task<bool> DeleteUser(Guid id, CancellationToken cancellationToken);
    }
}
