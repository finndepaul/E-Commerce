using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Oders
{
    public class BillDetailDto
    {
        public Guid Id { get; set; }
        public Guid ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int NumberOfProduct { get; set; }
    }
}
