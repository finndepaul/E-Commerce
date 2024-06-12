using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Address
{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public int city { get; set; }
        public int district { get; set; }
        public string WardCode { get; set; }
    }
}
