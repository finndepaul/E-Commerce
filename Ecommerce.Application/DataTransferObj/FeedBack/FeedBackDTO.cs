using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.FeedBack
{
    public class FeedBackDTO
    {
        public Guid ID { get; set; }
        public Guid OrderDetailID { get; set; }
        public string CustomerFeedback { get; set; }
        public string Username { get; set; }
        public string NameProduct { get; set; }
        public int Rating { get; set; }

    }
}
