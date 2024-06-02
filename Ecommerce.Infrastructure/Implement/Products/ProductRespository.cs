using AutoMapper;
using Ecommerce.Application.DataTransferObj.Products;
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

namespace Ecommerce.Infrastructure.Implement.Products
{
    public class ProductRespository : IProductRespository
    {
        private readonly WebBanHangContext _db;
        private readonly IMapper _mapper;

        public ProductRespository( IMapper mapper)
        {
            _db = new WebBanHangContext();
            _mapper = mapper;
        }

        public async Task<bool> CreateProduct(Domain.Database.Entities.Products products, CancellationToken cancellationToken)
        {
            try
            {

                if(products.Price <= 0 || products.Price == null )
                {
                    return false;
                }
                if(products.Images == null)
                {
                    return false ;
                }
                else
                {
                    products.ID = Guid.NewGuid();
                    products.Status = Domain.Enum.ProductStatus.Still;
                    await _db.AddAsync(products);
                    await _db.SaveChangesAsync();
                    return true;
                }
              

            }
            catch
            {
                return false;
            }
        }

        public  async Task<bool> DeleteProduct(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _db.Product.FindAsync(id);
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    _db.Product.Remove(obj);
                    await _db.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        public async Task<PaginationResponse<ProductDTO>> GetAll(ViewProductRequest request, CancellationToken cancellationToken)
        {

            var query = _db.Product.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(request.Name))
            {
                query = query.Where(x => x.NameProduct == request.Name);
            }
            var result = await query.PaginateAsync< Ecommerce.Domain.Database.Entities.Products, ProductDTO>(request, _mapper, cancellationToken);
            return new PaginationResponse<ProductDTO>()
            {
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
                Data = result.Data
            };
        }

      
        public async Task<bool> UpdateProduct(Domain.Database.Entities.Products products, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await _db.Product.FirstOrDefaultAsync(x=>x.ID == products.ID);
                if (obj == null)
                {
                    return false;
                }
                else
                {
                    if (obj.Price <= 0 || obj.Price == null)
                    {
                        return false;
                    }
                    if (obj.Images == null)
                    {
                        return false;
                    }
                    _db.Product.Update(obj);
                    await _db.SaveChangesAsync();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
