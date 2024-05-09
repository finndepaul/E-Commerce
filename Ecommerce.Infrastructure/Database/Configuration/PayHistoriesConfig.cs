using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    public class PayHistoriesConfig : IEntityTypeConfiguration<PayHistories>
    {
        public void Configure(EntityTypeBuilder<PayHistories> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TimePay);
            builder.Property(x => x.MoneyPayed);
            builder.HasOne(x => x.PaymentExpressions).WithMany(x => x.PayHistories).HasForeignKey(x => x.PaymentExpressionID);
            builder.HasOne(x => x.Bills).WithMany(x => x.PayHistories).HasForeignKey(x => x.BillID);
        }
    }
}
