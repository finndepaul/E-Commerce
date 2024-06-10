using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IOderDetailRespository
    {
        Task<bool> Purchase(PurchaseRequest request, CancellationToken cancellationToken);
        Task<BillDto> GetBillById(Guid billId, CancellationToken cancellationToken);
        Task<ErrorMessage> DeleteBill(Guid billId, CancellationToken cancellationToken);
    }
}
