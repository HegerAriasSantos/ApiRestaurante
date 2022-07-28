using ApiRestaurante.Core.Application.Interfaces.Services;
using ApiRestaurante.Infrastructure.Identity.Contexts;
using ApiRestaurante.Infrastructure.Identity.Entities;
using ApiRestaurante.Infrastructure.Identity.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InternetBanking.Infrastructure.Identity
{
    public static class IDTTServiceRegistration
    {
        public static void AddIdentityInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            #region Identity
            services.AddIdentity<AppUser, IdentityRole>()
                    .AddEntityFrameworkStores<IDTTContext>()
                    .AddDefaultTokenProviders();

            //services.ConfigureApplicationCookie(options =>
            //{
            //    options.LoginPath = "/User";
            //    options.AccessDeniedPath = "/User/AccessDenied";
            //});

            services.AddAuthentication();
            #endregion

            #region Database
            if (config.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<IDTTContext>(options =>
                       options.UseInMemoryDatabase("IdentityDb"));
            }
            else
            {
                services.AddDbContext<IDTTContext>(options =>
                {
                    options.EnableSensitiveDataLogging();
                    options.UseSqlServer(
                        config.GetConnectionString("IDTTConnection"),
                        m => m.MigrationsAssembly(typeof(IDTTContext).Assembly.FullName)
                    );
                });
            }
            #endregion

            #region Services
            services.AddTransient<IAccountService, AccountService>();
            //services.AddTransient<IRoleService, RoleService>();
            #endregion
        }
    }
}