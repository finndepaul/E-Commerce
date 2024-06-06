using Ecommerce.Domain.Database.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Domain.Database.Entities
{
    public class Shops : EntityBase
    {
        public Guid ShopId { get; set; }    
        public string ShopName { get; set; }
        public string ShopAddress { get; set; }
        public string ShopPhone { get; set; }
        public string ShopEmail { get; set; }
        public string ShopImages { get; set; }
        public virtual Users? Users { get; set; }
        //public virtual ICollection<Bills> Bills { get; set; }
        public virtual ICollection<Products>? Products { get; set; }



    }
}
