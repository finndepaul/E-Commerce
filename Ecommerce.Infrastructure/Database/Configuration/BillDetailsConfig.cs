using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class BillDetailsConfig : IEntityTypeConfiguration<BillDetails>
    {
        public void Configure(EntityTypeBuilder<BillDetails> builder)
        {
            builder.ToTable("BillDetail");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Bills).WithMany(x => x.BillDetails).HasForeignKey(x => x.BillID);
            builder.HasOne(x => x.Products).WithMany(x => x.BillDetails).HasForeignKey(x => x.ProductID);
            builder.Property(x => x.NumberOfProduct).HasColumnName("NumberOfProduct").HasDefaultValue(0);
        }
    }
}
