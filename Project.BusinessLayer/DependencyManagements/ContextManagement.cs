using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccessLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.Resolvers
{
    public static class ContextManagement
    {
        public static IServiceCollection ContextManagers(this IServiceCollection services)
        {
            ServiceProvider serviceProvider = services.BuildServiceProvider();
            IConfiguration configuration = serviceProvider.GetService<IConfiguration>();
            services.
                AddDbContextPool<MyContext>(options =>
                options.UseSqlServer
                (configuration.GetConnectionString("MyConnection"))
                .UseLazyLoadingProxies());

            return services;
        }
    }
}
