using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Size",
                table: "UploadFile",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3580), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3581) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3584), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3584) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3586), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3587) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3589), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3590) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3593), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3593) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3270), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3270) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3272), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3273) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3275), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3275) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3277), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3277) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3279), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3280) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3404), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3405) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3408), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3409) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3412), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3412) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3415), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3415) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3418), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3419) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3421), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3422) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3425), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3426) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3428), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3429) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3024), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3038) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3040), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3040) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3306), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3306) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3308), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3309) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3310), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3311) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3312), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3313) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3314), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3315) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3317), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3318) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3319), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3320) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3530), 0, new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3531) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3536), 0, new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3537) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3540), 0, new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3541) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3545), 0, new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3545) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Size", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3549), 0, new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3549) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3222), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3223) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3226), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3227) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3229), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3229) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3231), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3232) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3234), new DateTime(2025, 5, 13, 3, 28, 9, 230, DateTimeKind.Local).AddTicks(3235) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Size",
                table: "UploadFile");

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2800), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2801) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2803), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2803) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2805), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2806) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2808), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2809) });

            migrationBuilder.UpdateData(
                table: "Author",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2810), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2811) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2491), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2491) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2494), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2494) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2496), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2496) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2498), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2500), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2629), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2629) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2633), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2633) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2636), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2636) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2640), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2640) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2643), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2643) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2646), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2649), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2649) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2652), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2652) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2199), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2216) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2218), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2219) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2527), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2528) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2529), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2531), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2532) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2584), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2584) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2586), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2587) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2589), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2589) });

            migrationBuilder.UpdateData(
                table: "Tag",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2590), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2591) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2754), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2759), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2762), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2766), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2769), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2770) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2441), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2442) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2444), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2445) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2446), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2447) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2450), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2450) });

            migrationBuilder.UpdateData(
                table: "User",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2452), new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2452) });
        }
    }
}
