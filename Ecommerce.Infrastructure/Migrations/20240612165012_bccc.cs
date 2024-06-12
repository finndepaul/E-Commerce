using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class bccc : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "ID",
                keyValue: new Guid("7c9f2d40-47a2-4288-8aaa-221643bcc73d"));

            migrationBuilder.DeleteData(
                table: "CartDetail",
                keyColumn: "Id",
                keyValue: new Guid("59eabe9f-36c0-4090-b5f5-3b7c50efa8b1"));

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "ID",
                keyValue: new Guid("a6a0d472-c697-49c2-889a-269bf0869c27"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("0357240f-8d2b-4e34-b6eb-ee8bdeb0cbaf"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("3ab9700f-3961-4863-9ba5-0d8ed737f567"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("51d51156-ba95-40d1-8406-6b5837ba54ec"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("b54e36e9-d351-44b8-a562-6d7451f9ca07"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("c066a016-1db7-4bc8-816f-b1a3cb2525c6"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("ed1b1217-f426-4878-bc1e-ddc9ae8d8bb3"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("f5d1ae7c-1abf-4ab5-8ae5-1940781da41a"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("fc952857-3328-45ea-95e5-003e6cf634a1"));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"),
                columns: new[] { "CreatedTime", "SoldDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7143), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2024, 6, 12, 16, 50, 12, 60, DateTimeKind.Utc).AddTicks(7141) });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "ID", "BillID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Status" },
                values: new object[] { new Guid("c1cc5426-bab6-4046-bf31-88b7f1493101"), new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7161), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1 });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6989), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "CartDetail",
                columns: new[] { "Id", "CartID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "ProductID", "Status", "TotalMoney" },
                values: new object[] { new Guid("b8ae3e66-45d6-45b9-a094-8612591f953a"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7077), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1, 60000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Shipfee", "Status" },
                values: new object[] { new Guid("b481365b-7cc0-4ad7-ae30-de37fc832627"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7100), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7053), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7043), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7014), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(7021), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6262), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6310), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6308), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("0f994cdf-e982-4881-80b2-ab9e40a703dc"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6810), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("32a4d478-c396-4241-8820-99d258cb79ca"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6824), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("6c0a9a93-faa8-4abb-bc44-754378ae82f4"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6797), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("7a0b07ea-6c66-4058-bd95-edfd8259595b"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6814), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("7db0757d-cdca-4d05-b8c7-60b03f862a7b"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6807), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("a5686d6d-2ee1-4392-90c2-cc513714c676"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6827), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("a5a84b19-9fc4-4a35-a76e-7b93b270e643"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6801), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("dda6578a-eb8e-449e-8a84-2189a0091cbd"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6804), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 16, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6866), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("0be0ee12-f390-49c0-a775-df1933663b96"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6624), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("11b670d6-167a-42d4-be32-85cc970a218d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6665), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6723), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("73fea99f-048e-44bf-8c3c-984f705530db"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6644), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6707), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e589e999-152a-44a1-bb74-48883a4d302e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6360), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 23, 50, 12, 60, DateTimeKind.Unspecified).AddTicks(6736), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "ID",
                keyValue: new Guid("c1cc5426-bab6-4046-bf31-88b7f1493101"));

            migrationBuilder.DeleteData(
                table: "CartDetail",
                keyColumn: "Id",
                keyValue: new Guid("b8ae3e66-45d6-45b9-a094-8612591f953a"));

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "ID",
                keyValue: new Guid("b481365b-7cc0-4ad7-ae30-de37fc832627"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("0f994cdf-e982-4881-80b2-ab9e40a703dc"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("32a4d478-c396-4241-8820-99d258cb79ca"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("6c0a9a93-faa8-4abb-bc44-754378ae82f4"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("7a0b07ea-6c66-4058-bd95-edfd8259595b"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("7db0757d-cdca-4d05-b8c7-60b03f862a7b"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5686d6d-2ee1-4392-90c2-cc513714c676"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("a5a84b19-9fc4-4a35-a76e-7b93b270e643"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("dda6578a-eb8e-449e-8a84-2189a0091cbd"));

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"),
                columns: new[] { "CreatedTime", "SoldDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9784), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2024, 6, 12, 10, 35, 46, 114, DateTimeKind.Utc).AddTicks(9783) });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "ID", "BillID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Status" },
                values: new object[] { new Guid("7c9f2d40-47a2-4288-8aaa-221643bcc73d"), new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9803), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1 });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9607), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "CartDetail",
                columns: new[] { "Id", "CartID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "ProductID", "Status", "TotalMoney" },
                values: new object[] { new Guid("59eabe9f-36c0-4090-b5f5-3b7c50efa8b1"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9709), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1, 60000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Shipfee", "Status" },
                values: new object[] { new Guid("a6a0d472-c697-49c2-889a-269bf0869c27"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9735), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9686), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9671), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9639), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9642), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(8868), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(8906), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(8904), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("0357240f-8d2b-4e34-b6eb-ee8bdeb0cbaf"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9420), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("3ab9700f-3961-4863-9ba5-0d8ed737f567"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9427), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("51d51156-ba95-40d1-8406-6b5837ba54ec"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9437), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("b54e36e9-d351-44b8-a562-6d7451f9ca07"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9424), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("c066a016-1db7-4bc8-816f-b1a3cb2525c6"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9449), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("ed1b1217-f426-4878-bc1e-ddc9ae8d8bb3"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9434), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("f5d1ae7c-1abf-4ab5-8ae5-1940781da41a"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9414), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("fc952857-3328-45ea-95e5-003e6cf634a1"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9430), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9480), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("0be0ee12-f390-49c0-a775-df1933663b96"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9229), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("11b670d6-167a-42d4-be32-85cc970a218d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9273), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9334), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("73fea99f-048e-44bf-8c3c-984f705530db"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9251), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9317), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e589e999-152a-44a1-bb74-48883a4d302e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 17, 35, 46, 114, DateTimeKind.Unspecified).AddTicks(9348), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
