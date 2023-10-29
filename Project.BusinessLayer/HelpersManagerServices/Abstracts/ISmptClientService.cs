using MailKit.Net.Smtp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Abstracts
{
    public interface ISmptClientService
    {
        SmtpClient CreateSmptClient(string smptpServer, int smptPort, string username, string password);
    }
}
