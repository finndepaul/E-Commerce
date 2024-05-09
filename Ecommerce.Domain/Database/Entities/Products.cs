using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Products
    {
        public Guid ID { get; set; }
        public Guid ProductTypeID { get; set; }
        public string? NameProduct { get; set; }
        public string? DescriptionProduct { get; set; } // mô tả
        public decimal Price { get; set; }
        public List<string> Images { get; set; } = new List<string>();
        public ProductStatus Status { get; set; } = ProductStatus.Still;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // khóa  ngoại 
        public virtual ICollection<SaleDetails>? SaleDetails { get; set; }
        public virtual ICollection<VoucherDetails>? VoucherDetails { get; set; }
        public virtual ICollection<BillDetails>? BillDetails { get; set; }
        public virtual ICollection<CartDetails>? CartDetails { get; set; }
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
        public virtual ProductTypes? ProductTypes { get; set; }

    }
}
