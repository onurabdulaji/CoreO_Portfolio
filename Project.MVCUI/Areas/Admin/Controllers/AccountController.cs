using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.DTOLayer.DTOS.AdminDTOs;
using Project.EntityLayer.Models;

namespace Project.MVCUI.Areas.Admin.Controllers
{
	[Area("Admin")]
	[AllowAnonymous]
	public class AccountController : Controller
	{
		IAppUserManager _iappUserManager;

		public AccountController(IAppUserManager iappUserManager)
		{
			_iappUserManager = iappUserManager;
		}

		public IActionResult Index()
		{
			return View();
		}


		[HttpGet]
		public IActionResult SignUp()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> SignUp(SignUpVM signInVM)
		{
			var newUser = new AppUser
			{
				FirstName = signInVM.Name,
				LastName = signInVM.Surname,
				Email = signInVM.Mail,
				UserName = signInVM.Username
			};
			bool result = await _iappUserManager.CreateUser(newUser, signInVM.Password);
			if (result)
			{
				return RedirectToAction("SignIn", "Account");
			}
			else
			{
				ModelState.AddModelError(string.Empty, "Hey , Sorry but you have entered something wrong , Result Failed.");
			}
			return View(signInVM);
		}
	}
}
