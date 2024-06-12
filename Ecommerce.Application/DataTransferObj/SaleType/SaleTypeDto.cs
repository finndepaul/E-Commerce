using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.SaleType
{
    public class SaleTypeDto
    {
        public Guid Id { get; set; }
        public Guid SaleID { get; set; }
        public string SaleTypeName { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
    }
}
