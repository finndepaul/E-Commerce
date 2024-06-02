using Ecommerce.Application.DataTransferObj.ProductType;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.ProductType
{
    public class ProductTypeRespository : IProductTypeRespository
    {
        public Task<bool> CreateProduct(ProductTypes productsType, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteProduct(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResponse<ProductTypeDTO>> GetAll(CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(Guid id, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
