using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IShopsRepository
    {
        Task<bool> Create(Shops request, CancellationToken cancellationToken);
        Task<bool> Update(Shops request, CancellationToken cancellationToken);
        Task<bool> Delete(Shops request, CancellationToken cancellationToken);
        
    }
}
