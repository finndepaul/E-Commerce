using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _12_6_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "ID",
                keyValue: new Guid("5a1c3484-22c1-4941-b3f4-b013169c35f3"));

            migrationBuilder.DeleteData(
                table: "CartDetail",
                keyColumn: "Id",
                keyValue: new Guid("8c153249-4322-4e6e-893b-c0fc6697a86b"));

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "ID",
                keyValue: new Guid("1d16be42-c7d3-405e-8ee1-90b77dc47a7d"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("009a4515-6db8-45aa-9c16-dffebdeeadc5"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("197b8888-4d23-4f22-aa7f-c06eedff1614"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("2c05c074-0beb-447d-803a-33628dc930db"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("a240f3b4-d798-4b24-b9cd-8628275d0149"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("be5c2b81-18c2-4efc-b0f2-8f5fd7283df0"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("c324581d-50f1-472f-b394-cee82ba3018c"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("ec6e642f-5a58-4ac8-accc-0f8c69a62670"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("f139f803-3ff4-48dc-abd3-a31380a6c54e"));

            migrationBuilder.AlterColumn<string>(
                name: "WardCode",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"),
                columns: new[] { "CreatedTime", "SoldDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7933), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2024, 6, 12, 4, 31, 14, 386, DateTimeKind.Utc).AddTicks(7930) });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "ID", "BillID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Status" },
                values: new object[] { new Guid("e4191448-e337-4151-bf06-d8a03e777f39"), new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7976), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1 });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7611), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "CartDetail",
                columns: new[] { "Id", "CartID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "ProductID", "Status", "TotalMoney" },
                values: new object[] { new Guid("acb349ec-69d3-4507-a98e-d21a4331c692"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7804), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1, 60000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Shipfee", "Status" },
                values: new object[] { new Guid("747f353d-76b8-4b9c-a75d-56d8912bd500"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7850), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7745), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7729), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7666), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7675), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6161), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6206), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("23b37e69-ae24-4c9e-a15f-22cc993a6419"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7283), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("3f105e1d-1294-4a07-a3d7-68b1d8250b08"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7222), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("757d8b46-2e77-4c26-9065-720b7fb60ade"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7248), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("97eafe51-cf8f-4b7d-b66a-ff3716e91473"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7228), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("a666abc6-85be-40ee-9a48-d532221083b5"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7212), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("be9ca460-28cb-4d4a-baba-f345f7680082"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7264), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("e3a97f64-5ca1-4687-8008-add3620f9cc8"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7234), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("f46719ba-69dc-4a33-9f36-ff5a76abded4"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7240), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 4, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7418), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("0be0ee12-f390-49c0-a775-df1933663b96"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6825), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("11b670d6-167a-42d4-be32-85cc970a218d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6930), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7000), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("73fea99f-048e-44bf-8c3c-984f705530db"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6893), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6963), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e589e999-152a-44a1-bb74-48883a4d302e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(6326), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 11, 31, 14, 386, DateTimeKind.Unspecified).AddTicks(7034), new TimeSpan(0, 7, 0, 0, 0)));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "ID",
                keyValue: new Guid("e4191448-e337-4151-bf06-d8a03e777f39"));

            migrationBuilder.DeleteData(
                table: "CartDetail",
                keyColumn: "Id",
                keyValue: new Guid("acb349ec-69d3-4507-a98e-d21a4331c692"));

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "ID",
                keyValue: new Guid("747f353d-76b8-4b9c-a75d-56d8912bd500"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("23b37e69-ae24-4c9e-a15f-22cc993a6419"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("3f105e1d-1294-4a07-a3d7-68b1d8250b08"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("757d8b46-2e77-4c26-9065-720b7fb60ade"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("97eafe51-cf8f-4b7d-b66a-ff3716e91473"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("a666abc6-85be-40ee-9a48-d532221083b5"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("be9ca460-28cb-4d4a-baba-f345f7680082"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("e3a97f64-5ca1-4687-8008-add3620f9cc8"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("f46719ba-69dc-4a33-9f36-ff5a76abded4"));

            migrationBuilder.AlterColumn<int>(
                name: "WardCode",
                table: "Address",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"),
                columns: new[] { "CreatedTime", "SoldDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4740), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2024, 6, 12, 3, 51, 29, 653, DateTimeKind.Utc).AddTicks(4738) });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "ID", "BillID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Status" },
                values: new object[] { new Guid("5a1c3484-22c1-4941-b3f4-b013169c35f3"), new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4763), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1 });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4531), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "CartDetail",
                columns: new[] { "Id", "CartID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "ProductID", "Status", "TotalMoney" },
                values: new object[] { new Guid("8c153249-4322-4e6e-893b-c0fc6697a86b"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4648), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1, 60000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Shipfee", "Status" },
                values: new object[] { new Guid("1d16be42-c7d3-405e-8ee1-90b77dc47a7d"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4681), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4613), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4602), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4566), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4570), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3518), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3565), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3561), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("009a4515-6db8-45aa-9c16-dffebdeeadc5"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4279), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("197b8888-4d23-4f22-aa7f-c06eedff1614"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4312), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("2c05c074-0beb-447d-803a-33628dc930db"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4290), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("a240f3b4-d798-4b24-b9cd-8628275d0149"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4297), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("be5c2b81-18c2-4efc-b0f2-8f5fd7283df0"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4293), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("c324581d-50f1-472f-b394-cee82ba3018c"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4316), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("ec6e642f-5a58-4ac8-accc-0f8c69a62670"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4286), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("f139f803-3ff4-48dc-abd3-a31380a6c54e"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4308), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 3, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4389), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("0be0ee12-f390-49c0-a775-df1933663b96"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3938), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("11b670d6-167a-42d4-be32-85cc970a218d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3990), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4029), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("73fea99f-048e-44bf-8c3c-984f705530db"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3969), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4009), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e589e999-152a-44a1-bb74-48883a4d302e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(3623), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 12, 10, 51, 29, 653, DateTimeKind.Unspecified).AddTicks(4048), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
