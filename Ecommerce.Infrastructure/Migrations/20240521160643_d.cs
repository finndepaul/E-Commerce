using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class d : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_User_UserID",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserID",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_User_UserID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_UserID",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Cart_UserID",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Bill_UserID",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("5ffb22ad-084f-4c43-ba0c-093ee998b4f7"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("67d2f910-0201-4bfd-beb7-b79e5bf36456"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("7e21916f-4408-4542-85a9-187df2eef266"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("8df1b5e3-4a33-4090-b4e9-4fb2ac736555"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("9b190348-628e-4299-8f33-3b0a6173a3bf"));

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "ID",
                keyValue: new Guid("d6f842ef-5478-41c4-9c90-14551a03b5e3"));

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "OrderDetails");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Address");

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Cart",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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
                name: "IX_OrderDetails_CreatedBy",
                table: "OrderDetails",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CreatedBy",
                table: "Cart",
                column: "CreatedBy",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bill_CreatedBy",
                table: "Bill",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_CreatedBy",
                table: "Address",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_User_CreatedBy",
                table: "Bill",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_CreatedBy",
                table: "Cart",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_User_CreatedBy",
                table: "OrderDetails",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_CreatedBy",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_User_CreatedBy",
                table: "Bill");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_CreatedBy",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_User_CreatedBy",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_OrderDetails_CreatedBy",
                table: "OrderDetails");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CreatedBy",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Bill_CreatedBy",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Address_CreatedBy",
                table: "Address");

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

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "OrderDetails",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                table: "Cart",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Cart",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserID",
                table: "Bill",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Address",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("db904ad3-02e7-444b-8595-9305638894ec"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8952), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ID",
                keyValue: new Guid("e5512865-9aab-437e-a28d-db8db44c6ea1"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8932), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("4f352b67-98ad-4557-9315-dea5a8fe1c15"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8874), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "ProductType",
                keyColumn: "ID",
                keyValue: new Guid("e701de07-7b1e-4d47-88fc-fa9ddf9457d9"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8883), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8159), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "ID",
                keyValue: new Guid("ba820c64-1a81-4c44-80ea-47038c930c3b"),
                column: "CreatedTime",
                value: new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8208), new TimeSpan(0, 7, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "ID", "CreatedBy", "CreatedTime", "Deleted", "DeletedBy", "DeletedTime", "Email", "FullName", "ModifiedBy", "ModifiedTime", "Password", "PhoneNumber", "RoleID", "Status", "Username" },
                values: new object[,]
                {
                    { new Guid("5ffb22ad-084f-4c43-ba0c-093ee998b4f7"), null, new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8780), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Hoang", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Hoang" },
                    { new Guid("67d2f910-0201-4bfd-beb7-b79e5bf36456"), null, new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8735), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "dongbdph35416@fpt.edu.vn", "Bui Duy Dong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Dong" },
                    { new Guid("7e21916f-4408-4542-85a9-187df2eef266"), null, new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8714), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Nguyen Dinh The", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "THEDZ" },
                    { new Guid("8df1b5e3-4a33-4090-b4e9-4fb2ac736555"), null, new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8296), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "azusachan309@gmail.com", "DangsNguyen", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Dangs" },
                    { new Guid("9b190348-628e-4299-8f33-3b0a6173a3bf"), null, new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8688), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Nguyen Van Trong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Trongnv" },
                    { new Guid("d6f842ef-5478-41c4-9c90-14551a03b5e3"), null, new DateTimeOffset(new DateTime(2024, 5, 14, 17, 4, 54, 970, DateTimeKind.Unspecified).AddTicks(8752), new TimeSpan(0, 7, 0, 0, 0)), false, null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "trongnvph35790@fpt.edu.vn", "Xuan Phong", null, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), "LK25tQh1RqkKbrq4C2l6fw==", "0123456789", new Guid("25d7afcb-949b-4717-a961-b50f2e18657d"), 1, "Phong" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_UserID",
                table: "OrderDetails",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_UserID",
                table: "Cart",
                column: "UserID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserID",
                table: "Bill",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_User_UserID",
                table: "Bill",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserID",
                table: "Cart",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_User_UserID",
                table: "OrderDetails",
                column: "UserID",
                principalTable: "User",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
