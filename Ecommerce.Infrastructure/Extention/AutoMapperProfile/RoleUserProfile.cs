using AutoMapper;
using Ecommerce.Application.DataTransferObj.RoleUser;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class RoleUserProfile : Profile
    {
        public RoleUserProfile()
        {
            CreateMap<RoleUserCreateRequest, RoleUser>();
            CreateMap<RoleUserDTO, RoleUser>().ReverseMap();
            
        }
    }
}
