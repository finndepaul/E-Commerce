using Ecommerce.Application.ValueObj.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Example
{
    public class ViewExampleRequest : PaginationRequest
    {
        //search theo ten
        public string Name { get; set; }
    }
}
