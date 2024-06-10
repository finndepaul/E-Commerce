using AutoMapper;
using Ecommerce.Application.DataTransferObj.Sale;
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
        public async Task<bool> CreateSale(Sales sale, Users users, CancellationToken cancellationToken)
        {
            try
            {
                sale.ID = Guid.NewGuid();
                sale.CreatedBy = users.ID;
                sale.Status = Domain.Enum.EntityStatus.PendingForActivation;
                _reps.Add(sale);
                await _reps.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            { 
                return false;   
            }
        
        }

        public async Task<bool> DeleteSale(Sales sale,Users users ,CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(sale.ID,cancellationToken);
                obj.Status = Domain.Enum.EntityStatus.Locked;
                obj.DeletedTime = DateTimeOffset.Now;
                obj.Deleted = true;
                obj.DeletedBy = users.ID;
                _reps.Sale.Update(sale);
                await _reps.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception ex) 
            {
                return false;
            }
        }

        public async Task<PaginationResponse<SalesDTO>> GetAll(ViewSaleResquest resquest, CancellationToken cancellationToken)
        {
            var query = _reps.Sale.Include(x => x.SaleTypeId).AsNoTracking();
            if (!String.IsNullOrWhiteSpace(resquest.SaleName))
            {
                query = query.Where(x => x.SaleName == resquest.SaleName);
            }
         
                var result =await query.PaginateAsync<Sales, SalesDTO>(resquest, _mapper, cancellationToken);
                result.Data = (from itema in result.Data
                               join itemb in query
                               on itema.ID equals itemb.ID
                               orderby itemb.TimeStart
                               select new SalesDTO()
                               {
                                   ID = itemb.ID,
                                   SaleTypeId = itemb.SaleTypeId,
                                   SaleName = itemb.SaleName,
                                   Status = itemb.Status,
                                   TimeStart  = itemb.TimeStart,
                                   TimeEnd = itemb.TimeEnd,

                               }
                               ).ToList();
                return new PaginationResponse<SalesDTO>
                {
                    Data = result.Data,
                    HasNext = result.HasNext,
                    PageNumber = result.PageNumber,
                    PageSize = result.PageSize,
                };
            
        }

        public async Task<bool> UpdateSale(Sales sale,Users user, CancellationToken cancellationToken)
        {
            try
            {
                var result = await GetById(sale.ID,cancellationToken);
                if (result == null) { return false; }
                else
                {
                    result.SaleName = sale.SaleName;
                    result.Status = sale.Status;
                    result.ModifiedBy= user.ID;
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
