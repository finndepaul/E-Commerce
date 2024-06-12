using AutoMapper;
using Ecommerce.Application.DataTransferObj.SaleType;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.SaleType
{
    public class SaleTypeResponsitory : ISaleTypeResponsitory
    {
        private readonly WebBanHangContext _context;
        private readonly IMapper _mapper;

        public SaleTypeResponsitory( WebBanHangContext context, IMapper mapper)
        {
                _context = context;
            _mapper = mapper;
        }
        public async Task<bool> CreateSaleType(SaleTypeCreateRequest request, CancellationToken cancellationToken)
        {
            
                var saleType = new SaleTypes
                {
                    Id = Guid.NewGuid(),
                    SaleID = request.SaleId,
                    SaleTypeName = request.SaleTypeName,
                    Status = EntityStatus.Active
                };

                await _context.SaleType.AddAsync(saleType, cancellationToken);
                await _context.SaveChangesAsync(cancellationToken);
                return true;
           
        }

        public async Task<bool> DeleteSaleType(Guid id, CancellationToken cancellationToken)
        {
            var saleType = await _context.SaleType.FindAsync( id , cancellationToken);
            if (saleType == null)
            {
                return false;
            }

            _context.SaleType.Remove(saleType);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<List<SaleTypeDto>> GetAllSaleTypes(CancellationToken cancellationToken)
        {
            var saleTypes = await _context.SaleType.ToListAsync(cancellationToken);
            return _mapper.Map<List<SaleTypeDto>>(saleTypes);
        }

        public async Task<SaleTypeDto> GetSaleTypeById(Guid id, CancellationToken cancellationToken)
        {
            var saleType = await _context.SaleType.FindAsync(id, cancellationToken);
            return _mapper.Map<SaleTypeDto>(saleType);
        }

        public async Task<bool> UpdateSaleType(SaleTypeUpdateRequest request, CancellationToken cancellationToken)
        {
            var saleType = await _context.SaleType.FindAsync( request.Id , cancellationToken);
            if (saleType == null)
            {
                return false;
            }

            saleType.SaleTypeName = request.SaleTypeName;
            _context.SaleType.Update(saleType);
            await _context.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
