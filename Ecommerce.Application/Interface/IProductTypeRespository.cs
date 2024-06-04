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
        Task<PaginationResponse<ProductTypeDTO>> GetAll(ViewProductTypeRequest viewProductTypeRequest, CancellationToken cancellationToken);
        Task<bool> CreateProduct(ProductTypes productsType, CancellationToken cancellationToken);
        Task<bool> UpdateProduct(ProductTypes productTypes, CancellationToken cancellationToken);
        Task<bool> DeleteProduct(ProductTypes productTypes, CancellationToken cancellationToken);
    }
}
