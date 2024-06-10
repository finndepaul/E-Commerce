using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Sale
{
    public class SalesDTO 
    {
        public Guid ID { get; set; }
        public Guid SaleTypeId { get; set; }
        public string? SaleName { get; set; }
        public DateTime TimeStart { get; set; }
        public DateTime TimeEnd { get; set; }
        public EntityStatus Status { get; set; }
    }
}
