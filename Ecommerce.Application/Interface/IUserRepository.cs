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
    }
}
