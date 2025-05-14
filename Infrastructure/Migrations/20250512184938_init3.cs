using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsImage",
                table: "UploadFile",
                type: "bit",
                nullable: false,
                defaultValue: false);

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
                columns: new[] { "CreatedAt", "IsImage", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2754), false, new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2755) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsImage", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2759), false, new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2760) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsImage", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2762), false, new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2763) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "IsImage", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2766), false, new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "UploadFile",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "IsImage", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2769), false, new DateTime(2025, 5, 13, 1, 49, 38, 118, DateTimeKind.Local).AddTicks(2770) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsImage",
                table: "UploadFile");

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
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5884), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5885) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5887), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5888) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5890), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5893), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5893) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5927), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5928) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5930), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5930) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5932), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5933) });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5935), new DateTime(2025, 5, 13, 0, 39, 48, 336, DateTimeKind.Local).AddTicks(5935) });

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
    }
}
