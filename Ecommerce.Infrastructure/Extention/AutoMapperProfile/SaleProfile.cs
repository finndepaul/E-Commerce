using AutoMapper;
using Ecommerce.Application.DataTransferObj.Sale;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class SaleProfile : Profile
    {
        public SaleProfile()
        {
            CreateMap<Sales,SalesDTO>().ReverseMap();
            CreateMap<SaleCreateResquest,Sales>();
            CreateMap<SaleUpdateResquest, Sales>();
            CreateMap<SaleDeleteResquest, Sales>();
        }
    }
}
