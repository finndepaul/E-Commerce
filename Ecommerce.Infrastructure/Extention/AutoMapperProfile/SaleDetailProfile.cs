using AutoMapper;
using Ecommerce.Application.DataTransferObj.SaleDetail;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class SaleDetailProfile : Profile
    {
        public SaleDetailProfile() 
        {
            CreateMap<SaleDetails,SaleDetailDTO>().ReverseMap();
            CreateMap<SaleDetailCreateResquest, SaleDetails>();
            CreateMap<SaleDetailUpdateResquest, SaleDetails>();
            CreateMap<SaleDetailDeleteResquest, SaleDetails>();
        }
    }
}
