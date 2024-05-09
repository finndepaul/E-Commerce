using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Address
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string UserAddress { get; set; }
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // khóa ngọại 
        public virtual Users User { get; set; }

    }
}
