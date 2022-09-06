using EmployeeManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.EntityConfigurations
{
    class RolePermisionConfiguration :IEntityTypeConfiguration<RolePermi>
    {
            public void Configure(EntityTypeBuilder<RolePermi> builder)
        {
            builder.ToTable("RolePermission");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();
            builder.Property(x => x.Companyid).IsRequired();
            builder.Property(x => x.PermissionId).IsRequired();
            builder.Property(x => x.Roleid).IsRequired();

            builder.HasOne(x => x.Permi).WithMany().HasForeignKey(x => x.PermissionId);
            builder.HasOne(x => x.Role).WithMany().HasForeignKey(x => x.Roleid);

        }
    
    }
}
