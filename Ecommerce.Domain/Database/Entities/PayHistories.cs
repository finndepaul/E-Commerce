using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class PayHistories // là lớp trung gian giữa Hình thức thanh toán với hóa đơn => mqh n-n 
        : EntityBase
    {
        public Guid Id { get; set; }
        public Guid PaymentExpressionID { get; set; }
        public Guid BillID { get; set; }
        public DateTime TimePay { get; set; }
        public decimal MoneyPayed { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
  

        // ForeignKey 
        public virtual PaymentExpressions? PaymentExpressions { get; set; }
        public virtual Bills? Bills { get; set; }
    }
}
