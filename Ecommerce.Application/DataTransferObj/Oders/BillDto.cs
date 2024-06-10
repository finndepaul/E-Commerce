using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.Oders
{
    public class BillDto
    {
        public Guid Id { get; set; }
        public DateTime SoldDate { get; set; }
        public decimal TotalMoney { get; set; }
        public List<BillDetailDto> BillDetails { get; set; }
    }
}
