using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Newtonsoft.Json;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class ProductConfig : IEntityTypeConfiguration<Products>

    {
        public void Configure(EntityTypeBuilder<Products> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.ID);
            builder.Property(x => x.ID).ValueGeneratedOnAdd();
            builder.Property(x => x.NameProduct).HasMaxLength(50).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.DescriptionProduct).IsFixedLength().IsUnicode(true);
            builder.Property(x => x.Price).HasDefaultValue(0);
            builder.Property(x => x.Images).HasConversion(
               v => JsonConvert.SerializeObject(v),
               v => JsonConvert.DeserializeObject<List<string>>(v));
            builder.HasOne(x => x.ProductTypes).WithMany(x => x.Product).HasForeignKey(x => x.ProductTypeID);
        }
    }
}
