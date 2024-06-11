using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Carts
{
    public class DeleteCartDetailRequest
    {
        public Guid CartDetailId { get; set; }
        public Guid UserID { get; set; }
    }
}
