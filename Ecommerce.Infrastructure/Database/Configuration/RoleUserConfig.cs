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
    public class RoleUserConfig : IEntityTypeConfiguration<RoleUser>
    {
        public void Configure(EntityTypeBuilder<RoleUser> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasOne(x=>x.Users).WithMany(x=>x.RoleUsers).HasForeignKey(x=>x.CreatedBy);
            builder.HasOne(x=>x.Roles).WithMany(x=>x.RoleUsers).HasForeignKey(x=>x.RoleId);
        }
    }
}
