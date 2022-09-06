using EmployeeManagement.DataLayers;
using EmployeeManagement.DataLayers.Repositories;
using EmployeeManagement.Infrastructure.Managers;
using EmployeeManagement.Infrastructure.Repositories;
using EmployeeManagement.Infrastructures.DataLayer;
using EmployeeManagement.Infrastructures.Services;
using EmployeeManagement.Managers;
using EmployeeManagement.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;


namespace EmployeeManagement.Config
{
   public class MiddlewareConfiguration
    {
        public static void ConfigureEf(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<DataContext>(options => options.UseSqlServer(connectionString));
       
        }
        public static void ConfigureUow(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
        public static void ConfigureManager(IServiceCollection services)
        {
            services.AddScoped<IEmailManager, EmailManager>();

            services.AddScoped<IUserAccessMAnager, UserAccessManager>();
            services.AddScoped<IUserManager, UserManager>();
            services.AddScoped<IUserRoleManager, UserRoleManager>();
            services.AddScoped<I1ScreenManager, ScreenManager>();
            services.AddScoped<ILanguagesManager, LanguagesManager>();
            services.AddScoped<IFieldManager, FieldManager>();
            services.AddScoped<IEmailSettingManager, EmailSettingManager>();
            services.AddScoped<IPermissionManager, PermissionManager>();
            services.AddScoped<IRolePermiManager, RolePermiManager>();
            services.AddScoped<IPermiManager, PermiManager>();

            // nextdoor configuration starts from here

            services.AddScoped<IFormBuilderTypeManager, FormBuilderTypeManager>();
            services.AddScoped<IFormManager, FormManager>();
            services.AddScoped<IFormFieldValueManager, FormFieldValueManager>();
            services.AddScoped<IBusinessCategoryManager, BusinessCategoryManager>();
            services.AddScoped<IBusinessSubCategoryManager, BusinessSubCategoryManager>();
        }
        public static void ConfigureRepository(IServiceCollection services)
        {
            services.AddScoped<IUserAccessRepository, UserAccessRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IUserRoleRepository, UserRoleRepository>();
            services.AddScoped<ICompanyRepository, CompanyRepository>();
            services.AddScoped<IScreenRepository, ScreenRepository>();
            services.AddScoped<ILanguagesRepository, LanguagesRepository>();
            services.AddScoped<IFieldRepository, FieldRepository>();
            services.AddScoped<IEmailSettingRepository, EmailSettingRepository>();
            services.AddScoped<IPermissionRepository, PermissionRepository>();
            services.AddScoped<IRolePermiRepository, RolePermiRepository>();
            services.AddScoped<IPermiRepository, PermiRepository>();


            // nextdoor configuration starts from here

            services.AddScoped<IFormBuilderTypeRepository, FormBuilderTypeRepository>();
            services.AddScoped<IFormRepository, FormRepository>();
            services.AddScoped<IFormFieldValueRepository, FormFieldValueRepository>();
            services.AddScoped<IBusinessCategoryRepository, BusinessCategoryRepository>();
            services.AddScoped<IBusinessSubCategoryRepository, BusinessSubCategoryRepository>();

        }
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
        }
    }
}

