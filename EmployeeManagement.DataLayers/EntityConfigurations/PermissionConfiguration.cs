using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EmployeeManagement.DataLayer.EntityConfigurations
{
   public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {

        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.ToTable("Permission");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Permissions).IsRequired();
            builder.Property(x => x.PermissionDescription).IsRequired();
            builder.Property(x => x.CompanyId).IsRequired();
            builder.Property(x => x.ScreenId).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(40);
            builder.Property(x => x.UpdatedOn).IsRequired(false);
            builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(40);
          //  builder.Property(x => x.updatedDate).IsRequired(false);

            builder.HasOne(x => x.Screen).WithMany().HasForeignKey(x => x.ScreenId);
            builder.HasOne(x => x.Company).WithMany().HasForeignKey(x => x.CompanyId);
           
        }

    }
}
