using AutoMapper;
using Ecommerce.Application.DataTransferObj.Example;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement
{
    public class ExampleRepository : IExampleRepository
    {
        private readonly WebBanHangContext _db;
        private readonly IMapper _mapper;

        public ExampleRepository(IMapper mapper)
        {
            _db = new WebBanHangContext();
            _mapper = mapper;
        }

        public async Task<bool> Create(Example request, CancellationToken cancellationToken)
        {
            try
            {
                await _db.Examples.AddAsync(request);
                await _db.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }

        }

        public async Task<PaginationResponse<ExampleDTO>> GetAll(ViewExampleRequest request,CancellationToken cancellationToken)
        {
            var query = _db.Examples.AsNoTracking();
            if (!String.IsNullOrWhiteSpace(request.Name)) 
            {
                query = query.Where(x => x.Name == request.Name);
            }
            var result = await query.PaginateAsync<Example,ExampleDTO>(request,_mapper,cancellationToken);
            return new PaginationResponse<ExampleDTO>()
            {
              HasNext = result.HasNext,
              PageNumber = result.PageNumber,
              PageSize = result.PageSize,
              Data = result.Data
            };
        }
    }
}
