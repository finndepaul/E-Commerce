using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class u : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleID",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleID",
                table: "User");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("69349e97-5ae7-4a1b-99c5-5a95626e01a4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("788351d7-7332-4fb2-a9ed-4672cd5414fe"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("855652eb-1866-4b7d-be81-77d1a0d9fd9f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("97fe4b79-5001-495a-ad9b-6aa6e90698bd"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("c682e375-071f-43e5-a588-13906140fbce"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("d31e7cf7-61a3-4b07-8600-6c54b7c0fe87"));

            migrationBuilder.DropColumn(
                name: "RoleID",
                table: "User");

            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Product",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "ShopId",
                table: "Bill",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                columns: new[] { "CreatedTime", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(6322), new TimeSpan(0, 7, 0, 0, 0)), new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a") });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                columns: new[] { "CreatedTime", "ShopId" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(6306), new TimeSpan(0, 7, 0, 0, 0)), new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a") });

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(6246), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(6251), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5070), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5147), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleName", "Status" },
                values: new object[] { new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5150), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "Shop", 1 });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "ModifiedBy", "ModifiedTime", "Password", "PhoneNumber", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5672), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Nguyen Van Trong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "Trongnv" },
                    { new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5721), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dongbdph35416@fpt.edu.vn", "Bui Duy Dong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "Dong" },
                    { new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5778), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hoangpkph38105@fpt.edu.vn", "Hoang", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "Hoang" },
                    { new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5699), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "thendph35306@fpt.edu.vn", "Nguyen Dinh The", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "THEDZ" },
                    { new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5736), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "phongdxph35748@fpt.edu.vn", "Xuan Phong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "Phong" },
                    { new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan309@gmail.com", "DangsNguyen", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "Dangs" },
                    { new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), null, new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5797), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan307@gmail.com", "Client Test", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", 1, "client" }
                });

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "UserAddress" },
                values: new object[,]
                {
                    { new Guid("1b416866-73df-46e2-a274-075cfa526560"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "345 Streat" },
                    { new Guid("1f966035-6626-4beb-91dc-95531b319a21"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "123 Streat" }
                });

            migrationBuilder.InsertData(
                table: "Cart",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status" },
                values: new object[] { new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(6149), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("09b60e60-1e29-4ff9-955c-11d451b96a6f"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5958), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("0d2adba0-11c9-4579-83e3-572368fbaf18"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5964), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("4dda3b63-e9cd-462d-8fbc-557c81fd44e9"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5971), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("7c333057-b2bf-467f-a5cc-3d0a3b1a4cae"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5967), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("9244ab0f-b160-4263-86a1-8bd4576b5ee3"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5974), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b6a87aeb-1615-4ec7-8d21-73759193b9af"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5977), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("c66f0176-3811-4cd7-a976-4e2ea083a5dc"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5952), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("f1f42e77-e26f-4e31-801c-a634118c6fe7"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 5, 29, 12, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(5961), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "ShopAddress", "ShopEmail", "ShopImages", "ShopName", "ShopPhone" },
                values: new object[] { new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 5, 29, 5, 29, 20, 541, DateTimeKind.Unspecified).AddTicks(6018), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "123 Street", "azusachan307@gmail.com", "avtShop1.jpg", "Vinsmart", "0905989504" });

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
                name: "IX_Shops_CreatedBy",
                table: "Shops",
                column: "CreatedBy",
                unique: true,
                filter: "[CreatedBy] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Shops_ShopId",
                table: "Product",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "ShopId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Shops_ShopId",
                table: "Product");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropIndex(
                name: "IX_Product_ShopId",
                table: "Product");

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("1b416866-73df-46e2-a274-075cfa526560"));

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("1f966035-6626-4beb-91dc-95531b319a21"));

            migrationBuilder.DeleteData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"));

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("0be0ee12-f390-49c0-a775-df1933663b96"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("11b670d6-167a-42d4-be32-85cc970a218d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("73fea99f-048e-44bf-8c3c-984f705530db"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e589e999-152a-44a1-bb74-48883a4d302e"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"));

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ShopId",
                table: "Bill");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleID",
                table: "User",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2193), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2184), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2155), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2160), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(1572), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(1616), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "ModifiedBy", "ModifiedTime", "Password", "PhoneNumber", "RoleID", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("69349e97-5ae7-4a1b-99c5-5a95626e01a4"), null, new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2073), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "phongdxph35748@fpt.edu.vn", "Xuan Phong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Phong" },
                    { new Guid("788351d7-7332-4fb2-a9ed-4672cd5414fe"), null, new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2091), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hoangpkph38105@fpt.edu.vn", "Hoang", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Hoang" },
                    { new Guid("855652eb-1866-4b7d-be81-77d1a0d9fd9f"), null, new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2050), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dongbdph35416@fpt.edu.vn", "Bui Duy Dong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Dong" },
                    { new Guid("97fe4b79-5001-495a-ad9b-6aa6e90698bd"), null, new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(1688), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan309@gmail.com", "DangsNguyen", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Dangs" },
                    { new Guid("c682e375-071f-43e5-a588-13906140fbce"), null, new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2010), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Nguyen Van Trong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Trongnv" },
                    { new Guid("d31e7cf7-61a3-4b07-8600-6c54b7c0fe87"), null, new DateTimeOffset(new DateTime(2024, 5, 21, 23, 6, 43, 340, DateTimeKind.Unspecified).AddTicks(2032), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "thendph35306@fpt.edu.vn", "Nguyen Dinh The", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "THEDZ" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleID",
                table: "User",
                column: "RoleID");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleID",
                table: "User",
                column: "RoleID",
                principalTable: "Role",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
