using AutoMapper;
using Ecommerce.Application.DataTransferObj.Carts;
using Ecommerce.Application.DataTransferObj.Oders;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class OderProfile : Profile
    {
        public OderProfile() 
        {
            
            CreateMap<OrderDetails, OrderDetailDto>()
                .ForMember(dest => dest.ProductName, opt => opt.MapFrom(src => src.Products.NameProduct));
            CreateMap<OrderDetails,OrderDetailCreateRequest>().ReverseMap();

        }
        
    }
}
