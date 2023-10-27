using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Project.DataAccessLayer.Context;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.DependencyManagements
{
    public static class IdentityManagement
    {
        public static IServiceCollection IdentityManagers(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>()
                .AddEntityFrameworkStores<MyContext>()
                .AddTokenProvider<DataProtectorTokenProvider<AppUser>>(TokenOptions.DefaultProvider).
                 AddEntityFrameworkStores<MyContext>();

            // Error Describer Will Be Added Later

            services.AddIdentityCore<AppUser>
               (options => options.SignIn.RequireConfirmedEmail = true).
               AddEntityFrameworkStores<MyContext>();
            // Login Requirements
            return services;
        }


    }
}
