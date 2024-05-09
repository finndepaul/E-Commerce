using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class ProductTypeConfig : IEntityTypeConfiguration<ProductTypes>
    {
        public void Configure(EntityTypeBuilder<ProductTypes> builder)
        {
            builder.ToTable("ProductType");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.ProductsTypeName).HasMaxLength(50).IsFixedLength().IsUnicode(true);
        }
    }
}
