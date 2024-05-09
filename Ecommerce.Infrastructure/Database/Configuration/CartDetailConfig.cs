using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class CartDetailConfig : IEntityTypeConfiguration<CartDetails>
    {
        public void Configure(EntityTypeBuilder<CartDetails> builder)
        {
            builder.ToTable("CartDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TotalMoney).HasDefaultValue(0);
            builder.Property(x => x.NumberOfProduct).HasDefaultValue(0);
            builder.HasOne(x => x.Carts).WithMany(x => x.CartDetails).HasForeignKey(x => x.CartID);
            builder.HasOne(x => x.Products).WithMany(x => x.CartDetails).HasForeignKey(x => x.ProductID);
        }
    }
}
