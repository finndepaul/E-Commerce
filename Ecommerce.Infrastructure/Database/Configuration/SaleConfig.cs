using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class SaleConfig : IEntityTypeConfiguration<Sales>
    {
        public void Configure(EntityTypeBuilder<Sales> builder)
        {
            builder.ToTable("Sale");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.SaleName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.TimeEnd);
            builder.Property(x => x.TimeStart);
            builder.HasOne(x => x.SaleTypes).WithMany(x => x.Sale).HasForeignKey(x => x.SaleTypeId);
        }
    }
}
