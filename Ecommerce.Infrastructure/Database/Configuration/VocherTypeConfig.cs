using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class VocherTypeConfig : IEntityTypeConfiguration<VoucherTypes>
    {
        public void Configure(EntityTypeBuilder<VoucherTypes> builder)
        {
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.VocherTypeName).HasMaxLength(50).IsFixedLength();

        }
    }
}
