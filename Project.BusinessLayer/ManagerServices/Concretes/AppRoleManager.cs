using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.ManagerServices.Concretes
{
    public class AppRoleManager : BaseManager<AppRole>, IAppRoleManager
    {
        IAppRoleRepository _iappRoleRepository; // Burada alir DAL'daki Interface'i Entity icin.
        public AppRoleManager(IAppRoleRepository iappRoleRepository) : base(iappRoleRepository)
        {
            _iappRoleRepository = iappRoleRepository;
        }
    }
}
