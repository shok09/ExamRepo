using System;
using DAL.EF;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using DAL.UnitOfWork;

namespace DAL.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDalConfiguration
            (this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<StorageContext>(options =>
            options.UseLazyLoadingProxies().
            UseSqlServer(configuration.
            GetConnectionString("StorageDataBase")));

            services.AddScoped<IUnitOfWork, UnitOfWork.UnitOfWork>();

            return services;
        }
    }
}
