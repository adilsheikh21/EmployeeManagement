using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using EmployeeManagement.Entities;

namespace EmployeeManagement.DataLayer.EntityConfigurations
{
    public class LoginModuleConfiguration : IEntityTypeConfiguration<LoginModule>
    {
        public void Configure(EntityTypeBuilder<LoginModule> builder)
        {
            {

                builder.Property(x => x.Id).IsRequired();
                builder.Property(x => x.UserId).IsRequired();
                builder.Property(x => x.createdOn).IsRequired(false);
                builder.Property(x => x.Status1).IsRequired(false);
                builder.Property(x => x.Status).IsRequired();
                builder.Property(x => x.RoleId).IsRequired(false);
                builder.Property(x => x.LastLogin).IsRequired(false);
                builder.Property(x => x.IpAddress).IsRequired(false);
                builder.Property(x => x.BrowserAgent).IsRequired(false);


                builder.HasOne(x => x.user).WithMany().HasForeignKey(x => x.UserId);
            }
        }
    }
}
