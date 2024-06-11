using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.FeedBack
{
    public class FeedBackUpdateRequest
    {
        public Guid ID { get; set; }
        public string CustomerFeedback { get; set; }
        public int Rating { get; set; }
    }
}
