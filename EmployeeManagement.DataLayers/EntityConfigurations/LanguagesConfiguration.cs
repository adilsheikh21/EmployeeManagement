using EmployeeManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.EntityConfigurations
{
  public  class LanguagesConfiguration : IEntityTypeConfiguration<Languages>
    {
        public void Configure(EntityTypeBuilder<Languages> builder)
        {
            builder.ToTable("Languages");
            builder.HasKey(x => x.LanguageId);

            builder.Property(x => x.LanguageId).ValueGeneratedOnAdd();
            builder.Property(x => x.LanguageName).IsRequired();
            builder.Property(x => x.LanguageOrientation).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(40);
            builder.Property(x => x.UpdatedOn).IsRequired(false);
            builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(40);
        }
    }
}
