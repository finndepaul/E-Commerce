using AutoMapper;
using Ecommerce.Application.DataTransferObj.IRoleUser;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Infrastructure.Implement.RoleUserRepo
{
    public class RoleUserRepository : IRoleUserRepository
    {
        private readonly WebBanHangContext _db;
        private readonly IMapper _map;

        public RoleUserRepository(WebBanHangContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }

        public async Task<bool> Create(RoleUser request, CancellationToken cancellationToken)
        {
            try
            {
                request.Status = Domain.Enum.EntityStatus.Active;
                request.CreatedTime = DateTimeOffset.Now;
                await _db.RoleUsers.AddAsync(request, cancellationToken);
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public async Task<bool> Delete(RoleUser request, CancellationToken cancellationToken)
        {
            var result = await GetById(request.Id, cancellationToken);
            result.Status = Domain.Enum.EntityStatus.Deleted;
            result.DeletedTime = DateTimeOffset.Now;
            result.Deleted = true;
         
            _db.RoleUsers.Update(result);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<PaginationResponse<RoleUserDTO>> GetAll(ViewRoleUserRequest request, CancellationToken cancellationToken)
        {
            var query = _db.RoleUsers.Include(x => x.Users).Include(x => x.Roles).AsNoTracking();
            if (!string.IsNullOrWhiteSpace(request.SearchName))
            {
                query = query.Where(x => x.Users.Username == request.SearchName);
            }
            var result = await query.PaginateAsync<Domain.Database.Entities.RoleUser, RoleUserDTO>(request, _map, cancellationToken);
            result.Data = (from item in query
                           select new RoleUserDTO
                           {
                               RoleName = item.Roles.RoleName,
                               UserName = item.Users.Username,
                               Status = item.Status,
                           }).ToList();
            return new PaginationResponse<RoleUserDTO>()
            {
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
                Data = result.Data
            };
        }

        private async Task<RoleUser?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _db.RoleUsers.FirstOrDefaultAsync(x => x.Id == id);
            return result;
        }

        public async Task<bool> Update(Domain.Database.Entities.RoleUser request, CancellationToken cancellationToken)
        {
            var result = await GetById(request.Id, cancellationToken);
            result.RoleId = result.RoleId;
            result.ModifiedBy = request.ModifiedBy;
            result.Status = request.Status;
      
            _db.RoleUsers.Update(result);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
