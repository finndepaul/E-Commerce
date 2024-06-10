using Ecommerce.Application.Interface;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Ecommerce.Infrastructure.Implement.RoleUserRepo;
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
        private readonly RoleUserRepository _roleRepos;     

        public UserRepository(WebBanHangContext context, RoleUserRepository roleRepos)
        {
            _context = context;
            _roleRepos = roleRepos;
        }

        public async Task<ErrorMessage> Register(Users users, CancellationToken cancellationToken)
        {
            try
            {
                if (users.Username != null || users.Email != null) 
                {
                    return ErrorMessage.Faild;
                }
                users.Password = Hash.EncryptPassword(users.Password); // mã hóa pass
                users.Status = EntityStatus.Active;
                users.CreatedTime = DateTimeOffset.Now; // đầy đủ thông tin thời gian
                await _context.User.AddAsync(users);
                await _context.SaveChangesAsync(cancellationToken);

                var cart = new Carts()
                {
                    Id = users.ID,
                    CreatedBy = users.ID,
                    TotalMoney = 0,
                    Status = EntityStatus.Active,
                    CreatedTime = DateTimeOffset.Now,
                };
                await _roleRepos.Create(new RoleUser()
                {
                    RoleId = Guid.Parse("BA820C64-1A81-4C44-80EA-47038C930C3B"),
                    CreatedBy = users.ID,
                }, cancellationToken);
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
