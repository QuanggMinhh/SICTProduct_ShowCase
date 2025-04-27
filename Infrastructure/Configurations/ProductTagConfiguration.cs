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
    public class ProductTagConfiguration : IEntityTypeConfiguration<ProductTag>
    {
        public void Configure(EntityTypeBuilder<ProductTag> builder)
        {
            builder.ToTable(nameof(ProductTag));
            builder.HasKey(p=>new { p.ProductId, p.TagId });
            builder.HasOne(pt=>pt.Product).WithMany(p=>p.ProductTags).HasForeignKey(x=>x.ProductId);
            builder.HasOne(pt=>pt.Tag).WithMany(t=> t.ProductTags).HasForeignKey(x=>x.TagId);
        }
    }
}
