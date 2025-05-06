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
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AcademicTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvatarUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsStudent = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

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
                    RejectReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Product_User_ManagerId",
                        column: x => x.ManagerId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductAuthor",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductAuthor", x => new { x.ProductId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_ProductAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductAuthor_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
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
                table: "Author",
                columns: new[] { "Id", "AcademicTitle", "AvatarUrl", "CreatedAt", "Degree", "Email", "FullName", "IsStudent", "PhoneNumber", "Position", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "GS", "/images/author1.jpg", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6740), "TS", "nguyenvana@example.com", "Nguyễn Văn A", false, "0901234567", "Giảng viên", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6740) },
                    { 2, "PGS", "/images/author2.jpg", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6742), "ThS", "tranthib@example.com", "Trần Thị B", false, "0902345678", "Giảng viên", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6743) },
                    { 3, "", "/images/author3.jpg", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6744), "CN", "levanc@example.com", "Lê Văn C", true, "0913456789", "Sinh viên", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6745) },
                    { 4, "", "/images/author4.jpg", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6746), "ThS", "phamthid@example.com", "Phạm Thị D", true, "0934567890", "Nghiên cứu sinh", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6747) },
                    { 5, "", "/images/author5.jpg", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6748), "CN", "dovane@example.com", "Đỗ Văn E", true, "0987654321", "Sinh viên", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6749) }
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "Description", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "Khoa học máy tính", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6512), "Lĩnh vực CNTT", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6513) },
                    { 2, "Trí tuệ nhân tạo", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6514), "AI và Machine Learning", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6514) },
                    { 3, "Kỹ thuật phần mềm", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6516), "Thiết kế và phát triển phần mềm", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6516) },
                    { 4, "An toàn thông tin", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6517), "Bảo mật hệ thống", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6517) },
                    { 5, "Hệ thống thông tin", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6518), "Phân tích và quản lý thông tin", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6519) }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "RoleName", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6309), "Admin", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6327) },
                    { 2, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6328), "Manager", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6329) }
                });

            migrationBuilder.InsertData(
                table: "Tag",
                columns: new[] { "Id", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6541), "Trí tuệ nhân tạo", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6542) },
                    { 2, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6545), "Học máy", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6545) },
                    { 3, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6547), "An ninh mạng", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6547) },
                    { 4, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6548), "Cơ sở dữ liệu", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6548) },
                    { 5, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6549), "Phát triển Web", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6550) }
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "CreatedAt", "Email", "Password", "RoleId", "Status", "UpdatedAt", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6478), "admin1@example.com", "admin123", 1, 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6479), "admin01" },
                    { 2, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6481), "manager1@example.com", "manager123", 2, 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6481), "manager01" },
                    { 3, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6483), "admin2@example.com", "admin456", 1, 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6483), "admin02" },
                    { 4, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6484), "manager2@example.com", "manager456", 2, 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6485), "manager02" },
                    { 5, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6486), "admin3@example.com", "admin789", 1, 0, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6486), "admin03" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "Description", "Image", "Level", "ManagerId", "RejectReason", "Status", "Title", "UpdatedAt", "View" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6612), "Ứng dụng quản lý sách, mượn-trả", "library.png", "Đại học", 1, null, "Đã duyệt", "Hệ thống quản lý thư viện", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6613), 100 },
                    { 2, 2, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6615), "Dự án ứng dụng OpenCV và Python", "face_ai.png", "Thạc sĩ", 2, null, "Chờ duyệt", "Nhận diện khuôn mặt bằng AI", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6616), 75 },
                    { 3, 5, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6618), "Thống kê, khai thác dữ liệu truy cập", "analytics.png", "Đại học", 3, "Thiếu dữ liệu thực nghiệm", "Bị từ chối", "Phân tích hành vi người dùng Web", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6618), 30 },
                    { 4, 3, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6620), "Quản lý chứng chỉ học tập minh bạch", "blockchain.png", "Tiến sĩ", 4, null, "Đã duyệt", "Ứng dụng Blockchain trong giáo dục", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6621), 55 },
                    { 5, 4, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6623), "Sử dụng Machine Learning phát hiện tấn công", "ids.png", "Thạc sĩ", 5, null, "Chờ duyệt", "Hệ thống cảnh báo xâm nhập mạng", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6623), 90 }
                });

            migrationBuilder.InsertData(
                table: "ProductAuthor",
                columns: new[] { "AuthorId", "ProductId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 3, 1 },
                    { 2, 2 },
                    { 4, 3 },
                    { 5, 3 },
                    { 1, 4 },
                    { 2, 5 }
                });

            migrationBuilder.InsertData(
                table: "ProductTag",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 4 },
                    { 2, 2 },
                    { 3, 4 },
                    { 3, 5 },
                    { 4, 1 },
                    { 4, 3 },
                    { 5, 2 },
                    { 5, 3 },
                    { 5, 5 }
                });

            migrationBuilder.InsertData(
                table: "UploadFile",
                columns: new[] { "Id", "ContentType", "CreatedAt", "Data", "FileName", "ProductId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "application/pdf", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6698), new byte[] { 1, 2, 3 }, "thu-vien.pdf", 1, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6699) },
                    { 2, "application/vnd.openxmlformats-officedocument.wordprocessingml.document", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6703), new byte[] { 4, 5, 6 }, "ai-project.docx", 2, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6703) },
                    { 3, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6706), new byte[] { 7, 8, 9 }, "phan-tich-web.xlsx", 3, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6706) },
                    { 4, "application/vnd.openxmlformats-officedocument.presentationml.presentation", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6709), new byte[] { 10, 11, 12 }, "blockchain.pptx", 4, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6709) },
                    { 5, "application/pdf", new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6711), new byte[] { 13, 14, 15 }, "bao-mat.pdf", 5, new DateTime(2025, 5, 7, 0, 40, 20, 430, DateTimeKind.Local).AddTicks(6712) }
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
                name: "IX_ProductAuthor_AuthorId",
                table: "ProductAuthor",
                column: "AuthorId");

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
                name: "ProductAuthor");

            migrationBuilder.DropTable(
                name: "ProductTag");

            migrationBuilder.DropTable(
                name: "UploadFile");

            migrationBuilder.DropTable(
                name: "Author");

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
