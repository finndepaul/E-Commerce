using Ecommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.DataTransferObj.User.Request
{
    public class UserDto
    {
        public Guid ID { get; set; }
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string? ConfirmCode { get; set; }
        public DateTimeOffset? SentTime { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public EntityStatus Status { get; set; }
    }
}
