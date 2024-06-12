using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Oders
{
    public class GetFeeRequest
    {
        public Guid ID_Shop { get; set; }
        public Guid ID_Cus { get; set; }
        public int insurance_value { get; set; }
        public string weight { get; set; }
        public string length { get; set; }
        public string width { get; set; }
        public string height { get; set; }

    }
}
