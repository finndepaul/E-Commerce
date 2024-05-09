using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DuAnBanHang.Domain.Configurations
{
    public class FeedbackConfig : IEntityTypeConfiguration<Feedbacks>
    {
        public void Configure(EntityTypeBuilder<Feedbacks> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.OrderDetails).WithOne(x => x.Feedbacks).HasForeignKey<Feedbacks>(x => x.OrderDetailID);
        }
    }
}
