using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class SaleTypeConfig : IEntityTypeConfiguration<SaleTypes>
    {
        public void Configure(EntityTypeBuilder<SaleTypes> builder)
        {
            builder.ToTable("SaleType");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.SaleTypeName).HasMaxLength(50).IsFixedLength().IsUnicode(true);

        }
    }
}
