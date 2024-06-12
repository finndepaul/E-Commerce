using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class AddressConfig : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.ToTable("Address");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.WardCode).IsRequired();
            builder.Property(x => x.city).IsRequired();
            builder.Property(x => x.district).IsRequired();
            builder.HasOne(x => x.User).WithMany(x => x.Addresses).HasForeignKey(x => x.CreatedBy);

        }
    }
}
