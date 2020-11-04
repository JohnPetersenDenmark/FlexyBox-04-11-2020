using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using InfrastructureLayer.Persistence;
using ApplicationLayer.Common;

namespace InfrastructureLayer
{
    public static class DependencyInjectionDatabase
    {
        public static IServiceCollection AddDatabase(this IServiceCollection services, IConfiguration configuration)
        {
            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<WebAppDbContext>(options =>
                    options.UseInMemoryDatabase("FlexyBoxDb"));
            }
            else
            {
                services.AddDbContext<WebAppDbContext>(options =>
                    options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(WebAppDbContext).Assembly.FullName)));
            }

            services.AddScoped<IWebAppDbContext>(provider => provider.GetService<WebAppDbContext>());
            return services;
        }
    }
}
