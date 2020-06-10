﻿using AutoMapper;
using BLL.Services;
using BLL.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace BLL.Dependencies
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddBllConfiguration
            (this IServiceCollection services)
        {
            services.AddScoped<IRoomService, RoomService>();
            services.AddScoped<IGoodsService, GoodsService>();

            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
