using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Products
{
    public class ProductDTO
    {
        public Guid ID { get; set; }
        public string NameProduct { get; set; }
        public string DescriptionProduct { get; set; }
        public decimal Price { get; set; }  
        public List<string> Images { get; set; }
        public int Quantity { get; set; }
        public string ProductsTypeName { get; set; }
        public string ShopName { get; set; }
        public ProductStatus Status { get; set; } 
    }
}
