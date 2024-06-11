using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IOderDetailRespository
    {
        Task<List<OrderDetailDto>> GetAllOrdersOfID(Guid ID, CancellationToken cancellationToken);
        Task<bool> CreateOrderDetail(OrderDetails request, CancellationToken cancellationToken);
        Task<bool> CancelOrderDetail(Guid idOrderdetail, CancellationToken cancellationToken);
        Task<bool> Purchase(PurchaseRequest request, CancellationToken cancellationToken);
    }
}
