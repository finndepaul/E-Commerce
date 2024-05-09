﻿using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class ProductTypes
    {
        public Guid ID { get; set; }
        public string ProductsTypeName { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // ForeignKey
        public virtual ICollection<Products>? Product { get; set; }
    }
}
