using EmployeeManagement.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagement.DataLayer.EntityConfigurations
{
    class FormCommonFieldValueConfiguration : IEntityTypeConfiguration<FormCommonFieldValue>
    {
        public void Configure(EntityTypeBuilder<FormCommonFieldValue> builder)
        {
            builder.ToTable("FormCommonFieldValue");
            builder.HasKey(x => x.id);
            builder.Property(x => x.id).ValueGeneratedOnAdd();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.FormId).IsRequired();
            builder.Property(x => x.BusinessCategoryId).IsRequired(false);
            builder.Property(x => x.BusinessSubCategoryId).IsRequired(false);
            builder.Property(x => x.UserName).IsRequired(false);
            builder.Property(x => x.Description).IsRequired(false);
            builder.Property(x => x.MobileNo).IsRequired(false);
            builder.Property(x => x.BusinessName).IsRequired(false);
            builder.Property(x => x.BusinessAlias).IsRequired(false);
            builder.Property(x => x.Email).IsRequired(false);
            builder.Property(x => x.Address).IsRequired(false);
            builder.Property(x => x.Postalcode).IsRequired(false);
            builder.Property(x => x.IsClaim).IsRequired();
            builder.Property(x => x.ClaimUserId).IsRequired(false);
            builder.Property(x => x.Otp).IsRequired(false);

            builder.Property(x => x.Status).IsRequired();
            builder.Property(x => x.CreatedOn).IsRequired();
            builder.Property(x => x.CreatedBy).IsRequired().HasMaxLength(40);
            builder.Property(x => x.UpdatedOn).IsRequired(false);
            builder.Property(x => x.UpdatedBy).IsRequired(false).HasMaxLength(40);

        }
    }
}
