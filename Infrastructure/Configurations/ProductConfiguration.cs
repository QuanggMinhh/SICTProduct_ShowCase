using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable(nameof(Product));
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();
            builder.HasOne(p=>p.User).WithMany(u=>u.Products).HasForeignKey(x=>x.ManagerId).OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(p=>p.Category).WithMany(c=>c.Products).HasForeignKey(x=>x.CategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
