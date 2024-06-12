using AutoMapper;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ecommerce.Infrastructure.Implement.Product
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

        public async Task<bool> CreateProduct(Products products, CancellationToken cancellationToken)
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
                    products.Status = Domain.Enum.ProductStatus.Waiting;
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
 

        public  async Task<bool> DeleteProduct(Products products, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetByID(products.ID, cancellationToken);
                obj.Status = Domain.Enum.ProductStatus.Waiting; 
                obj.DeletedTime = DateTimeOffset.Now;
                obj.Deleted = true; 
                
                _db.Product.Update(obj);
                await _db.SaveChangesAsync(cancellationToken);
                return true;    
            }
            catch
            {
                return false;
            }
        }

        public async Task<PaginationResponse<ProductDTO>> GetAll(ViewProductRequest request, CancellationToken cancellationToken)
        {

            var query = _db.Product.Include(x=>x.ProductTypes).Include(x=>x.Shops).AsNoTracking();

            if (!String.IsNullOrWhiteSpace(request.NameProduct))
            {
                query = query.Where(x => x.NameProduct == request.NameProduct);
            }
            if(request.Status.HasValue)
            {
                query = query.Where(x => x.Status == request.Status);
            }
                var result = await query.PaginateAsync<Products, ProductDTO>(request, _mapper, cancellationToken);
                result.Data = (from x in result.Data
                               join p in query on x.ID equals p.ID
                               orderby p.CreatedTime descending
                               select new ProductDTO
                               {
                                   ID = p.ID,
                                   ShopId = p.ShopId,
                                   ProductsTypeName = p.ProductTypes.ProductsTypeName,
                                   ShopName = p.Shops.ShopName,
                                   Images = p.Images,
                                   Price = p.Price,
                                   NameProduct = p.NameProduct,
                                   DescriptionProduct = p.DescriptionProduct,
                                   Status = p.Status,
                               }
                             ).ToList();

                return new PaginationResponse<ProductDTO>()
                {
                    HasNext = result.HasNext,
                    PageNumber = result.PageNumber,
                    PageSize = result.PageSize,
                    Data = result.Data
                };
            
     
        }

      
        public async Task<bool> UpdateProduct(Products products, CancellationToken cancellationToken)
        { 
            try
            {
                var obj = await GetByID(products.ID,cancellationToken);

                    if (obj.Price <= 0 || obj.Price == null)
                    {
                        return false;
                    }
          
                    obj.NameProduct = products.NameProduct;
                    obj.DescriptionProduct = products.DescriptionProduct;
                    obj.Status = products.Status;
                    obj.Images = products.Images;
                    obj.Price = products.Price;
                    obj.Quantity = products.Quantity;
                    _db.Product.Update(obj);
                    await _db.SaveChangesAsync();
                    return true;
                
            }
            catch
            {
                return false;
            }
        }
        private async Task<Products> GetByID(Guid id, CancellationToken cancellationToken)
        {
            var getById = await _db.Product.FirstOrDefaultAsync(p => p.ID == id);
            return getById;
        }
        public async Task<bool> ProductReview(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var query = await _db.Product.FirstOrDefaultAsync(x => x.ID == id,cancellationToken);
                if (query == null) 
                {
                    return false;
                }
                else
                {
                    query.Status = ProductStatus.Approved;
                     _db.Product.Update(query);
                    await _db.SaveChangesAsync();
                    return true;
                   
                }
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
    }
}
