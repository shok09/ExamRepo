using System;
using System.Collections.Generic;
using System.Text;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Configurations
{
    internal class DateInfoConfiguration : IEntityTypeConfiguration<DateInfo>
    {
        public void Configure(EntityTypeBuilder<DateInfo> builder)
        {
            builder.Property(dt => dt.DateOfMan)
                .IsRequired();

            builder.Property(dt => dt.DateOfExpire)
                .IsRequired();
        }
    }
}
