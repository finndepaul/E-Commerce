using Ecommerce.Application.DataTransferObj.SaleDetail;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface ISaleDetailRespository
    {
        public Task<SaleDetailDTO> GetSaleDetail(SaleDetails saleDetails,CancellationToken cancellationToken);
        public Task<bool>  Create(SaleDetails details, CancellationToken cancellationToken);
        public Task<bool> Update(SaleDetails details, CancellationToken cancellationToken);
        public Task<bool> Delete(SaleDetails details, CancellationToken cancellationToken);

    }
}
