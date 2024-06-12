using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.SaleType
{
    public class SaleTypeCreateRequest
    {

        public Guid SaleId { get; set; }
        public string SaleTypeName { get; set; }
    }
}
