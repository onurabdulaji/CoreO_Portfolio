﻿using Microsoft.Extensions.DependencyInjection;
using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using Project.BusinessLayer.HelpersManagerServices.Concretes;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.BusinessLayer.ManagerServices.Concretes;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.DataAccessLayer.Repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.DependencyManagements
{
    public static class DependencyManagement
    {
        public static IServiceCollection DependencyManagers(this IServiceCollection services)
        {
            // Bases
            services.AddScoped(typeof(IRepository<>), typeof(BaseRepository<>));
            services.AddScoped(typeof(IManager<>), typeof(BaseManager<>));

            // Dependencies 
            services.AddScoped<IAppUserManager, AppUserManager>();
            services.AddScoped<IAppRoleManager, AppRoleManager>();

            services.AddScoped<IAppRoleRepository, AppRoleRepository>();
            services.AddScoped<IAppUserRepository, AppUserRepository>();

            // Helpers
            services.AddScoped<IEmailBuilderService, EmailBuilderManager>();
            services.AddScoped<IEmailContentService, EmailContentManager>();
            services.AddScoped<IEmailSenderService, EmailSenderManager>();
            services.AddScoped<IRandomCodeGeneratorService, RandomCodeGeneratorManager>();
            services.AddScoped<ISmptClientService, SmptClientManager>();



            return services;
        }
    }
}
