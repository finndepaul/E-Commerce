using AutoMapper;
using Ecommerce.Application.DataTransferObj.User.Request;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Domain.Enum;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Ecommerce.Infrastructure.Implement.RoleUserRepo;
using Microsoft.EntityFrameworkCore;
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
        private readonly IMapper _map;
        public UserRepository(WebBanHangContext context ,IMapper map)
        {
            _context = context;
            _roleRepos = new RoleUserRepository(context, map);
            _map = map;
        }

        public bool EmailExists(string email)
        {
            return _context.User.Any(u => u.Email == email);
        }
        public bool UserExists(string username) 
        {
            return _context.User.Any(x=>x.Username == username);
        }
        public async Task<ErrorMessage> Register(Users users, CancellationToken cancellationToken)
        {
            try
            {
                if (EmailExists(users.Email) && UserExists(users.Username))
                {
                    return ErrorMessage.Faild;
                }
                else
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
                    await _roleRepos.Create(new RoleUser()
                    {
                        RoleId = Guid.Parse("BA820C64-1A81-4C44-80EA-47038C930C3B"),
                        CreatedBy = users.ID,
                    }, cancellationToken);
                  
                    return ErrorMessage.Successfull;
                }
            }
            catch (Exception)
            {
                return ErrorMessage.Faild;
            }
        }

        public async Task<PaginationResponse<UserDto>> GetAllUsers(ViewUserRequest request, CancellationToken cancellationToken)
        {
            var query = _context.User.AsNoTracking();

            if (!string.IsNullOrWhiteSpace(request.FullName))
            {
                query = query.Where(x => x.FullName.Contains(request.FullName.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(request.Email))
            {
                query = query.Where(x => x.Email.Contains(request.Email.ToLower()));
            }
            if (!string.IsNullOrWhiteSpace(request.Username))
            {
                query = query.Where(x => x.Username.Contains(request.Username.ToLower()));
            }
            if (request.Status.HasValue)
            {
                query = query.Where(x => x.Status == request.Status);
            }

            var totalItems = await query.CountAsync(cancellationToken);
            var totalPages = (int)Math.Ceiling(totalItems / (double)request.PageSize);

            var users = await query
                .Skip((request.PageNumber - 1) * request.PageSize)
                .Take(request.PageSize)
                .ToListAsync(cancellationToken);

            var userDtos = _map.Map<List<UserDto>>(users);

            return new PaginationResponse<UserDto>
            {
                PageNumber = request.PageNumber,
                PageSize = request.PageSize,
                HasNext = request.PageNumber < totalPages,
                Data = userDtos
            };
        }


        public async Task<UserDto> GetUserById(Guid id, CancellationToken cancellationToken)
        {
            var user = await _context.User.FindAsync(id, cancellationToken);
            return _map.Map<UserDto>(user);
        }

        public async Task<ErrorMessage> UpdateUser(UserUpdateRequest request, CancellationToken cancellationToken)
        {
            var user = await _context.User.FindAsync(request.Id, cancellationToken);
            if (user == null)
            {
                return ErrorMessage.Faild;
            }

            _map.Map(request, user);
            _context.User.Update(user);
            await _context.SaveChangesAsync(cancellationToken);
            return ErrorMessage.Successfull;
        }

        public async Task<bool> DeleteUser(Guid id, CancellationToken cancellationToken)
        {
            
            var user = await _context.User.FirstOrDefaultAsync( x => x.ID == id ,cancellationToken);
            if (user != null)
            {
                _context.User.Remove(user);
                await _context.SaveChangesAsync();
                return true;
            }


                return false;
        }
    }
}
