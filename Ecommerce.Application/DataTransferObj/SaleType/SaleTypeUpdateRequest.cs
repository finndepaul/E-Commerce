using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.SaleType
{
    public class SaleTypeUpdateRequest
    {
        public Guid Id { get; set; }
        public string SaleTypeName { get; set; }
    }
}
