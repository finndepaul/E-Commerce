using Ecommerce.Application.DataTransferObj.SaleType;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface ISaleTypeResponsitory
    {
        Task<SaleTypeDto> GetSaleTypeById(Guid id, CancellationToken cancellationToken);
        Task<List<SaleTypeDto>> GetAllSaleTypes(CancellationToken cancellationToken);
        Task<bool> CreateSaleType(SaleTypeCreateRequest request, CancellationToken cancellationToken);
        Task<bool> UpdateSaleType(SaleTypeUpdateRequest request, CancellationToken cancellationToken);
        Task<bool> DeleteSaleType(Guid id, CancellationToken cancellationToken);
    }
}
