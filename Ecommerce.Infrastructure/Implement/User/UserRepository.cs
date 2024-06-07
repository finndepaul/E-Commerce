using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.User
{
    public class UserRepository : IUserRepository
    {
        private readonly WebBanHangContext _context;
        public UserRepository()
        {
            _context = new WebBanHangContext();
        }
        public async Task<ErrorMessage> Register(Users users, CancellationToken cancellationToken)
        {
            try
            {
                users.Password = Hash.EncryptPassword(users.Password); // mã hóa pass
                users.Status = EntityStatus.Active;
                users.CreatedTime = DateTimeOffset.Now; // đầy đủ thông tin thời gian
                await _context.User.AddAsync(users);
                await _context.SaveChangesAsync(cancellationToken);

                var cart = new Domain.Database.Entities.Carts()
                {
                    Id = users.ID,
                    CreatedBy = users.ID,
                    TotalMoney = 0,
                    Status = EntityStatus.Active,
                    CreatedTime = DateTimeOffset.Now,
                };
                await _context.Cart.AddAsync(cart);
                await _context.SaveChangesAsync(cancellationToken);
                return ErrorMessage.Successfull;
            }
            catch (Exception)
            {
                return ErrorMessage.Faild;
            }
        }
    }
}
