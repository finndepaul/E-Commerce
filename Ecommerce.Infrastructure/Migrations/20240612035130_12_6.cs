using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _12_6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("88af30cd-56ff-456c-93f8-0860862f6794"));

            migrationBuilder.DeleteData(
                table: "Address",
                keyColumn: "Id",
                keyValue: new Guid("ef18eab9-8a2f-4534-9e78-d7b15c54e4dd"));

            migrationBuilder.DeleteData(
                table: "BillDetail",
                keyColumn: "ID",
                keyValue: new Guid("3ae6172f-e434-4f29-9658-db346aedc1d8"));

            migrationBuilder.DeleteData(
                table: "CartDetail",
                keyColumn: "Id",
                keyValue: new Guid("1bb5d466-5681-4693-b1e3-8e0bb36517e9"));

            migrationBuilder.DeleteData(
                table: "OrderDetail",
                keyColumn: "ID",
                keyValue: new Guid("f516d5ee-b690-4655-a71a-96bf904ce5f7"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("0bf86c96-06d3-4017-b8df-9b22ff5c1bd3"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("18f45c41-34de-4c16-b349-f2c741be46be"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("3202f346-bf09-4db6-a836-43441e6baf26"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("5d100053-d396-47e5-abcd-cd86f3ee3f7d"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("773ceb66-04ca-41e5-8072-ac5586bba22f"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("7f0fda77-1d72-4e4a-9dff-25da60fd39fd"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("982dab6f-cc27-4ac9-b31e-bcfcd2fc48e1"));

            migrationBuilder.DeleteData(
                table: "RoleUsers",
                keyColumn: "Id",
                keyValue: new Guid("c048b06c-ba17-48bd-b45f-5f2dafcd6b30"));

            migrationBuilder.DropColumn(
                name: "UserAddress",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "WardCode",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "city",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "district",
                table: "Address",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "WardCode",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "city",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "district",
                table: "Address");

            migrationBuilder.AddColumn<string>(
                name: "UserAddress",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Address",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "Status", "UserAddress" },
                values: new object[,]
                {
                    { new Guid("88af30cd-56ff-456c-93f8-0860862f6794"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "345 Streat" },
                    { new Guid("ef18eab9-8a2f-4534-9e78-d7b15c54e4dd"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1, "123 Streat" }
                });

            migrationBuilder.UpdateData(
                table: "Bill",
                keyColumn: "Id",
                keyValue: new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"),
                columns: new[] { "CreatedTime", "SoldDate" },
                values: new object[] { new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8254), new TimeSpan(0, 7, 0, 0, 0)), new DateTime(2024, 6, 11, 15, 59, 1, 12, DateTimeKind.Utc).AddTicks(8253) });

            migrationBuilder.InsertData(
                table: "BillDetail",
                columns: new[] { "ID", "BillID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Status" },
                values: new object[] { new Guid("3ae6172f-e434-4f29-9658-db346aedc1d8"), new Guid("01fa417d-7900-4199-8ad9-cbb397c14235"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8305), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1 });

            migrationBuilder.UpdateData(
                table: "Cart",
                keyColumn: "Id",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8029), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "CartDetail",
                columns: new[] { "Id", "CartID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "ProductID", "Status", "TotalMoney" },
                values: new object[] { new Guid("1bb5d466-5681-4693-b1e3-8e0bb36517e9"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8171), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 2m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 1, 60000m });

            migrationBuilder.InsertData(
                table: "OrderDetail",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "NumberOfProduct", "Price", "ProductID", "Shipfee", "Status" },
                values: new object[] { new Guid("f516d5ee-b690-4655-a71a-96bf904ce5f7"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8204), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 3, 60000m, new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"), 0m, 0 });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8143), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8132), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8098), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(8101), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7063), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7104), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7101), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "RoleUsers",
                columns: new[] { "Id", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "ModifiedBy", "ModifiedTime", "RoleId", "Status" },
                values: new object[,]
                {
                    { new Guid("0bf86c96-06d3-4017-b8df-9b22ff5c1bd3"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7832), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("56bece24-ba60-4b2b-801c-b68cfc8ccf9d"), 1 },
                    { new Guid("18f45c41-34de-4c16-b349-f2c741be46be"), new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7825), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("3202f346-bf09-4db6-a836-43441e6baf26"), new Guid("11b670d6-167a-42d4-be32-85cc970a218d"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7818), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("5d100053-d396-47e5-abcd-cd86f3ee3f7d"), new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7829), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"), 1 },
                    { new Guid("773ceb66-04ca-41e5-8072-ac5586bba22f"), new Guid("73fea99f-048e-44bf-8c3c-984f705530db"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7810), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("7f0fda77-1d72-4e4a-9dff-25da60fd39fd"), new Guid("e589e999-152a-44a1-bb74-48883a4d302e"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7801), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("982dab6f-cc27-4ac9-b31e-bcfcd2fc48e1"), new Guid("0be0ee12-f390-49c0-a775-df1933663b96"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7806), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 },
                    { new Guid("c048b06c-ba17-48bd-b45f-5f2dafcd6b30"), new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"), new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7821), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1 }
                });

            migrationBuilder.UpdateData(
                table: "Shops",
                keyColumn: "ShopId",
                keyValue: new Guid("30d26f28-6e0a-4ecd-a5fe-0a683fdfa93a"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 15, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7898), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("0be0ee12-f390-49c0-a775-df1933663b96"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7516), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("11b670d6-167a-42d4-be32-85cc970a218d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7554), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3e51f9f1-ae83-4b66-b79f-5eb8f32d2075"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7588), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("73fea99f-048e-44bf-8c3c-984f705530db"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7538), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8e0d06d1-5896-4886-a77e-6e794a212f92"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7569), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e589e999-152a-44a1-bb74-48883a4d302e"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7166), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("ef578dbc-71f7-474f-a6eb-84deb7f15c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 6, 11, 22, 59, 1, 12, DateTimeKind.Unspecified).AddTicks(7725), new TimeSpan(0, 7, 0, 0, 0)));
        }
    }
}
