using AutoMapper;
using Ecommerce.Application.DataTransferObj.SaleType;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class SaleTypeProfile : Profile
    {
        public SaleTypeProfile() 
        {
            CreateMap<SaleTypes, SaleTypeDto>().ReverseMap();
            CreateMap<SaleTypeCreateRequest, SaleTypes>();
            CreateMap<SaleTypeUpdateRequest, SaleTypes>();
        }
    }
}
