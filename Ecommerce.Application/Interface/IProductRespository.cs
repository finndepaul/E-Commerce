using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IProductRespository
    {
        Task<PaginationResponse<ProductDTO>> GetAll(ViewProductRequest productRequest, CancellationToken cancellationToken);
      
        Task<bool> CreateProduct(Products products, CancellationToken cancellationToken);
        Task<bool> UpdateProduct(Products products, CancellationToken cancellationToken);
        Task<bool> DeleteProduct(Products products, CancellationToken cancellationToken);
        Task<bool> ProductReview(Guid id ,CancellationToken cancellationToken);
    }
}
