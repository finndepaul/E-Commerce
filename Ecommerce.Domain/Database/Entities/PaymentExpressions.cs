using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class PaymentExpressions : EntityBase
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
   

        // ForeignKey 
        public virtual ICollection<PayHistories>? PayHistories { get; set; }
    }
}
