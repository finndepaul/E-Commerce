using AutoMapper;
using Ecommerce.Application.DataTransferObj.FeedBack;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Extention.AutoMapperProfile
{
    public class FeedBackProfile : Profile
    {
        public FeedBackProfile()
        {
            CreateMap<Feedbacks, FeedBackDTO>();
            CreateMap<FeedBackCreateRequest, Feedbacks>();
            CreateMap<FeedBackUpdateRequest, Feedbacks>();
            CreateMap<FeedBackDeleteRequest, Feedbacks>();
        }
    }
}
