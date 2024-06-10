﻿using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.ProductType
{
    public class ProductTypeUpdateRequest
    {
        public Guid ID { get; set; }
        public string ProductsTypeName { get; set; }
        public EntityStatus Status { get; set; }
    }
}
