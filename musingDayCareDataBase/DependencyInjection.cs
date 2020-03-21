using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using musingDayCareComman.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace musingDayCareDataBase
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<MusingDayCareDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("musingDayCareDatabase")));

            services.AddScoped<IMusingDayCareDbContext>(provider => provider.GetService<MusingDayCareDbContext>());
            return services;
        }
    }
}
