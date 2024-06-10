using AutoMapper;
using Ecommerce.Application.DataTransferObj.Sale;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.Sale
{
    public class SaleRespository : ISalesRespository
    {
        private readonly WebBanHangContext _reps;
        private readonly IMapper _mapper;
        public SaleRespository(IMapper mapper)
        {
                

            _mapper = mapper;
            _reps = new WebBanHangContext();
        }
        public async Task<bool> CreateSale(Sales sale, CancellationToken cancellationToken)
        {
            try
            {
                sale.ID = Guid.NewGuid();
                sale.Status = Domain.Enum.EntityStatus.Active;
                _reps.Add(sale);
                await _reps.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            { 
                return false;   
            }
        
        }

        public Task<bool> DeleteSale(Sales sale, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<PaginationResponse<SalesDTO>> GetAll(ViewSaleResquest resquest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateSale(Sales sale, CancellationToken cancellationToken)
        {
            try
            {
                var result = await GetById(sale.ID,cancellationToken);
                if (result == null) { return false; }
                else
                {
                    result.SaleName = sale.SaleName;
                    result.Status = sale.Status;
                    result.TimeStart = sale.TimeStart;
                    result.TimeEnd = sale.TimeEnd;
                   _reps.Update(result);
                   await _reps.SaveChangesAsync();
                    return true;
                }
            }
            catch (Exception ex) 
            {
                return false;
            }
        }
        private async Task<Sales> GetById(Guid id , CancellationToken cancellationToken)
        {
            var getById = await _reps.Sale.FirstOrDefaultAsync(x=>x.ID == id);
            return getById;
        }
    }
}
