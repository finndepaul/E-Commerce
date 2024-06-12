using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.FeedBack
{
    public class FeedBackDeleteRequest
    {
        public Guid ID { get; set; }
        public Guid? DeletedBy { get; set; }
    }
}
