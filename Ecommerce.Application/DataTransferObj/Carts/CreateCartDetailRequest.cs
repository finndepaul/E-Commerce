using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Carts
{
    public class CreateCartDetailRequest
    {
        public Guid ProductID { get; set; }
        public decimal NumberOfProduct { get; set; }
        public Guid UserID { get; set; }
    }
}
