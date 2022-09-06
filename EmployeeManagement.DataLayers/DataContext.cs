using EmployeeManagement.DataLayer.EntityConfiguration;
using EmployeeManagement.DataLayer.EntityConfigurations;
using EmployeeManagement.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using UserManagement.DataLayer.EntityConfigurations;

namespace EmployeeManagement.DataLayers
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions options) : base(options) { }
        public DbSet<User> User { get; set; }
        public DbSet<UserRole> UsersRoles { get; set; }
        public DbSet<LoginModule> LoginModule { get; set; }
        public DbSet<UserScreenAccess> UserScreenAccess { get; set; }
        public DbSet<ScreenDetail> ScreenDetail { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Languages> Languages { get; set; }
        public DbSet<Field> Field { get; set; }
        public DbSet<EmailSetting> EmailSetting { get; set; }

        public DbSet<LogRecord> LogRecord { get; set; }
        public DbSet<Permission> Permission { get; set; }
        public DbSet<Permi> Permi { get; set; }
        public DbSet<RolePermi> RolePermi { get; set; }


        public DbSet<Form> Forms { get; set; }
        public DbSet<FormField> FormFields { get; set; }
        public DbSet<FormOption> FormOptions { get; set; }
        public DbSet<FormBuilderType> FormBuilderTypes { get; set; }
        public DbSet<BusinessCategory> BusinessCategory { get; set; }
        public DbSet<BusinessSubCategory> BusinessSubCategory { get; set; }
        public DbSet<FormFieldValue> FormFieldValue { get; set; }
        public DbSet<FormCommonFieldValue> FormCommonFieldValue { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new UserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new LoginModuleConfiguration());
            modelBuilder.ApplyConfiguration(new UserScreenAccessConfiguration());
            modelBuilder.ApplyConfiguration(new ScreenDetailConfiguration());
            modelBuilder.ApplyConfiguration(new LanguagesConfiguration());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
            modelBuilder.ApplyConfiguration(new FieldConfiguration());
            modelBuilder.ApplyConfiguration(new EmailSettingConfiguration());
            modelBuilder.ApplyConfiguration(new LogRecordConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new RolePermisionConfiguration());
            modelBuilder.ApplyConfiguration(new PermiConfiguration());
            modelBuilder.ApplyConfiguration(new FormConfiguration());
            modelBuilder.ApplyConfiguration(new FormBuilderTypeConfiguration());
            modelBuilder.ApplyConfiguration(new FormFieldValueConfiguration());
            modelBuilder.ApplyConfiguration(new FormCommonFieldValueConfiguration());
            modelBuilder.ApplyConfiguration(new FormFieldConfiguration());
            modelBuilder.ApplyConfiguration(new FormOptionConfiguration());
            modelBuilder.ApplyConfiguration(new BusinessCategoryConfiguration());
            modelBuilder.ApplyConfiguration(new BusinessSubCategoryConfiguration());

        }
    }


}

