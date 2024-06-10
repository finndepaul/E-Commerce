using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class BillConfig : IEntityTypeConfiguration<Bills>
    {
        public void Configure(EntityTypeBuilder<Bills> builder)
        {
            builder.ToTable("Bill");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd(); // tự gen id
                                                               // foreignKey
            builder.HasOne(x => x.Users).WithMany(x => x.Bills).HasForeignKey(x => x.CreatedBy);
            //builder.HasOne(x => x.Shops).WithMany(x => x.Bills).HasForeignKey(x => x.ShopId);
            builder.Property(x => x.SoldDate).HasColumnName("SoldDate");
        }
    }
}
