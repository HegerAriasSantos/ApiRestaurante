using ApiRestaurante.Infrastructure.Identity.Entities;
using InternetBanking.Infrastructure.Identity.Seeds;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRestaurante
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using(var scope = host.Services.CreateScope())
            {
                var s = scope.ServiceProvider;

                try
                {
                    var userM = s.GetRequiredService<UserManager<AppUser>>();
                    var roleM = s.GetRequiredService<RoleManager<IdentityRole>>();

                    await DefaultRoles.SeedAsync(userM, roleM);
                    await DefaultAdminUser.SeedAsync(userM, roleM);
                }catch(Exception ex)
                {
                    Console.WriteLine($"Error executing seeds: {ex.Message}");
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
