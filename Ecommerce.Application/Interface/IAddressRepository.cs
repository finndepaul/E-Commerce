using Ecommerce.Application.DataTransferObj.Address;
using Ecommerce.Domain.Database.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
     public interface IAddressRepository
    {
        public Task<bool> AddressCreate(Address address,CancellationToken cancellationToken);
        public Task<bool> Delete(Guid id,CancellationToken cancellationToken);
        public Task<List<AddressDto>> GetAllAdressByID(Guid id,CancellationToken cancellationToken);
        public Task<AddressDto> GetById(Guid id,CancellationToken cancellationToken);
    }
}
