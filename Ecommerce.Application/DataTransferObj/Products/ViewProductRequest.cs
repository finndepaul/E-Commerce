using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Products
{
    public class ViewProductRequest : PaginationRequest
    {
        public string? NameProduct { get; set; }
        public ProductStatus? Status { get; set; }
    }
}
