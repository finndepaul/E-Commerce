    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Oders
{
    public class PurchaseRequest
    {
        public Guid UserId { get; set; }
        public List<Guid> CartDetailIds { get; set; }
        public Guid PaymentExpressionID { get; set; } // ID phương thức thanh toán
    }
}
