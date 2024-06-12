using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Shops
{
    public  class ShopsDeleteRequest
    {
        public Guid ShopId { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
