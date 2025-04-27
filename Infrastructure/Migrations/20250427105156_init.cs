using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ManagerId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    View = table.Column<int>(type: "int", nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_User_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductTag",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTag", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTag_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTag_Tag_TagId",
                        column: x => x.TagId,
                        principalTable: "Tag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UploadFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FileName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Data = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    ContentType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UploadFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UploadFile_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "AI", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2176), "Artificial Intelligence", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2176) },
                    { 2, "Blockchain", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2178), "Blockchain tech", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2178) },
                    { 3, "Cloud", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2180), "Cloud computing", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2180) },
                    { 4, "IoT", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2181), "Internet of Things", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2182) },
                    { 5, "Cybersecurity", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2183), "Security", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2183) }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2000), "Admin", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2013) },
                    { 2, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2014), "Contributor", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2015) }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2206), "Machine Learning", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2206) },
                    { 2, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2208), "NFT", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2208) },
                    { 3, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2209), "AWS", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2210) },
                    { 4, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2211), "Smart Home", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2211) },
                    { 5, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2212), "Data Protection", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2213) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "RoleId", "Status", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2144), "admin1@example.com", "hashed_pwd", 1, 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2145), "admin1" },
                    { 2, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2147), "user1@example.com", "hashed_pwd", 2, 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2147), "contributor1" },
                    { 3, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2149), "user2@example.com", "hashed_pwd", 2, 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2149), "contributor2" },
                    { 4, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2150), "user3@example.com", "hashed_pwd", 2, 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2151), "contributor3" },
                    { 5, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2152), "user4@example.com", "hashed_pwd", 2, 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2153), "contributor4" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Image", "Level", "ManagerId", "RejectReason", "Status", "Title", "UpdatedAt", "View" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2235), "AI chatbot", "", "Advanced", 1, "Incomplete features", "Approved", "AI Assistant", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2236), 100 },
                    { 2, 2, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2270), "Crypto wallet", "", "Intermediate", 2, "Incomplete features", "Pending", "Blockchain Wallet", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2271), 50 },
                    { 3, 3, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2273), "Secure cloud", "", "Basic", 3, "Incomplete features", "Approved", "Cloud Storage", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2273), 75 },
                    { 4, 4, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2275), "Smart sensors", "", "Advanced", 4, "Incomplete features", "Rejected", "Smart IoT Sensor", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2276), 30 },
                    { 5, 5, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2277), "Security app", "", "Intermediate", 5, "Incomplete features", "Approved", "Cyber Shield", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2278), 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductTag",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 4 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "UploadFile",
                columns: new[] { "Id", "ContentType", "CreatedAt", "Data", "FileName", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "application/pdf", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2321), new byte[0], "ai_doc.pdf", 1, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2322) },
                    { 2, "application/pdf", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2323), new byte[0], "wallet_doc.pdf", 2, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2324) },
                    { 3, "application/pdf", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2325), new byte[0], "cloud_doc.pdf", 3, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2326) },
                    { 4, "application/pdf", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2327), new byte[0], "iot_doc.pdf", 4, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2327) },
                    { 5, "application/pdf", new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2329), new byte[0], "cyber_doc.pdf", 5, new DateTime(2025, 4, 27, 17, 51, 55, 389, DateTimeKind.Local).AddTicks(2329) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ManagerId",
                table: "Product",
                column: "ManagerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductTag_TagId",
                table: "ProductTag",
                column: "TagId");

            migrationBuilder.CreateIndex(
                name: "IX_UploadFile_ProductId",
                table: "UploadFile",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTag");

            migrationBuilder.DropTable(
                name: "UploadFile");

            migrationBuilder.DropTable(
                name: "Tag");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
