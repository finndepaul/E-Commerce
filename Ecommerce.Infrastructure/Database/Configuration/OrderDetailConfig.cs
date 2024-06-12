using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class OrderDetailConfig : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(x => x.ID);
            builder.HasOne(x => x.Products).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.Users).WithMany(x => x.OrderDetails).HasForeignKey(x => x.CreatedBy);
            builder.HasOne(x => x.Feedbacks).WithOne(x => x.OrderDetails).HasForeignKey<Feedbacks>(x => x.OrderDetailID); 
        }
    }
}
