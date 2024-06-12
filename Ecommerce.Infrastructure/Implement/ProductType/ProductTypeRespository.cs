using AutoMapper;
using Ecommerce.Application.DataTransferObj.ProductType;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
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

        public async Task<bool> DeleteProduct(ProductTypes productTypes, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetByID(productTypes.ID, cancellationToken);
                if (obj == null) return false;
                else
                {
                    obj.Status = Domain.Enum.EntityStatus.Deleted;
                    obj.DeletedTime = DateTimeOffset.Now;
                    obj.Deleted = true;
                    _db.ProductType.Update(obj);
                    await _db.SaveChangesAsync(cancellationToken);
                    return true;
                }

            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public async Task<PaginationResponse<ProductTypeDTO>> GetAll(ViewProductTypeRequest request, CancellationToken cancellationToken)
        {
            var query = _db.ProductType.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(request.ProductsTypeName))
            {
                query = query.Where(x => x.ProductsTypeName.Contains(request.ProductsTypeName.ToLower()));
            }
           var result =  await query.PaginateAsync<ProductTypes, ProductTypeDTO>(request,_map, cancellationToken);
            result.Data = (from x in result.Data
                           join y in query on x.ID equals y.ID
                           orderby y.CreatedTime descending
                           select new ProductTypeDTO
                           {
                               ID = y.ID,
                               ProductsTypeName=  y.ProductsTypeName,
                               Status = y.Status,
                           }
                ).ToList();
            return new PaginationResponse<ProductTypeDTO>
            {
                Data = result.Data, 
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize, 
            };
        }

        public async Task<bool> UpdateProduct(ProductTypes productTypes, CancellationToken cancellationToken)
        {
            try
            {
              var obj = await GetByID(productTypes.ID, cancellationToken);
                if (obj == null) { return false;     }
                else
                {
                    obj.ProductsTypeName = productTypes.ProductsTypeName;
                    obj.Status = productTypes.Status;
                    _db.ProductType.Update(obj);
                    await _db.SaveChangesAsync();  
                    return true;
                }
                 
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        private async Task<ProductTypes> GetByID(Guid id,CancellationToken cancellationToken)
        {
            var getById = await _db.ProductType.FirstOrDefaultAsync(x=>x.ID == id);
            return getById;
        }
    }
}
