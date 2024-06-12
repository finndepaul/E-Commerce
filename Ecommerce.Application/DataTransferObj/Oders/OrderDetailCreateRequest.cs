using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Oders
{
    public class OrderDetailCreateRequest
    {
        public Guid ProductID { get; set; }
        public Guid? CreatedBy { get; set; }
        public decimal Shipfee { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
    }
}
