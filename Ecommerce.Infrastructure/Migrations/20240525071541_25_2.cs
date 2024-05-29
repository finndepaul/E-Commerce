using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class _25_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "ConfirmCode",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTimeOffset>(
                name: "SentTime",
                table: "User",
                type: "datetimeoffset",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1904), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1891), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1850), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1861), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1167), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1211), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "ConfirmCode", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "ModifiedBy", "ModifiedTime", "Password", "PhoneNumber", "RoleID", "SentTime", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("3d4e409a-b97c-4d01-b031-064df0bfacd4"), null, null, new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1656), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Nguyen Van Trong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1, "Trongnv" },
                    { new Guid("589328ba-f60c-4fcc-bf67-011b218a288d"), null, null, new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1708), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dongbdph35416@fpt.edu.vn", "Bui Duy Dong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1, "Dong" },
                    { new Guid("7a03c727-f03d-403f-894a-31ce4cf6a80c"), null, null, new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1684), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "thendph35306@fpt.edu.vn", "Nguyen Dinh The", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1, "THEDZ" },
                    { new Guid("99a149ae-a9e0-4c9d-a0df-47fc6198d54f"), null, null, new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1756), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "hoangpkph38105@fpt.edu.vn", "Hoang", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1, "Hoang" },
                    { new Guid("e338ff0c-54f2-4099-ba6d-98d3ae664993"), null, null, new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1354), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan309@gmail.com", "DangsNguyen", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1, "Dangs" },
                    { new Guid("e86eb78e-a41d-4825-9874-a6e90b611277"), null, null, new DateTimeOffset(new DateTime(2024, 5, 25, 14, 15, 41, 26, DateTimeKind.Unspecified).AddTicks(1732), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "phongdxph35748@fpt.edu.vn", "Xuan Phong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), null, 1, "Phong" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("3d4e409a-b97c-4d01-b031-064df0bfacd4"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("589328ba-f60c-4fcc-bf67-011b218a288d"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("7a03c727-f03d-403f-894a-31ce4cf6a80c"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("99a149ae-a9e0-4c9d-a0df-47fc6198d54f"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e338ff0c-54f2-4099-ba6d-98d3ae664993"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("e86eb78e-a41d-4825-9874-a6e90b611277"));

            migrationBuilder.DropColumn(
                name: "ConfirmCode",
                table: "User");

            migrationBuilder.DropColumn(
                name: "SentTime",
                table: "User");

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
        }
    }
}
