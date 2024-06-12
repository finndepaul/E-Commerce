using AutoMapper;
using Ecommerce.Application.DataTransferObj.Shops;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class ShopsProfile : Profile
    {
        public ShopsProfile()
        {
            CreateMap<ShopsCreateRequest, Shops>();
            CreateMap<ShopsDeleteRequest, Shops>();
            CreateMap<ShopsUpdateRequest, Shops>();
        }
    }
}
