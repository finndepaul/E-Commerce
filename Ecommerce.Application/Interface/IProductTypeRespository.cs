using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.DataTransferObj.ProductType;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IProductTypeRespository
    {
        Task<PaginationResponse<ProductTypeDTO>> GetAll( CancellationToken cancellationToken);
        Task<bool> CreateProduct(ProductTypes productsType, CancellationToken cancellationToken);
        Task<bool> UpdateProduct(Guid id, CancellationToken cancellationToken);
        Task<bool> DeleteProduct(Guid id, CancellationToken cancellationToken);
    }
}
