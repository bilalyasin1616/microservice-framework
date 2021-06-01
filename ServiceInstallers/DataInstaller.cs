﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Framework.ServiceInstallers
{
    public class DataInstaller<C>: IDataInstaller where C : DbContext
    {
        public void InstallServices(IServiceCollection services, IConfiguration configuration) 
        {
            services.AddDbContext<C>(options => options.UseNpgsql(configuration["ConnectionString"]));
        }
    }
}
