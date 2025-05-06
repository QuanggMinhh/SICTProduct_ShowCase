using Domain.Entities;
using Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Context
{
    public class SICT_ShowCaseContext : DbContext
    {
        public SICT_ShowCaseContext(DbContextOptions options) : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<ProductTag> ProductTags { get; set; }
        public DbSet<UploadFile> UploadFiles { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<ProductAuthor> ProductAuthors { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new  RoleConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new TagConfiguration());
            modelBuilder.ApplyConfiguration(new ProductTagConfiguration());
            modelBuilder.ApplyConfiguration(new UploadFileConfiguration());
            modelBuilder.ApplyConfiguration(new ProductAuthorConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());

            modelBuilder.Entity<Role>().HasData(
                new Role { Id = 1, RoleName = "Admin", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Role { Id = 2, RoleName = "Manager", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "admin01", Email = "admin1@example.com", Password = "admin123", RoleId = 1, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 2, UserName = "manager01", Email = "manager1@example.com", Password = "manager123", RoleId = 2, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 3, UserName = "admin02", Email = "admin2@example.com", Password = "admin456", RoleId = 1, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 4, UserName = "manager02", Email = "manager2@example.com", Password = "manager456", RoleId = 2, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 5, UserName = "admin03", Email = "admin3@example.com", Password = "admin789", RoleId = 1, Status = 0, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "Khoa học máy tính", Description = "Lĩnh vực CNTT", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 2, CategoryName = "Trí tuệ nhân tạo", Description = "AI và Machine Learning", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 3, CategoryName = "Kỹ thuật phần mềm", Description = "Thiết kế và phát triển phần mềm", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 4, CategoryName = "An toàn thông tin", Description = "Bảo mật hệ thống", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 5, CategoryName = "Hệ thống thông tin", Description = "Phân tích và quản lý thông tin", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "Trí tuệ nhân tạo", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 2, Name = "Học máy", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 3, Name = "An ninh mạng", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 4, Name = "Cơ sở dữ liệu", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 5, Name = "Phát triển Web", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product
                {
                    Id = 1,
                    Title = "Hệ thống quản lý thư viện",
                    Description = "Ứng dụng quản lý sách, mượn-trả",
                    Image = "library.png",
                    ManagerId = 1,
                    CategoryId = 1,
                    Status = "Đã duyệt",
                    View = 100,
                    RejectReason = null,
                    Level = "Đại học",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    Id = 2,
                    Title = "Nhận diện khuôn mặt bằng AI",
                    Description = "Dự án ứng dụng OpenCV và Python",
                    Image = "face_ai.png",
                    ManagerId = 2,
                    CategoryId = 2,
                    Status = "Chờ duyệt",
                    View = 75,
                    RejectReason = null,
                    Level = "Thạc sĩ",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    Id = 3,
                    Title = "Phân tích hành vi người dùng Web",
                    Description = "Thống kê, khai thác dữ liệu truy cập",
                    Image = "analytics.png",
                    ManagerId = 3,
                    CategoryId = 5,
                    Status = "Bị từ chối",
                    View = 30,
                    RejectReason = "Thiếu dữ liệu thực nghiệm",
                    Level = "Đại học",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    Id = 4,
                    Title = "Ứng dụng Blockchain trong giáo dục",
                    Description = "Quản lý chứng chỉ học tập minh bạch",
                    Image = "blockchain.png",
                    ManagerId = 4,
                    CategoryId = 3,
                    Status = "Đã duyệt",
                    View = 55,
                    RejectReason = null,
                    Level = "Tiến sĩ",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Product
                {
                    Id = 5,
                    Title = "Hệ thống cảnh báo xâm nhập mạng",
                    Description = "Sử dụng Machine Learning phát hiện tấn công",
                    Image = "ids.png",
                    ManagerId = 5,
                    CategoryId = 4,
                    Status = "Chờ duyệt",
                    View = 90,
                    RejectReason = null,
                    Level = "Thạc sĩ",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );

            modelBuilder.Entity<ProductTag>().HasData(
                new ProductTag { ProductId = 1, TagId = 1 },
                new ProductTag { ProductId = 1, TagId = 4 },
                new ProductTag { ProductId = 2, TagId = 2 },
                new ProductTag { ProductId = 3, TagId = 5 },
                new ProductTag { ProductId = 3, TagId = 4 },
                new ProductTag { ProductId = 4, TagId = 3 },
                new ProductTag { ProductId = 4, TagId = 1 },
                new ProductTag { ProductId = 5, TagId = 2 },
                new ProductTag { ProductId = 5, TagId = 3 },
                new ProductTag { ProductId = 5, TagId = 5 }
            );

            modelBuilder.Entity<UploadFile>().HasData(
                new UploadFile
                {
                    Id = 1,
                    FileName = "thu-vien.pdf",
                    Data = new byte[] { 1, 2, 3 }, // Dữ liệu giả
                    ContentType = "application/pdf",
                    ProductId = 1,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new UploadFile
                {
                    Id = 2,
                    FileName = "ai-project.docx",
                    Data = new byte[] { 4, 5, 6 },
                    ContentType = "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                    ProductId = 2,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new UploadFile
                {
                    Id = 3,
                    FileName = "phan-tich-web.xlsx",
                    Data = new byte[] { 7, 8, 9 },
                    ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                    ProductId = 3,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new UploadFile
                {
                    Id = 4,
                    FileName = "blockchain.pptx",
                    Data = new byte[] { 10, 11, 12 },
                    ContentType = "application/vnd.openxmlformats-officedocument.presentationml.presentation",
                    ProductId = 4,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new UploadFile
                {
                    Id = 5,
                    FileName = "bao-mat.pdf",
                    Data = new byte[] { 13, 14, 15 },
                    ContentType = "application/pdf",
                    ProductId = 5,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    Id = 1,
                    FullName = "Nguyễn Văn A",
                    Email = "nguyenvana@example.com",
                    PhoneNumber = "0901234567",
                    AcademicTitle = "GS",
                    Degree = "TS",
                    Position = "Giảng viên",
                    AvatarUrl = "/images/author1.jpg",
                    IsStudent = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Author
                {
                    Id = 2,
                    FullName = "Trần Thị B",
                    Email = "tranthib@example.com",
                    PhoneNumber = "0902345678",
                    AcademicTitle = "PGS",
                    Degree = "ThS",
                    Position = "Giảng viên",
                    AvatarUrl = "/images/author2.jpg",
                    IsStudent = false,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Author
                {
                    Id = 3,
                    FullName = "Lê Văn C",
                    Email = "levanc@example.com",
                    PhoneNumber = "0913456789",
                    AcademicTitle = "",
                    Degree = "CN",
                    Position = "Sinh viên",
                    AvatarUrl = "/images/author3.jpg",
                    IsStudent = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Author
                {
                    Id = 4,
                    FullName = "Phạm Thị D",
                    Email = "phamthid@example.com",
                    PhoneNumber = "0934567890",
                    AcademicTitle = "",
                    Degree = "ThS",
                    Position = "Nghiên cứu sinh",
                    AvatarUrl = "/images/author4.jpg",
                    IsStudent = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                },
                new Author
                {
                    Id = 5,
                    FullName = "Đỗ Văn E",
                    Email = "dovane@example.com",
                    PhoneNumber = "0987654321",
                    AcademicTitle = "",
                    Degree = "CN",
                    Position = "Sinh viên",
                    AvatarUrl = "/images/author5.jpg",
                    IsStudent = true,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            );
            modelBuilder.Entity<ProductAuthor>().HasData(
                new ProductAuthor { ProductId = 1, AuthorId = 1 },
                new ProductAuthor { ProductId = 1, AuthorId = 3 }, // sản phẩm 1 có 2 tác giả
                new ProductAuthor { ProductId = 2, AuthorId = 2 },
                new ProductAuthor { ProductId = 3, AuthorId = 4 },
                new ProductAuthor { ProductId = 3, AuthorId = 5 }, // sản phẩm 3 có 2 tác giả
                new ProductAuthor { ProductId = 4, AuthorId = 1 },
                new ProductAuthor { ProductId = 5, AuthorId = 2 }
            );
        }
    }
}
