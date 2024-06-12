using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.FeedBack
{
    public class FeedBackCreateRequest
    {
        public Guid OrderDetailID { get; set; }
        public string CustomerFeedback { get; set; }
        public int Rating { get; set; }
    }
}
