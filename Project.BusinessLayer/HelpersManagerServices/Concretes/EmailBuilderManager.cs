using MimeKit;
using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Concretes
{
    public class EmailBuilderManager : IEmailBuilderService
    {
        public MimeMessage BuildEmail(string fromEmail, string toEmail, string subject, string body)
        {
            var mimeMessage = new MimeMessage();

            mimeMessage.From.Add(new MailboxAddress("Admin", fromEmail));
            mimeMessage.To.Add(new MailboxAddress("User", toEmail));

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = body;

            mimeMessage.Body = bodyBuilder.ToMessageBody();
            mimeMessage.Subject = subject;

            return mimeMessage;
        }
    }
}
