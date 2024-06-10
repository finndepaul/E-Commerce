using AutoMapper;
using Ecommerce.Application.DataTransferObj.ProductType;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    
    public class ProductTypeProfile :Profile
    {
        public ProductTypeProfile()
        {
            CreateMap< ProductTypes,ProductTypeDTO>().ReverseMap();
            CreateMap<ProductTypeCreateRequest, ProductTypes>();
            CreateMap<ProductTypeUpdateRequest, ProductTypes>();
            CreateMap<ProductTypeDeleteRequest, ProductTypes>();
        }
    }
}
