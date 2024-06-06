using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.ProductType
{
    public class ViewProductTypeRequest :PaginationRequest
    {
        public string ProductsTypeName { get; set; }
    }
}
