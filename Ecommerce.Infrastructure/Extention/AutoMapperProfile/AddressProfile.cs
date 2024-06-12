using AutoMapper;
using Ecommerce.Application.DataTransferObj.Address;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class AddressProfile : Profile
    {
        public AddressProfile()
        {
            CreateMap<AddressDto,Address>().ReverseMap();
            CreateMap<AddressCreateRequest, Address>();
        }
    }
}
