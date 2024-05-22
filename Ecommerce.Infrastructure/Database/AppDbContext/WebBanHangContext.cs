using Ecommerce.Domain.Database.Entities;
using Ecommerce.Infrastructure.Extention;
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
        #region DbSet
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
        //Mẫu
        public DbSet<Example> Examples { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SURINRIN\\SQLEXPRESS01;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");
            //optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            SeedingData(modelBuilder);
        }
        private void SeedingData(ModelBuilder modelBuilder)
        {
            var roleData = new List<Roles>()
            {
                new Roles
                {
                    ID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                    CreatedTime = DateTimeOffset.Now,
                    Status = Domain.Enum.EntityStatus.Active,
                    RoleName = "Admin",
                },
                new Roles
                {
                    ID = Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                    CreatedTime = DateTimeOffset.Now,
                    Status = Domain.Enum.EntityStatus.Active,
                    RoleName = "Client",
                }
            };
            modelBuilder.Entity<Roles>(b => { b.HasData(roleData); });
            var userData = new List<Users>()
            {
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    Username = "Dangs",
                    Email = "azusachan309@gmail.com",
                    Password = Hash.EncryptPassword("abc123"),
                    FullName = "DangsNguyen",
                    Status = Domain.Enum.EntityStatus.Active,
                    PhoneNumber = "0123456789",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                }, 
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    Username = "Trongnv",
                    Email = "trongnvph35790@fpt.edu.vn",
                    Password = Hash.EncryptPassword("abc123"),
                    FullName = "Nguyen Van Trong",
                    Status = Domain.Enum.EntityStatus.Active,
                    PhoneNumber = "0123456789",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                }, 
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    Username = "THEDZ",
                    Email = "thendph35306@fpt.edu.vn",
                    Password = Hash.EncryptPassword("abc123"),
                    FullName = "Nguyen Dinh The",
                    Status = Domain.Enum.EntityStatus.Active,
                    PhoneNumber ="0123456789",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                },
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    Username = "Dong",
                    Email = "dongbdph35416@fpt.edu.vn",
                    Password = Hash.EncryptPassword("abc123"),
                    FullName = "Bui Duy Dong",
                    Status = Domain.Enum.EntityStatus.Active,
                    PhoneNumber = "0123456789",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                }, 
                new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    Username = "Phong",
                    Email = "phongdxph35748@fpt.edu.vn",
                    Password = Hash.EncryptPassword("abc123"),
                    FullName = "Xuan Phong",
                    Status = Domain.Enum.EntityStatus.Active,
                    PhoneNumber = "0123456789",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                },  new Users {
                    ID = Guid.NewGuid(),
                    CreatedTime = DateTimeOffset.Now,
                    Username = "Hoang",
                    Email = "hoangpkph38105@fpt.edu.vn",
                    Password = Hash.EncryptPassword("abc123"),
                    FullName = "Hoang",
                    Status = Domain.Enum.EntityStatus.Active,
                    PhoneNumber = "0123456789",
                    RoleID = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),
                },
            };
            modelBuilder.Entity<Users>(b => { b.HasData(userData); });
            var productTypeData = new List<ProductTypes>()
            {
                new ProductTypes()
                {
                    ID = Guid.Parse("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                    CreatedTime = DateTimeOffset.Now,
                    ProductsTypeName = "Bánh",
                    Status = Domain.Enum.EntityStatus.Active
                }, new ProductTypes()
                {
                    ID = Guid.Parse("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                    CreatedTime = DateTimeOffset.Now,
                    ProductsTypeName = "Kẹo",
                    Status = Domain.Enum.EntityStatus.Active
                },
            };
            modelBuilder.Entity<ProductTypes>(b => { b.HasData(productTypeData); });
            var productData = new List<Products>()
            {
                new Products()
                {
                    ID = Guid.Parse("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                    CreatedTime = DateTimeOffset.Now,
                    Images = new List<string>()
                    {
                        "image1.jpg","image2.jpg"
                    },
                    Price = 20000,
                    Status = Domain.Enum.ProductStatus.Still,
                    DescriptionProduct = "Ngon",
                    NameProduct = "Bánh Oreon",
                    ProductTypeID = Guid.Parse("4f352b67-98ad-4557-9315-dea5a8fe1c15")
                },new Products()
                {
                    ID = Guid.Parse("db904ad3-02e7-444b-8595-9305638894ec"),
                    CreatedTime = DateTimeOffset.Now,
                    Images = new List<string>()
                    {
                        "image3.jpg","image4.jpg"
                    },
                    Price = 20000,
                    Status = Domain.Enum.ProductStatus.Still,
                    DescriptionProduct = "Ngon",
                    NameProduct = "Kẹo ChupaChup",
                     ProductTypeID = Guid.Parse("e701de07-7b1e-4d47-88fc-fa9ddf9457d9")
                },
            };
            modelBuilder.Entity<Products>(b => { b.HasData(productData); });
        }
    }
}
