using BilgeadamEgitim.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BilgeadamEgitim.DataAccess.Configuration
{
    public class ContentConfiguration : IEntityTypeConfiguration<Content>
    {
        public void Configure(EntityTypeBuilder<Content> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).UseIdentityColumn();

            builder.Property(x => x.Title).IsRequired().HasMaxLength(50);

            builder.HasOne(x => x.Author).WithMany(x => x.Contents).HasForeignKey(x => x.AuthorId);

            //builder.ToTable("Contents");
        }
  
    }
}
