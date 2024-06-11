using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.SaleDetail
{
    public class SaleDetailDTO
    {
        public Guid ID { get; set; }
        public Guid IdSale { get; set; }
        public Guid IdProduct { get; set; }
        public decimal Discount { get; set; }
        public int CountProduct { get; set; }
        public EntityStatus Status { get; set; } 
  
    }
}
