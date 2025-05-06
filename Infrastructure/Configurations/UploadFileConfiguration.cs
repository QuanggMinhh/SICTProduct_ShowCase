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
    public class UploadFileConfiguration : IEntityTypeConfiguration<UploadFile>
    {
        public void Configure(EntityTypeBuilder<UploadFile> builder)
        {
            builder.ToTable(nameof(UploadFile));
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.HasOne(u=>u.Product).WithMany(p=>p.UploadFiles).HasForeignKey(x=>x.ProductId).OnDelete(DeleteBehavior.Cascade);
        }
    }
}
