using Ecommerce.Domain.Database.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Ecommerce.Infrastructure.Database.AppDbContext
{
    public class WebBanHangContext : DbContext
    {
        public WebBanHangContext()
        {
        }

        public WebBanHangContext(DbContextOptions<WebBanHangContext> options)
            : base(options)
        {
        }
        public DbSet<BillDetails> BillDetail { get; set; }
        public DbSet<Bills> Bill { get; set; }
        public DbSet<Carts> Cart { get; set; }
        public DbSet<CartDetails> CartDetail { get; set; }
        public DbSet<PayHistories> PayHistory { get; set; }
        public DbSet<PaymentExpressions> PaymentExpression { get; set; }
        public DbSet<Products> Product { get; set; }
        public DbSet<ProductTypes> ProductType { get; set; }
        public DbSet<Sales> Sale { get; set; }
        public DbSet<SaleDetails> SaleDetail { get; set; }
        public DbSet<SaleTypes> SaleType { get; set; }
        public DbSet<Vouchers> Vocher { get; set; }
        public DbSet<VoucherDetails> VocherDetail { get; set; }
        public DbSet<VoucherTypes> VocherType { get; set; }
        public DbSet<Users> User { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Roles> Role { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SURINRIN\\SQLEXPRESS01;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
