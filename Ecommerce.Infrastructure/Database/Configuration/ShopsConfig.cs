using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Infrastructure.Database.Configuration
{
    internal class ShopsConfig : IEntityTypeConfiguration<Shops>
    {
        public void Configure(EntityTypeBuilder<Shops> builder)
        {
            builder.HasKey(x => x.ShopId);
            builder.HasOne(x => x.Users).WithOne(x => x.Shops).HasForeignKey<Shops>(x => x.CreatedBy);

        }
    }
}
