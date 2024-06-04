using AutoMapper;
using Ecommerce.Application.DataTransferObj.ProductType;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.ProductType
{
    public class ProductTypeRespository : IProductTypeRespository
    {
        private readonly WebBanHangContext _db;
        private readonly IMapper _map;

        public ProductTypeRespository(IMapper map)
        {
            _map = map;
            _db = new WebBanHangContext();
        }

        public async Task<bool> CreateProduct(ProductTypes productsType, CancellationToken cancellationToken)
        {
            try
            {
                productsType.ID = Guid.NewGuid();
                productsType.Status = Domain.Enum.EntityStatus.Active;
                await _db.AddAsync(productsType);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public Task<bool> DeleteProduct(ProductTypes productTypes, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<PaginationResponse<ProductTypeDTO>> GetAll(ViewProductTypeRequest request, CancellationToken cancellationToken)
        {
            //var query = _db.ProductType.ToList();
            //if (!String.IsNullOrWhiteSpace(request.ProductsTypeName))
            //{
            //    query = query.Where(x => x.ProductsTypeName == request.ProductsTypeName).ToList();
            //}
            //var result = query  
            throw new NotImplementedException();
        }

        public Task<bool> UpdateProduct(ProductTypes productTypes, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
