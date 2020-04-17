using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Musing.edu.Hostel.Common.Interfaces;

namespace Musing.Edu.Hostel.DataBase
{
    public static class DataBaseDependencyInjection
    {
        public static IServiceCollection AddDataBase(this IServiceCollection services,  string connectionStringName)
        {
            // TODO: Need to get the connection string name from api layer 
            services.AddDbContext<HostelDbContext>(options =>
                options.UseSqlServer(connectionStringName));

            services.AddScoped<IHostelDbContext>(provider => provider.GetService<HostelDbContext>());
            return services;
        }
    }
}
