using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Bills : EntityBase
    {
        public Guid Id { get; set; }
        public DateTime SoldDate { get; set; } = DateTime.Now;
        public decimal TotalMoney { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        
        public Guid ShopId { get; set; }
        // foreignKey 
        public virtual ICollection<PayHistories>? PayHistories { get; set; }
        public virtual ICollection<BillDetails>? BillDetails { get; set; }
        public virtual ICollection<Vouchers>? Vouchers { get; set; }
        //public virtual Shops Shops { get; set; }

        public virtual Users Users { get; set; }

    }
}
