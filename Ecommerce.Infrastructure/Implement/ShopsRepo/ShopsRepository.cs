using AutoMapper;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.ShopsRepo
{
    public class ShopsRepository : IShopsRepository
    {
        private readonly WebBanHangContext _db;
        private readonly IMapper _map;

        public ShopsRepository(WebBanHangContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }

        public async Task<bool> Create(Shops request, CancellationToken cancellationToken)
        {
            try
            {
                request.CreatedTime = DateTimeOffset.Now;
                await _db.Shops.AddAsync(request, cancellationToken);
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> Delete(Shops request, CancellationToken cancellationToken)
        {
            var result = await GetById(request.ShopId, cancellationToken);
            result.DeletedTime = DateTimeOffset.Now;
            result.Deleted = true;

            _db.Shops.Update(result);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<bool> Update(Shops request, CancellationToken cancellationToken)
        {
            var result = await GetById(request.ShopId, cancellationToken);
            
            result.ModifiedBy = request.ModifiedBy;


            _db.Shops.Update(result);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }
        private async Task<Shops?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _db.Shops.FirstOrDefaultAsync(x => x.ShopId == id);
            return result;
        }

     
    }
}
