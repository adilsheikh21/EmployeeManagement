using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;

namespace EmployeeManagement.DataLayer.EntityConfiguration
{
    class FormBuilderTypeConfiguration : IEntityTypeConfiguration<FormBuilderType>
    {
        public void Configure(EntityTypeBuilder<FormBuilderType> builder)
        {
            builder.ToTable("FormBuilderType");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.TypeName).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(40);
            builder.Property(x => x.UpdatedOn).IsRequired(false);
            builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(40);
        }
    }
}
