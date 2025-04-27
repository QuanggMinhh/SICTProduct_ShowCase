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

            modelBuilder.Entity<Role>().HasData(
        new Role { Id = 1, RoleName = "Admin", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
        new Role { Id = 2, RoleName = "Contributor", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
    );

            modelBuilder.Entity<User>().HasData(
                new User { Id = 1, UserName = "admin1", Email = "admin1@example.com", Password = "hashed_pwd", RoleId = 1, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 2, UserName = "contributor1", Email = "user1@example.com", Password = "hashed_pwd", RoleId = 2, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 3, UserName = "contributor2", Email = "user2@example.com", Password = "hashed_pwd", RoleId = 2, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 4, UserName = "contributor3", Email = "user3@example.com", Password = "hashed_pwd", RoleId = 2, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new User { Id = 5, UserName = "contributor4", Email = "user4@example.com", Password = "hashed_pwd", RoleId = 2, Status = 1, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, CategoryName = "AI", Description = "Artificial Intelligence", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 2, CategoryName = "Blockchain", Description = "Blockchain tech", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 3, CategoryName = "Cloud", Description = "Cloud computing", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 4, CategoryName = "IoT", Description = "Internet of Things", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Category { Id = 5, CategoryName = "Cybersecurity", Description = "Security", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Tag>().HasData(
                new Tag { Id = 1, Name = "Machine Learning", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 2, Name = "NFT", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 3, Name = "AWS", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 4, Name = "Smart Home", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Tag { Id = 5, Name = "Data Protection", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Title = "AI Assistant", Description = "AI chatbot",Image="", ManagerId = 1, CategoryId = 1, Status = "Approved", View = 100, Level = "Advanced", RejectReason = "Incomplete features", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Product { Id = 2, Title = "Blockchain Wallet", Description = "Crypto wallet", Image = "", ManagerId = 2, CategoryId = 2, Status = "Pending", View = 50, Level = "Intermediate", RejectReason = "Incomplete features", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Product { Id = 3, Title = "Cloud Storage", Description = "Secure cloud", Image = "", ManagerId = 3, CategoryId = 3, Status = "Approved", View = 75, Level = "Basic", RejectReason = "Incomplete features", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Product { Id = 4, Title = "Smart IoT Sensor", Description = "Smart sensors", Image = "", ManagerId = 4, CategoryId = 4, Status = "Rejected", View = 30, Level = "Advanced", RejectReason = "Incomplete features", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new Product { Id = 5, Title = "Cyber Shield", Description = "Security app", Image = "", ManagerId = 5, CategoryId = 5, Status = "Approved", View = 90, Level = "Intermediate", RejectReason = "Incomplete features", CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );

            modelBuilder.Entity<ProductTag>().HasData(
                new ProductTag { ProductId = 1, TagId = 1 },
                new ProductTag { ProductId = 2, TagId = 2 },
                new ProductTag { ProductId = 3, TagId = 3 },
                new ProductTag { ProductId = 4, TagId = 4 },
                new ProductTag { ProductId = 5, TagId = 5 }
            );

            modelBuilder.Entity<UploadFile>().HasData(
                new UploadFile { Id = 1, FileName = "ai_doc.pdf", ContentType = "application/pdf", ProductId = 1, Data = new byte[] { }, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new UploadFile { Id = 2, FileName = "wallet_doc.pdf", ContentType = "application/pdf", ProductId = 2, Data = new byte[] { }, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new UploadFile { Id = 3, FileName = "cloud_doc.pdf", ContentType = "application/pdf", ProductId = 3, Data = new byte[] { }, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new UploadFile { Id = 4, FileName = "iot_doc.pdf", ContentType = "application/pdf", ProductId = 4, Data = new byte[] { }, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now },
                new UploadFile { Id = 5, FileName = "cyber_doc.pdf", ContentType = "application/pdf", ProductId = 5, Data = new byte[] { }, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now }
            );
        }
    }
}
