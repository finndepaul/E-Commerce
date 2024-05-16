using Ecommerce.Application.DataTransferObj.Example;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IExampleRepository
    {
        Task<PaginationResponse<ExampleDTO>> GetAll(ViewExampleRequest request,CancellationToken cancellationToken);
        Task<bool> Create(Example request,CancellationToken cancellationToken);
    }
}
