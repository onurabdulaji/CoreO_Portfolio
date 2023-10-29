using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Concretes
{
    public class EmailSenderManager : IEmailSenderService
    {
        private readonly IEmailBuilderService _emailBuilderService;
        private readonly ISmptClientService _smptClientService;

        public EmailSenderManager(IEmailBuilderService emailBuilderService, ISmptClientService smptClientService)
        {
            _emailBuilderService = emailBuilderService;
            _smptClientService = smptClientService;
        }

        public void SendEmail(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = _emailBuilderService.BuildEmail(fromEmail, toEmail, subject, body);

            using (var client = _smptClientService.CreateSmptClient("smtp.gmail.com", 587, "onurabdulaji@gmail.com", "emqqkljmtmfgnmaa"))
            {
                client.Send(mimeMessage);
                client.Disconnect(true);
            }
        }

        public async Task SendEmailAsync(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = _emailBuilderService.BuildEmail(fromEmail, toEmail, subject, body);

            using (var client = _smptClientService.CreateSmptClient("smtp.gmail.com", 587, "onurabdulaji@gmail.com", "emqqkljmtmfgnmaa"))
            {
                try
                {
                    await client.SendAsync(mimeMessage);
                    await client.DisconnectAsync(true);
                }
                catch (Exception ex)
                {
                    throw new Exception("E-posta gönderme hatası: " + ex.Message, ex);
                }
            }
        }
    }
}
