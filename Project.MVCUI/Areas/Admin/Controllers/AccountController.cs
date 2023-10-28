using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.DTOLayer.DTOS.AdminDTOs;
using Project.EntityLayer.Models;

namespace Project.MVCUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    [Route("Admin/SignIn")]
    public class AccountController : Controller
    {
        IAppUserManager _iappUserManager;

        public AccountController(IAppUserManager iappUserManager)
        {
            _iappUserManager = iappUserManager;
        }

        public IActionResult SignIn(SignUpVM signInVM)
        {
            //var newUser = new AppUser
            //{

            //}
            return View();
        }
    }
}
