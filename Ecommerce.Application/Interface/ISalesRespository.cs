using Ecommerce.Application.DataTransferObj.Sale;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface ISalesRespository
    {
        Task<PaginationResponse<SalesDTO>> GetAll(ViewSaleResquest resquest,CancellationToken cancellationToken);
        Task<bool> CreateSale(Sales sale,CancellationToken cancellationToken);
        Task<bool> UpdateSale(Sales sale,CancellationToken cancellationToken);
        Task<bool> DeleteSale(Sales sale,CancellationToken cancellationToken);
    }
}
