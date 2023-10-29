using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using Project.BusinessLayer.ManagerServices.Abstracts;
using Project.DataAccessLayer.Repositories.Abstracts;
using Project.DataAccessLayer.Repositories.Concretes;
using Project.EntityLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.ManagerServices.Concretes
{
    public class AppUserManager : BaseManager<AppUser>, IAppUserManager
    {
        IAppUserRepository _iappUserRepository; // Burada alir DAL'daki Interface'i Entity icin.
        private readonly IEmailSenderService _emailSenderService;
        private readonly IRandomCodeGeneratorService _randomCodeGeneratorService;

        public AppUserManager(IAppUserRepository iappUserRepository, IEmailSenderService emailSenderService, IRandomCodeGeneratorService randomCodeGeneratorService) : base(iappUserRepository)
        {
            _iappUserRepository = iappUserRepository;
            _emailSenderService = emailSenderService;
            _randomCodeGeneratorService = randomCodeGeneratorService;
        }

        public async Task<bool> CreateUser(AppUser item, string Password)
        {
            int code = _randomCodeGeneratorService.GenerateRandomCode();
            if (item.Email == null && item.UserName == null && Password == null)
            {
                return false;
            }
            var result = await _iappUserRepository.AddUser(item, Password);
            if (result)
            {
                await _emailSenderService.SendEmailAsync("onurabdulaji@gmail.com", item.Email, "Admin Verification Code", "Your confirmation code to complete the registration process: " + code);
            }
            else
            {
                return false;
            }
            return result;
        }
    }
}

//return await _iappUserRepository.AddUser(item, Password); // Burada Ekler

