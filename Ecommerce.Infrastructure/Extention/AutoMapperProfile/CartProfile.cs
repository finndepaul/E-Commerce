using AutoMapper;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class CartProfile : Profile
    {
        public CartProfile()
        { 
           
           
          
            // Cấu hình ánh xạ giữa các thực thể và DTOs
            CreateMap<CartDetails, CartDetailDTO>()
                  .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Products.NameProduct))
                .ForMember(dest => dest.ProductPrice, opt => opt.MapFrom(src => src.Products.Price))
                .ForMember(dest => dest.ProductImages, opt => opt.MapFrom(src => src.Products.Images));
        }

    }
    
}
