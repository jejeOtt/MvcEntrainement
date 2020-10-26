using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MvcEntrainement.Data;
using MvcEntrainement.Helpers;
using MvcEntrainement.Interfaces;
using MvcEntrainement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcEntrainement.Extensions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddAutoMapper(typeof(AutoMapperProfiles).Assembly);
            services.AddDbContext<MvcSoprofenContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("MvcSoprofenContext"));
            });

            return services;
                     
        }
    }
}
