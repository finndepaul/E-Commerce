using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Bills
    {
        public Guid Id { get; set; }
        public Guid UserID { get; set; }
        public DateTime SoldDate { get; set; } = DateTime.Now;
        public decimal TotalMoney { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // foreignKey 
        public virtual ICollection<PayHistories>? PayHistories { get; set; }
        public virtual ICollection<BillDetails>? BillDetails { get; set; }
        public virtual ICollection<Vouchers>? Vouchers { get; set; }

        public virtual Users Users { get; set; }

    }
}
