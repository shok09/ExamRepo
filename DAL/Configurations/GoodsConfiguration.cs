using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    internal class GoodsConfiguration : IEntityTypeConfiguration<Goods>
    {
        public void Configure(EntityTypeBuilder<Goods> builder)
        {

            builder.Property(g => g.Title)
                .HasMaxLength(80)
                .IsRequired();

            builder.Property(g => g.Volume)
                .IsRequired();

            builder.HasIndex(g => g.Title);
        }
    }
}
