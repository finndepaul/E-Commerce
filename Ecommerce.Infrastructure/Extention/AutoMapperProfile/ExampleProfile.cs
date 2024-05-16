using AutoMapper;
using Ecommerce.Application.DataTransferObj.Example;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class ExampleProfile : Profile
    {
        public ExampleProfile()
        {
            CreateMap<Example, ExampleDTO>();
            CreateMap<ExampleCreateRequest, Example>();

        }
    }
}
