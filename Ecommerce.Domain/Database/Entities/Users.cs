using Ecommerce.Domain.Database.Base;
using Ecommerce.Domain.Enum;

namespace Ecommerce.Domain.Database.Entities
{
    public class Users : EntityBase
    {
        public Guid ID { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public EntityStatus Status { get; set; } = EntityStatus.Active;
  

        // khóa ngoại 
        public virtual ICollection<Bills>? Bills { get; set; }
        public virtual ICollection<RoleUser>? RoleUsers { get; set; }
        public virtual ICollection<Address>? Addresses { get; set; }
        public virtual ICollection<OrderDetails>? OrderDetails { get; set; }
        public virtual Carts Carts { get; set; }
        public virtual Shops? Shops { get; set; }

    }
}
