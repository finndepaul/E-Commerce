using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.ProductType
{
    public class ProductTypeDeleteRequest
    {
        public Guid ID { get; set; }
        public Guid DeletedBy { get; set; }
    }
}
