using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Products
{
    public class ProductDTO
    {
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }  
        public List<string> ProductImages { get; set; }
        public string ShopName { get; set; }
        
    }
}
