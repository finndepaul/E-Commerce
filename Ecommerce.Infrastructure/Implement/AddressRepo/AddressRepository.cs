using AutoMapper;
using AutoMapper.QueryableExtensions;
using Ecommerce.Application.DataTransferObj.Address;
using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.AddressRepo
{
    public class AddressRepository : IAddressRepository
    {

        private readonly WebBanHangContext _context;
        private readonly IMapper _map;
        public AddressRepository(WebBanHangContext context, IMapper map)
        {
            _context = context;
            _map = map;
        }

        public async Task<bool> AddressCreate(Address address, CancellationToken cancellationToken)
        {
            try
            {
                address.Id = Guid.NewGuid();
                address.CreatedTime = DateTime.UtcNow;
                await _context.Addresses.AddAsync(address);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public async Task<bool> Delete(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _context.Addresses.FirstOrDefaultAsync(x => x.Id == id);
            if (obj != null) 
            {
                _context.Addresses.Remove(obj);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<AddressDto>> GetAllAdressByID(Guid id, CancellationToken cancellationToken)
        {
            var lst = await _context.Addresses.Where(x => x.CreatedBy == id).ProjectTo<AddressDto>(_map.ConfigurationProvider).ToListAsync();
            return lst;
        }

        public async Task<AddressDto> GetById(Guid id, CancellationToken cancellationToken)
        {
            var obj = await _context.Addresses.ProjectTo<AddressDto>(_map.ConfigurationProvider).FirstOrDefaultAsync(x => x.Id == id);
            return obj;
        }
    }
}
