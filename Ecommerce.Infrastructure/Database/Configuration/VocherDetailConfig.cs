using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class VocherDetailConfig : IEntityTypeConfiguration<VoucherDetails>
    {
        public void Configure(EntityTypeBuilder<VoucherDetails> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.HasOne(x => x.Products).WithMany(x => x.VoucherDetails).HasForeignKey(x => x.ProductID);
            builder.HasOne(x => x.Vouchers).WithMany(x => x.VoucherDetails).HasForeignKey(x => x.VocherID);
        }
    }
}
