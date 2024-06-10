using Ecommerce.Application.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Sale
{
    public class ViewSaleResquest : PaginationRequest
    {
        public string SaleName { get; set; }
    }
}
