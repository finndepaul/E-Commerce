using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class PaymentExpressionConfig : IEntityTypeConfiguration<PaymentExpressions>
    {
        public void Configure(EntityTypeBuilder<PaymentExpressions> builder)
        {
            builder.ToTable("PaymentExpressions:");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Name).HasMaxLength(50).IsFixedLength().IsUnicode(true);
        }
    }
}
