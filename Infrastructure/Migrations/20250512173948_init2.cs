using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Content",
                table: "Product",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6084), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6085) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6087), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6087) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6089), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6089) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6091), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6091) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6093), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6093) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5822), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5824), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5826), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5827) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5828), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5828) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5829), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5830) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5884), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5887), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5890), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5893), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5927), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5930), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5932), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Content", "CreatedAt", "UpdatedAt" },
                values: new object[] { "", new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5935) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5637), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5650), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5651) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5851), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5852) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5853), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5853) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5854), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5856), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5856) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5857), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5858) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5859), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5859) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5860), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5861) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6045), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6050), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6050) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6053), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6053) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6056), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6056) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6059), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5791), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5794), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5794) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5796), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5796) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5798), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5798) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5799), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5800) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Content",
                table: "Product");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1943), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1943) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1945), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1946) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1949), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1950) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1951), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1952) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1953), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1954) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1494), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1495) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1498), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1498) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1500), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1500) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1556), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1557) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1559), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1560) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1699), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1699) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1702), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1705), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1706) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1709), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1709) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1712), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1712) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1716), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1717) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1721), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1722) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1120), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1143) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1146), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1611), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1614), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1615) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1616), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1621), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1623), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1625) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1627), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1627) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1629), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1889), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1890) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1893), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1894) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1898), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1898) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1904), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1905) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1907), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1908) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1422), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1424) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1427), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1428) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1430), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1435) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1437), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1437) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1439), new DateTime(2025, 5, 12, 21, 18, 30, 357, DateTimeKind.Local).AddTicks(1441) });
        }
    }
}
