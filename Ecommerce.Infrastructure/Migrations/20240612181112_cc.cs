using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class cc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentExpressions:",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentExpressions:", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductsTypeName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SaleType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleTypeName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nchar(10)", fixedLength: true, maxLength: 10, nullable: false),
                    Email = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    ConfirmCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SentTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    Username = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VocherType",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VocherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VocherTypeName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocherType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaleName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Sale_SaleType_SaleTypeId",
                        column: x => x.SaleTypeId,
                        principalTable: "SaleType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    city = table.Column<int>(type: "int", nullable: false),
                    district = table.Column<int>(type: "int", nullable: false),
                    WardCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Address_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoldDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ShopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bill_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Cart",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cart", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cart_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleUsers_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUsers_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopImages = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                    table.ForeignKey(
                        name: "FK_Shops_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "PayHistory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PaymentExpressionID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TimePay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MoneyPayed = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayHistory", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PayHistory_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PayHistory_PaymentExpressions:_PaymentExpressionID",
                        column: x => x.PaymentExpressionID,
                        principalTable: "PaymentExpressions:",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Vocher",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VocherTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VocherName = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    TimeStart = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TimeEnd = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vocher", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vocher_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vocher_VocherType_VocherTypeID",
                        column: x => x.VocherTypeID,
                        principalTable: "VocherType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ShopId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NameProduct = table.Column<string>(type: "nchar(50)", fixedLength: true, maxLength: 50, nullable: true),
                    DescriptionProduct = table.Column<string>(type: "nchar(256)", fixedLength: true, maxLength: 256, nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Images = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Product_ProductType_ProductTypeID",
                        column: x => x.ProductTypeID,
                        principalTable: "ProductType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Shops_ShopId",
                        column: x => x.ShopId,
                        principalTable: "Shops",
                        principalColumn: "ShopId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BillID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfProduct = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BillDetail_Bill_BillID",
                        column: x => x.BillID,
                        principalTable: "Bill",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BillDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfProduct = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    TotalMoney = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CartDetail_Cart_CartID",
                        column: x => x.CartID,
                        principalTable: "Cart",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfProduct = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Shipfee = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.ID);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_User_CreatedBy",
                        column: x => x.CreatedBy,
                        principalTable: "User",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "SaleDetails",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdSale = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdProduct = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    CountProduct = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaleDetails", x => x.ID);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Product_IdProduct",
                        column: x => x.IdProduct,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SaleDetails_Sale_IdSale",
                        column: x => x.IdSale,
                        principalTable: "Sale",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VocherDetail",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VocherID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VocherDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VocherDetail_Product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Product",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VocherDetail_Vocher_VocherID",
                        column: x => x.VocherID,
                        principalTable: "Vocher",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDetailID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerFeedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreatedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ModifiedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Deleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletedTime = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Feedbacks_OrderDetail_OrderDetailID",
                        column: x => x.OrderDetailID,
                        principalTable: "OrderDetail",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductType",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "ProductsTypeName", "Status" },
                values: new object[,]
                {
                    { new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4747), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Bánh", 1 },
                    { new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4752), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Kẹo", 1 }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[,]
                {
                    { new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(3868), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Admin", 1 },
                    { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(3915), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Shop", 1 },
                    { new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(3907), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Client", 1 }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "ConfirmCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "ModifiedBy", "ModifiedTime", "Password", "PhoneNumber", "SentTime", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4292), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Nguyen Van Trong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "Trongnv" },
                    { new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4334), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dongbdph35416@fpt.edu.vn", "Bui Duy Dong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "Dong" },
                    { new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4395), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hoangpkph38105@fpt.edu.vn", "Hoang", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "Hoang" },
                    { new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4313), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "thendph35306@fpt.edu.vn", "Nguyen Dinh The", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "THEDZ" },
                    { new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4371), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "phongdxph35748@fpt.edu.vn", "Xuan Phong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "Phong" },
                    { new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4005), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan309@gmail.com", "DangsNguyen", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "Dangs" },
                    { new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), null, null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4417), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan307@gmail.com", "Client Test", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", null, 1, "client" }
                });

            migrationBuilder.InsertData(
                table: "Bill",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "ShopId", "SoldDate", "Status", "TotalMoney" },
                values: new object[] { new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5827), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), new DateTime(2024, 6, 12, 18, 11, 11, 932, DateTimeKind.Utc).AddTicks(5827), 1, 60000m });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status" },
                values: new object[] { new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4709), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("04498058-1910-42ed-b42f-337a32b43b90"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4502), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("07ad4181-298c-4b07-b04d-b770476fb945"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4516), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("0c18c41d-9ad7-4e14-bdd5-bce2a6d704b0"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4505), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("2910abe2-9617-4b82-a405-67741c2417da"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4496), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("aeed2612-df73-4035-bbd5-9d5d6c0161b1"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4525), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b3040095-c53d-4c36-818f-921f0a1700f8"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4511), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("be19867c-8c07-4f8c-a501-fa88d9d9e9be"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4528), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("c500eb19-0cc5-4527-9c04-4eb04b04f04f"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4508), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "ShopAddress", "ShopEmail", "ShopImages", "ShopName", "ShopPhone" },
                values: new object[] { new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 18, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4558), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "123 Street", "azusachan307@gmail.com", "avtShop1.jpg", "Vinsmart", "0905989504" });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "DescriptionProduct", "Images", "ModifiedBy", "ModifiedTime", "NameProduct", "Price", "ProductTypeID", "Quantity", "ShopId", "Status" },
                values: new object[,]
                {
                    { new Guid("0406252c-b7cc-4ee7-bb45-2e03aaa343b3"), null, new DateTimeOffset(new DateTime(2024, 7, 15, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5422), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 33 Description", "[\"image35.jpg\",\"image36.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 33", 40000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("143dfcf8-6312-4d78-9fc3-637cb87bd945"), null, new DateTimeOffset(new DateTime(2024, 7, 29, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5656), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 47 Description", "[\"image49.jpg\",\"image50.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 47", 47000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("16771674-b3b5-47cf-98d6-d7872d7bb67a"), null, new DateTimeOffset(new DateTime(2024, 7, 12, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5352), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 30 Description", "[\"image32.jpg\",\"image33.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 30", 38500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("19abcf3a-d7bc-4c7c-b344-91f771a49baa"), null, new DateTimeOffset(new DateTime(2024, 7, 20, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5525), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 38 Description", "[\"image40.jpg\",\"image41.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 38", 42500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("1ec8633e-7f6d-41ce-9aaf-413e004decc8"), null, new DateTimeOffset(new DateTime(2024, 7, 1, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5165), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 19 Description", "[\"image21.jpg\",\"image22.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 19", 33000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("21717e3f-f1a9-4f65-9f4b-699a2a62fff1"), null, new DateTimeOffset(new DateTime(2024, 7, 16, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5436), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 34 Description", "[\"image36.jpg\",\"image37.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 34", 40500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("23eacf1b-d531-4d9a-9035-21cc6b5e3dba"), null, new DateTimeOffset(new DateTime(2024, 7, 9, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5303), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 27 Description", "[\"image29.jpg\",\"image30.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 27", 37000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("27fe8003-39c9-4a83-9b15-a8a5eadf6b07"), null, new DateTimeOffset(new DateTime(2024, 7, 26, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5612), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 44 Description", "[\"image46.jpg\",\"image47.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 44", 45500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("2c8ad85e-4ca8-487b-8942-460c0210482a"), null, new DateTimeOffset(new DateTime(2024, 7, 10, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5318), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 28 Description", "[\"image30.jpg\",\"image31.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 28", 37500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("33f06c29-f6e0-401b-be51-7e200e99093d"), null, new DateTimeOffset(new DateTime(2024, 6, 27, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5108), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 15 Description", "[\"image17.jpg\",\"image18.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 15", 31000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("3a6b7e08-31a2-41e7-8047-db4bdb22591f"), null, new DateTimeOffset(new DateTime(2024, 7, 21, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5541), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 39 Description", "[\"image41.jpg\",\"image42.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 39", 43000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("3b47b0d6-bb14-4863-88a4-4c3d6e434717"), null, new DateTimeOffset(new DateTime(2024, 6, 16, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4910), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 4 Description", "[\"image6.jpg\",\"image7.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 4", 25500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("4a7bbd4e-311c-423a-b931-4e7be0cab32f"), null, new DateTimeOffset(new DateTime(2024, 7, 31, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5686), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 49 Description", "[\"image51.jpg\",\"image52.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 49", 48000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("4b59e1e7-bb1d-412b-a81c-a4a7e18efca2"), null, new DateTimeOffset(new DateTime(2024, 7, 19, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5479), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 37 Description", "[\"image39.jpg\",\"image40.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 37", 42000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("500ae904-a3f1-4fd0-ab74-d3059498c62f"), null, new DateTimeOffset(new DateTime(2024, 7, 5, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5226), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 23 Description", "[\"image25.jpg\",\"image26.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 23", 35000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("50277360-7e60-49d7-8846-ad9d7ca75ccf"), null, new DateTimeOffset(new DateTime(2024, 8, 3, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5731), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 52 Description", "[\"image54.jpg\",\"image55.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 52", 49500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("653848a0-d433-42dd-b885-ffd81be26f5c"), null, new DateTimeOffset(new DateTime(2024, 6, 30, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5151), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 18 Description", "[\"image20.jpg\",\"image21.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 18", 32500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("65911414-6b6b-439d-9bc1-98f2d869d593"), null, new DateTimeOffset(new DateTime(2024, 6, 28, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5121), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 16 Description", "[\"image18.jpg\",\"image19.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 16", 31500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("67e2440d-1be2-4da9-af12-1d59d5ecd0da"), null, new DateTimeOffset(new DateTime(2024, 7, 11, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5332), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 29 Description", "[\"image31.jpg\",\"image32.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 29", 38000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("6ca73b4a-30b4-4fc2-8c04-46de022df0c4"), null, new DateTimeOffset(new DateTime(2024, 7, 4, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5212), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 22 Description", "[\"image24.jpg\",\"image25.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 22", 34500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("6ee2af1b-10cd-4f60-ad01-707a1e5e39c2"), null, new DateTimeOffset(new DateTime(2024, 6, 21, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5017), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 9 Description", "[\"image11.jpg\",\"image12.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 9", 28000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("73776094-22b2-4db1-97a7-ae82af70958a"), null, new DateTimeOffset(new DateTime(2024, 6, 25, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5081), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 13 Description", "[\"image15.jpg\",\"image16.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 13", 30000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("750c67bb-c55f-4cf6-a6db-03f8af014e57"), null, new DateTimeOffset(new DateTime(2024, 8, 1, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 50 Description", "[\"image52.jpg\",\"image53.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 50", 48500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("7b7c8bdf-899a-4a96-ad24-013e2d1962a4"), null, new DateTimeOffset(new DateTime(2024, 7, 6, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5240), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 24 Description", "[\"image26.jpg\",\"image27.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 24", 35500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("8488c839-c2d9-4dc7-82a2-0d461c1adeb9"), null, new DateTimeOffset(new DateTime(2024, 6, 29, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5136), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 17 Description", "[\"image19.jpg\",\"image20.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 17", 32000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("88531b75-7ef0-4c80-bc30-9c1d7b17e714"), null, new DateTimeOffset(new DateTime(2024, 7, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5365), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 31 Description", "[\"image33.jpg\",\"image34.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 31", 39000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("8b49afd3-96a0-4e50-aa18-73fa1920db0e"), null, new DateTimeOffset(new DateTime(2024, 7, 28, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5642), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 46 Description", "[\"image48.jpg\",\"image49.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 46", 46500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("93791c2a-9e1b-4fa2-b09c-c47c83658634"), null, new DateTimeOffset(new DateTime(2024, 7, 30, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5670), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 48 Description", "[\"image50.jpg\",\"image51.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 48", 47500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("94880185-0edb-441a-8083-cbc898ea7f49"), null, new DateTimeOffset(new DateTime(2024, 6, 15, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4838), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 3 Description", "[\"image5.jpg\",\"image6.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 3", 25000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("976faa1e-8fe2-4a48-81e6-c2570389edee"), null, new DateTimeOffset(new DateTime(2024, 7, 3, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5198), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 21 Description", "[\"image23.jpg\",\"image24.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 21", 34000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("9ac31b67-368f-410c-a384-4e99d9b8ff5b"), null, new DateTimeOffset(new DateTime(2024, 7, 7, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5255), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 25 Description", "[\"image27.jpg\",\"image28.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 25", 36000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("9f14b403-beff-4688-9b48-140f5cff9c11"), null, new DateTimeOffset(new DateTime(2024, 7, 25, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5598), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 43 Description", "[\"image45.jpg\",\"image46.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 43", 45000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("a38f9981-9ef9-4c7b-b7ff-685e77822d4d"), null, new DateTimeOffset(new DateTime(2024, 6, 19, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4955), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 7 Description", "[\"image9.jpg\",\"image10.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 7", 27000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("a8ec31a1-f542-418a-af35-932966678f91"), null, new DateTimeOffset(new DateTime(2024, 6, 17, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 5 Description", "[\"image7.jpg\",\"image8.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 5", 26000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("aa1b2d61-7971-48d9-8aca-917bf2b1f155"), null, new DateTimeOffset(new DateTime(2024, 6, 24, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5066), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 12 Description", "[\"image14.jpg\",\"image15.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 12", 29500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("b3d192a6-cc43-4475-82f0-24b803196a86"), null, new DateTimeOffset(new DateTime(2024, 6, 22, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5032), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 10 Description", "[\"image12.jpg\",\"image13.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 10", 28500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("b6b95b2a-a583-4557-be8f-dc00fba512c0"), null, new DateTimeOffset(new DateTime(2024, 7, 17, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5451), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 35 Description", "[\"image37.jpg\",\"image38.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 35", 41000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("b7356432-7fad-48e0-a097-ad4de95472ea"), null, new DateTimeOffset(new DateTime(2024, 7, 27, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5625), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 45 Description", "[\"image47.jpg\",\"image48.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 45", 46000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("d545a0fd-ca08-4e1e-bf2f-3e8f412d5955"), null, new DateTimeOffset(new DateTime(2024, 7, 22, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5555), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 40 Description", "[\"image42.jpg\",\"image43.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 40", 43500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("d5f45bc0-4f43-48ce-9bbb-bc86e26b0373"), null, new DateTimeOffset(new DateTime(2024, 7, 14, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5406), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 32 Description", "[\"image34.jpg\",\"image35.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 32", 39500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("d705d336-745a-4444-89b0-11ca4a79d7ca"), null, new DateTimeOffset(new DateTime(2024, 7, 18, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5465), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 36 Description", "[\"image38.jpg\",\"image39.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 36", 41500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("d9cd8539-e15f-414e-ba0e-230a37d758e3"), null, new DateTimeOffset(new DateTime(2024, 7, 24, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5584), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 42 Description", "[\"image44.jpg\",\"image45.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 42", 44500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("db904ad3-02e7-444b-8595-9305638894ec"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4805), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Ngon", "[\"image3.jpg\",\"image4.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Kẹo ChupaChup", 20000m, new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 3 },
                    { new Guid("e0a0cfbb-2694-408b-99f0-a43a2951d66b"), null, new DateTimeOffset(new DateTime(2024, 6, 20, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4997), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 8 Description", "[\"image10.jpg\",\"image11.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 8", 27500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), null, new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4791), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Ngon", "[\"image1.jpg\",\"image2.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Bánh Oreon", 20000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("f3d13eb9-496c-43ec-9521-8ad22c91f35d"), null, new DateTimeOffset(new DateTime(2024, 7, 23, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5571), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 41 Description", "[\"image43.jpg\",\"image44.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 41", 44000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("f4faa25a-e0f1-463f-85bc-73a45e5e1373"), null, new DateTimeOffset(new DateTime(2024, 6, 23, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5047), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 11 Description", "[\"image13.jpg\",\"image14.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 11", 29000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("f6a8a4c8-5634-45ac-87e6-dadfadbd1c23"), null, new DateTimeOffset(new DateTime(2024, 7, 2, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5179), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 20 Description", "[\"image22.jpg\",\"image23.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 20", 33500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("f903412a-1e6f-44f7-9483-33811b4361a3"), null, new DateTimeOffset(new DateTime(2024, 6, 18, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(4941), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 6 Description", "[\"image8.jpg\",\"image9.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 6", 26500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("fdb0bfa0-949c-4c86-aeca-70b62e80f40e"), null, new DateTimeOffset(new DateTime(2024, 7, 8, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5268), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 26 Description", "[\"image28.jpg\",\"image29.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 26", 36500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 },
                    { new Guid("fde029f3-da10-4ea2-937e-ad4e34fea039"), null, new DateTimeOffset(new DateTime(2024, 8, 2, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5715), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 51 Description", "[\"image53.jpg\",\"image54.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 51", 49000m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 1 },
                    { new Guid("fdf611cd-4525-41d8-8e60-c4f258657e5a"), null, new DateTimeOffset(new DateTime(2024, 6, 26, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5095), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 14 Description", "[\"image16.jpg\",\"image17.jpg\"]", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Product 14", 30500m, new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"), 0, new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), 2 }
                });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "ID", "BillID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Status" },
                values: new object[] { new Guid("f57aa497-3634-409c-82c8-66b7c4e6cbda"), new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5862), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1 });

            migrationBuilder.InsertData(
                table: "CartDetail",
                columns: new[] { "Id", "CartID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "ProductID", "Status", "TotalMoney" },
                values: new object[] { new Guid("13592e0b-9e7a-4042-831a-b679590bd4b1"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5746), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1, 60000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Shipfee", "Status" },
                values: new object[] { new Guid("cc1bcd64-8043-4937-943d-ec909f679a98"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 13, 1, 11, 11, 932, DateTimeKind.Unspecified).AddTicks(5779), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 0m, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CreatedBy",
                table: "Bill",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_BillID",
                table: "BillDetail",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_BillDetail_ProductID",
                table: "BillDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CreatedBy",
                table: "Cart",
                column: "CreatedBy",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_CartDetail_CartID",
                table: "CartDetail",
                column: "CartID");

            migrationBuilder.CreateIndex(
                name: "IX_CartDetail_ProductID",
                table: "CartDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Feedbacks_OrderDetailID",
                table: "Feedbacks",
                column: "OrderDetailID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_CreatedBy",
                table: "OrderDetail",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductID",
                table: "OrderDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_PayHistory_BillID",
                table: "PayHistory",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_PayHistory_PaymentExpressionID",
                table: "PayHistory",
                column: "PaymentExpressionID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductTypeID",
                table: "Product",
                column: "ProductTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ShopId",
                table: "Product",
                column: "ShopId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_CreatedBy",
                table: "RoleUsers",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_RoleId",
                table: "RoleUsers",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Sale_SaleTypeId",
                table: "Sale",
                column: "SaleTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_IdProduct",
                table: "SaleDetails",
                column: "IdProduct");

            migrationBuilder.CreateIndex(
                name: "IX_SaleDetails_IdSale",
                table: "SaleDetails",
                column: "IdSale");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CreatedBy",
                table: "Shops",
                column: "CreatedBy",
                unique: true,
                filter: "[CreatedBy] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Vocher_BillID",
                table: "Vocher",
                column: "BillID");

            migrationBuilder.CreateIndex(
                name: "IX_Vocher_VocherTypeID",
                table: "Vocher",
                column: "VocherTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_VocherDetail_ProductID",
                table: "VocherDetail",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_VocherDetail_VocherID",
                table: "VocherDetail",
                column: "VocherID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropTable(
                name: "BillDetail");

            migrationBuilder.DropTable(
                name: "CartDetail");

            migrationBuilder.DropTable(
                name: "Examples");

            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "PayHistory");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropTable(
                name: "SaleDetails");

            migrationBuilder.DropTable(
                name: "VocherDetail");

            migrationBuilder.DropTable(
                name: "Cart");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "PaymentExpressions:");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Vocher");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SaleType");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "VocherType");

            migrationBuilder.DropTable(
                name: "ProductType");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
