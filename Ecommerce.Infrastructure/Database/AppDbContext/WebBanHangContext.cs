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
		public DbSet<OrderDetails> OrderDetail { get; set; }
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
		public DbSet<RoleUser> RoleUsers { get; set; }
		public DbSet<Shops> Shops { get; set; }
		public DbSet<Feedbacks> Feedbacks { get; set; }

		//Mẫu
		public DbSet<Example> Examples { get; set; }
		#endregion


		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			// Đông

			//optionsBuilder.UseSqlServer("Data Source=DESKTOP-V6M0EF7\\SQLEXPRESS;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");


			// Hoàng
			//optionsBuilder.UseSqlServer("Data Source=MSI;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");

			// Đăng
			// optionsBuilder.UseSqlServer("Server=SURINRIN\\SQLEXPRESS01;Database=WebBanHang;Trusted_Connection=True;TrustServerCertificate=True");

			// Thế
			//optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");

			// Trọng
			optionsBuilder.UseSqlServer("Server=vantrong\\SQLEXPRESS;Database=WebBanHang;Trusted_Connection=True;TrustServerCertificate=True");

			// Phong

			//optionsBuilder.UseSqlServer("Data Source=PHONGKEDAY2\\PHONGKE2004;Initial Catalog=WebBanHang;Integrated Security=True; TrustServerCertificate=True");

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
				},  new Roles
				{
					ID = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
					RoleName = "Shop",
				},
			};
			modelBuilder.Entity<Roles>(b => { b.HasData(roleData); });
			var userData = new List<Users>()
			{
				new Users {
					ID = Guid.Parse("e589e999-152a-44a1-bb74-48883a4d302e"),
					CreatedTime = DateTimeOffset.Now,
					Username = "Dangs",
					Email = "azusachan309@gmail.com",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "DangsNguyen",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber = "0123456789",
				},
				new Users {
					ID = Guid.Parse("0be0ee12-f390-49c0-a775-df1933663b96"),
					CreatedTime = DateTimeOffset.Now,
					Username = "Trongnv",
					Email = "trongnvph35790@fpt.edu.vn",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "Nguyen Van Trong",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber = "0123456789",

				},
				new Users {
					ID = Guid.Parse("73fea99f-048e-44bf-8c3c-984f705530db"),
					CreatedTime = DateTimeOffset.Now,
					Username = "THEDZ",
					Email = "thendph35306@fpt.edu.vn",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "Nguyen Dinh The",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber ="0123456789",

				},
				new Users {
					ID = Guid.Parse("11b670d6-167a-42d4-be32-85cc970a218d"),
					CreatedTime = DateTimeOffset.Now,
					Username = "Dong",
					Email = "dongbdph35416@fpt.edu.vn",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "Bui Duy Dong",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber = "0123456789",
				},
				new Users {
					ID = Guid.Parse("8e0d06d1-5896-4886-a77e-6e794a212f92"),
					CreatedTime = DateTimeOffset.Now,
					Username = "Phong",
					Email = "phongdxph35748@fpt.edu.vn",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "Xuan Phong",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber = "0123456789",

				},  new Users {
					 ID = Guid.Parse("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),
					CreatedTime = DateTimeOffset.Now,

					Username = "Hoang",
					Email = "hoangpkph38105@fpt.edu.vn",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "Hoang",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber = "0123456789",

				},
				 new Users {
					ID = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
					CreatedTime = DateTimeOffset.Now,
					Username = "client",
					Email = "azusachan307@gmail.com",
					Password = Hash.EncryptPassword("abc123"),
					FullName = "Client Test",
					Status = Domain.Enum.EntityStatus.Active,
					PhoneNumber = "0123456789",

					}
			};
			modelBuilder.Entity<Users>(b => { b.HasData(userData); });
			var roleUserData = new List<RoleUser>
			{
				new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("e589e999-152a-44a1-bb74-48883a4d302e"),
					RoleId = Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("0be0ee12-f390-49c0-a775-df1933663b96"),

					RoleId =Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy =  Guid.Parse("73fea99f-048e-44bf-8c3c-984f705530db"),

					RoleId =Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("11b670d6-167a-42d4-be32-85cc970a218d"),

					RoleId =Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("8e0d06d1-5896-4886-a77e-6e794a212f92"),

					RoleId =Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),

					RoleId =Guid.Parse("25d7afcb-949b-4717-a961-b50f2e18657d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),

					RoleId =  Guid.Parse("ba820c64-1a81-4c44-80ea-47038c930c3b"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},
				new RoleUser()
				{
					Id = Guid.NewGuid(),
					CreatedBy = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
					RoleId = Guid.Parse("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),

					CreatedTime = DateTimeOffset.Now,
					Status = Domain.Enum.EntityStatus.Active,
				},
			};
			modelBuilder.Entity<RoleUser>(b => { b.HasData(roleUserData); });
			var shopsData = new Shops()
			{
				CreatedBy = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
				CreatedTime = DateTimeOffset.UtcNow,
				ShopAddress = "123 Street",
				ShopEmail = "azusachan307@gmail.com",
				ShopId = Guid.Parse("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),
				ShopImages = "avtShop1.jpg",
				ShopName = "Vinsmart",
				ShopPhone = "0905989504"
			};
			modelBuilder.Entity<Shops>(b => { b.HasData(shopsData); });

			var cartData = new Carts()
			{
				Id = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
				CreatedTime = DateTimeOffset.Now,
				CreatedBy = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
				Status = Domain.Enum.EntityStatus.Active,
				TotalMoney = 0,


			};
			modelBuilder.Entity<Carts>(b => { b.HasData(cartData); });
			/*  var addressData = new List<Address>()
			  {
				  new Address {
					  Id = Guid.NewGuid(),
					  CreatedBy = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
					  Status = Domain.Enum.EntityStatus.Active,
					  //UserAddress = "123 Streat",
				  }, new Address {
					  Id = Guid.NewGuid(),
					  CreatedBy = Guid.Parse("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
					  Status = Domain.Enum.EntityStatus.Active,
					  //UserAddress = "345 Streat",
				  },
			  };
			  modelBuilder.Entity<Address>(b => { b.HasData(addressData); });*/
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
					Status = Domain.Enum.ProductStatus.Approved,
					DescriptionProduct = "Ngon",
					NameProduct = "Bánh Oreon",
					ProductTypeID = Guid.Parse("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
					ShopId = Guid.Parse("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),

				},new Products()
				{
					ID = Guid.Parse("db904ad3-02e7-444b-8595-9305638894ec"),
					CreatedTime = DateTimeOffset.Now,
					Images = new List<string>()
					{
						"image3.jpg","image4.jpg"
					},
					Price = 20000,
					Status = Domain.Enum.ProductStatus.Waiting,
					DescriptionProduct = "Ngon",
					NameProduct = "Kẹo ChupaChup",
					ProductTypeID = Guid.Parse("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
					ShopId = Guid.Parse("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),

				},
			};
			for (int i = 0; i < 50; i++)
			{
				var product = new Products
				{
					ID = Guid.NewGuid(),
					CreatedTime = DateTimeOffset.Now.AddDays(i + 2),
					Images = new List<string>
{
	$"image{i+5}.jpg",
	$"image{i+6}.jpg"
},
					Price = 25000 + i * 500,
					Status = (i % 3 == 0) ? Domain.Enum.ProductStatus.Approved : (i % 3 == 1) ? Domain.Enum.ProductStatus.Waiting : Domain.Enum.ProductStatus.Out,
					DescriptionProduct = $"Product {i + 3} Description",
					NameProduct = $"Product {i + 3}",
					ProductTypeID = Guid.Parse("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
					ShopId = Guid.Parse("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a")
				};

				modelBuilder.Entity<Products>(b => { b.HasData(product); });
			}

			modelBuilder.Entity<Products>(b => { b.HasData(productData); });
			var cartDetailData = new CartDetails()
			{
				Id = Guid.NewGuid(),
				CreatedTime = DateTimeOffset.Now,
				CartID = Guid.Parse("EF578DBC-71F7-474F-A6EB-84DEB7F15C15"),
				CreatedBy = Guid.Parse("EF578DBC-71F7-474F-A6EB-84DEB7F15C15"),
				ProductID = Guid.Parse("E5512865-9AAB-437E-A28D-DB8DB44C6EA1"),
				NumberOfProduct = 2,
				Status = Domain.Enum.EntityStatus.Active,
				TotalMoney = 60000,

			};
			modelBuilder.Entity<CartDetails>(b => { b.HasData(cartDetailData); });
			var orderDetailData = new OrderDetails()
			{
				ID = Guid.NewGuid(),
				Price = 60000,
				NumberOfProduct = 3,
				CreatedTime = DateTimeOffset.Now,
				CreatedBy = Guid.Parse("EF578DBC-71F7-474F-A6EB-84DEB7F15C15"),
				ProductID = Guid.Parse("E5512865-9AAB-437E-A28D-DB8DB44C6EA1"),
			};
			modelBuilder.Entity<OrderDetails>(b => { b.HasData(orderDetailData); });
			var billData = new Bills()
			{
				Id = Guid.Parse("01fa417d-7900-4199-8ad9-cbb397c14235"),
				ShopId = Guid.Parse("30D26F28-6E0A-4ECD-A5FE-0A683FDFA93A"),
				TotalMoney = 60000,
				SoldDate = DateTime.UtcNow,
				Status = Domain.Enum.EntityStatus.Active,
				CreatedTime = DateTimeOffset.Now,
				CreatedBy = Guid.Parse("EF578DBC-71F7-474F-A6EB-84DEB7F15C15"),

			};
			modelBuilder.Entity<Bills>(b => { b.HasData(billData); });
			var billDetailData = new BillDetails()
			{
				ID = Guid.NewGuid(),
				Price = 60000,
				BillID = Guid.Parse("01fa417d-7900-4199-8ad9-cbb397c14235"),
				Status = Domain.Enum.EntityStatus.Active,
				NumberOfProduct = 3,
				CreatedTime = DateTimeOffset.Now,
				CreatedBy = Guid.Parse("EF578DBC-71F7-474F-A6EB-84DEB7F15C15"),
				ProductID = Guid.Parse("E5512865-9AAB-437E-A28D-DB8DB44C6EA1"),
			};
			modelBuilder.Entity<BillDetails>(b => { b.HasData(billDetailData); });

		}
	}
}