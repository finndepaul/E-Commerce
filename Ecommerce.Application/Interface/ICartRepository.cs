using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Products;
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
    public interface ICartRepository
    {
        Task<PaginationResponse<CartDetailDTO>> GetAllCartDetails(ViewCartDetailRequest request, CancellationToken cancellationToken);
        Task<CartDetailDTO> GetCartDetailById(Guid cartDetailId, CancellationToken cancellationToken);
        Task<ErrorMessage> AddToCart(CreateCartDetailRequest request, Guid userId, CancellationToken cancellationToken);
        Task<ErrorMessage> UpdateCartDetail(UpdateCartRequest request, Guid userId, CancellationToken cancellationToken);
        Task<ErrorMessage> RemoveFromCart(DeleteCartDetailRequest request, Guid userId, CancellationToken cancellationToken);

    }
}
