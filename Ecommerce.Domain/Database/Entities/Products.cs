using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Products : EntityBase
    {
        public Guid ID { get; set; }
        public Guid ProductTypeID { get; set; }
        public Guid ShopId { get; set; }
        public string? NameProduct { get; set; }
        public string? DescriptionProduct { get; set; } // mô tả
        public decimal Price { get; set; }
        public List<string> Images { get; set; } = new List<string>();
        public int Quantity { get; set; }
        public ProductStatus Status { get; set; } = ProductStatus.Waiting;


        // khóa  ngoại 
        public virtual ICollection<SaleDetails>? SaleDetails { get; set; }
        public virtual ICollection<VoucherDetails>? VoucherDetails { get; set; }
        public virtual ICollection<BillDetails>? BillDetails { get; set; }
        public virtual ICollection<CartDetails>? CartDetails { get; set; }
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
        public virtual ProductTypes? ProductTypes { get; set; }
        public virtual Shops? Shops { get; set; }


    }
}
