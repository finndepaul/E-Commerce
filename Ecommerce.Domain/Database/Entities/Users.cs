using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Users
    {
        public Guid ID { get; set; }
        public Guid RoleID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
        public DateTimeOffset CreatedTime { get; set; } = DateTimeOffset.Now;
        public Guid? CreatedBy { get; set; }
        public DateTimeOffset ModifiedTime { get; set; } = DateTimeOffset.Now;
        public Guid? ModifiedBy { get; set; }
        public bool? Deleted { get; set; }
        public Guid? DeletedBy { get; set; }
        public DateTimeOffset DeletedTime { get; set; } = DateTimeOffset.Now;

        // khóa ngoại 
        public virtual ICollection<Bills>? Bills { get; set; }
        public virtual ICollection<Address>? Addresses { get; set; }
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
        public virtual Roles Roles { get; set; }
        public virtual Carts Carts { get; set; }
    }
}
