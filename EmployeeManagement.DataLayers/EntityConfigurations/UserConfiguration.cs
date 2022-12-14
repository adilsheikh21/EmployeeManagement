using EmployeeManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.EntityConfigurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.UserFirstName).IsRequired();
            builder.Property(x => x.UserLastName).IsRequired();
            builder.Property(x => x.UserName).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Password).IsRequired();
            builder.Property(x => x.Mobile).IsRequired();
            builder.Property(x => x.IpAddress).IsRequired();
            builder.Property(x => x.FinanceYear).IsRequired();
            builder.Property(x => x.AppId).IsRequired();
            builder.Property(x => x.RoleId).IsRequired();
            builder.Property(x => x.otp).IsRequired();
            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.image).IsRequired(false);
            builder.Property(x => x.Postalcode).IsRequired(false);

            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(40);
            builder.Property(x => x.UpdatedOn).IsRequired(false);
            builder.Property(x => x.LastLogin).IsRequired(false);
           // builder.Property(x => x.LangId).IsRequired(false);
            builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(40);
            builder.Property(x => x.CompanyId).IsRequired();
            builder.HasOne(x => x.Role).WithMany().HasForeignKey(x => x.RoleId);
            builder.HasOne(x => x.Company).WithMany().HasForeignKey(x => x.CompanyId);
            builder.HasOne(x => x.Language).WithMany().HasForeignKey(x => x.LangId);

        }
    }
}