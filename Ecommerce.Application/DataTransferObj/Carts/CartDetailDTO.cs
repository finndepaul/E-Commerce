using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Carts
{
    public class CartDetailDTO
    {
        public Guid Id { get; set; }
        public Guid CartID { get; set; }
        public Guid ProductID { get; set; }
        public decimal NumberOfProduct { get; set; }
        public decimal TotalMoney { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public List<string> ProductImages { get; set; }
    }
}
