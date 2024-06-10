using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Products
{
    public class ProductReviewDTO
    {
        public Guid Id { get; set; }
        public Guid? ModifiedBy { get; set; }
        public ProductStatus Status { get; set; }
    }
}
