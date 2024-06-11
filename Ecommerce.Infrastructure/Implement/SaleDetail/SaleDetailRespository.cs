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
        public Task<bool> Create(SaleDetails details, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(SaleDetails details, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<SaleDetailDTO> GetSaleDetail(SaleDetails saleDetails, CancellationToken cancellationToken)
        {
            try
            {
                var sale = await _reps.SaleDetail.Include(x=>x.Sales).Include(x=>x.Products)
                    .FirstOrDefaultAsync(x=>x.IdSale == saleDetails.IdSale && x.IdProduct==saleDetails.IdProduct);
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

        public Task<bool> Update(SaleDetails details, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
