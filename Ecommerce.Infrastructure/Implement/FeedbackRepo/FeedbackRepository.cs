using AutoMapper;
using Ecommerce.Application.DataTransferObj.FeedBack;
using Ecommerce.Application.Interface;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Database.AppDbContext;
using Ecommerce.Infrastructure.Extention;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Implement.FeedbackRepo
{
    public class FeedbackRepository : IFeedBackRepository
    {
        private readonly WebBanHangContext _db;
        private readonly IMapper _map;

        public FeedbackRepository(WebBanHangContext db, IMapper map)
        {
            _db = db;
            _map = map;
        }

        public async Task<bool> Create(Feedbacks request, CancellationToken cancellationToken)
        {
            try
            {
               
                request.CreatedTime = DateTimeOffset.Now;
                
                await _db.Feedbacks.AddAsync(request, cancellationToken);
                await _db.SaveChangesAsync(cancellationToken);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private async Task<Feedbacks?> GetById(Guid id, CancellationToken cancellationToken)
        {
            var result = await _db.Feedbacks.FirstOrDefaultAsync(x => x.ID == id);
            return result;
        }

        public async Task<bool> Update(Feedbacks request, CancellationToken cancellationToken)
        {
            var result = await GetById(request.ID, cancellationToken);
            result.CustomerFeedback = request.CustomerFeedback;
            result.Rating = request.Rating;
            _db.Feedbacks.Update(result);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }

        public async Task<PaginationResponse<FeedBackDTO>> GetAll(ViewFeedBackRequest request, CancellationToken cancellationToken)
        {
            var query = _db.Feedbacks.Include(x => x.OrderDetails).ThenInclude(x=>x.Products).ThenInclude(x=>x.Shops).ThenInclude(x=>x.Users).AsNoTracking();
            var result = await query.PaginateAsync<Feedbacks,FeedBackDTO>(request, _map, cancellationToken);
            result.Data = (from a in result.Data
                          join b in query on a.ID equals b.ID
                          select new FeedBackDTO()
                          {
                              ID = b.ID,
                              CustomerFeedback = b.CustomerFeedback,
                              NameProduct = b.OrderDetails.Products.NameProduct,
                              OrderDetailID = b.OrderDetailID,
                              Rating = b.Rating,
                              Username = b.OrderDetails.Products.Shops.Users.Username
                          }).ToList();
            return new PaginationResponse<FeedBackDTO>()
            {
                Data = result.Data,
                HasNext = result.HasNext,
                PageNumber = result.PageNumber,
                PageSize = result.PageSize,
            };
        }

        public async Task<bool> Delete(Feedbacks request, CancellationToken cancellationToken)
        {
            var result = await GetById(request.ID, cancellationToken);
            result.Deleted = true;
            _db.Feedbacks.Update(result);
            await _db.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}
