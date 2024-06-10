using AutoMapper;
using Ecommerce.Application.DataTransferObj.Products;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {

            CreateMap<ProductCreateRequest, Products>();
            CreateMap<Products,ProductDTO>().ReverseMap();
            CreateMap<ProductUpdateRequest, Products>();
            CreateMap<ProductDeleteRequest, Products>();
            CreateMap<ProductReviewDTO, Products>();
        }
        
    }
}
