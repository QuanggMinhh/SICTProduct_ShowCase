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
    public class ProductAuthorConfiguration : IEntityTypeConfiguration<ProductAuthor>
    {
        public void Configure(EntityTypeBuilder<ProductAuthor> builder)
        {
            builder.ToTable(nameof(ProductAuthor));
            builder.HasKey(pa => new { pa.ProductId, pa.AuthorId });

            // Quan hệ với Product
            builder.HasOne(pa => pa.Product)
                   .WithMany(p => p.ProductAuthors)
                   .HasForeignKey(pa => pa.ProductId)
                   .OnDelete(DeleteBehavior.Cascade);

            // Quan hệ với Author
            builder.HasOne(pa => pa.Author)
                   .WithMany(a => a.ProductAuthors)
                   .HasForeignKey(pa => pa.AuthorId)
                   .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
