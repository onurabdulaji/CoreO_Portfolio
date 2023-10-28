using Microsoft.AspNetCore.Identity;
using Project.DataAccessLayer.Context;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccessLayer.Repositories.Concretes
{
    public class AppUserRepository : BaseRepository<AppUser>, IAppUserRepository
    {
        UserManager<AppUser> _userManager;
        public AppUserRepository(MyContext db, UserManager<AppUser> userManager) : base(db)
        {
            _userManager = userManager;
        }

        public async Task<bool> AddUser(AppUser item, string Password)
        {
            IdentityResult result = await _userManager.CreateAsync(item, Password);
            if (result.Succeeded) return true;
            return false;
        }
    }
}
