using AutoMapper;
using Ecommerce.Application.DataTransferObj.SaleDetail;
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

namespace Ecommerce.Infrastructure.Implement.SaleDetail
{
    public class SaleDetailRespository : ISaleDetailRespository
    {
       private readonly WebBanHangContext _reps;
       private readonly IMapper _mapper;
        public SaleDetailRespository(IMapper mapper)
        {
            _mapper = mapper;
            _reps = new WebBanHangContext();
        }
        public async Task<bool> Create(SaleDetails details, CancellationToken cancellationToken)
        {
            try
            {
                details.ID = Guid.NewGuid();
                details.Status = Domain.Enum.EntityStatus.PendingForActivation;
                _reps.SaleDetail.Add(details);  
                await _reps.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(SaleDetails details, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(details.ID, cancellationToken);
                if (obj != null) 
                {
                    obj.Deleted = true;
                    obj.Status = Domain.Enum.EntityStatus.Locked;
                    _reps.Update(obj);
                    await _reps.SaveChangesAsync();
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public async Task<SaleDetailDTO> GetSaleDetail(Guid id, CancellationToken cancellationToken)
        {
            try
            {
                var sale = await _reps.SaleDetail.Include(x=>x.Sales).Include(x=>x.Products)
                    .FirstOrDefaultAsync(x=>x.IdSale == id && x.IdProduct==id);
                if (sale == null) 
                {
                    return null;
                }
                return new SaleDetailDTO()
                {
                    ID = sale.ID,
                    IdProduct = sale.IdProduct,
                    IdSale = sale.IdSale,
                    CountProduct = sale.CountProduct,
                    Discount = sale.Discount,
                    Status = sale.Status
                };
            }
            catch (Exception ex) 
            {
                return null;      
            }
        }
        private async Task<SaleDetails> GetById(Guid id,CancellationToken cancellationToken)
        {
            var query = await _reps.SaleDetail.FirstOrDefaultAsync(x=>x.ID==id);
            return query;
        }
        public async Task<bool> Update(SaleDetails details, CancellationToken cancellationToken)
        {
            try
            {
                var obj = await GetById(details.ID,cancellationToken);
                if (obj == null) return false;
                else
                {
                   obj.CountProduct = details.CountProduct;
                    obj.Discount = details.Discount;    
                    obj.Status = details.Status;
                    obj.ModifiedTime= DateTimeOffset.Now;
                    _reps.Update(obj);
                    await _reps.SaveChangesAsync();
                    return true;
                }
            }catch 
            {
                return false;
            }
        }
    }
}
