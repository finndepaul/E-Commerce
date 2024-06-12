using Ecommerce.Application.DataTransferObj.FeedBack;
using Ecommerce.Application.ValueObj.Pagination;
using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Application.Interface
{
    public interface IFeedBackRepository
    {
        Task<PaginationResponse<FeedBackDTO>> GetAll(ViewFeedBackRequest request, CancellationToken cancellationToken);
        Task<bool> Create(Feedbacks request, CancellationToken cancellationToken);
        Task<bool> Update(Feedbacks request, CancellationToken cancellationToken);
        Task<bool> Delete(Feedbacks request, CancellationToken cancellationToken);

    }
}
