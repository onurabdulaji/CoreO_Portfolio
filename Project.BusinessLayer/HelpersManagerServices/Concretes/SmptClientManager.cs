using MailKit.Net.Smtp;
using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Concretes
{
    public class SmptClientManager : ISmptClientService
    {
        public SmtpClient CreateSmptClient(string smptpServer, int smptPort, string username, string password)
        {
            var client = new SmtpClient();
            client.Connect(smptpServer, smptPort, false);
            client.Authenticate(username, password);
            return client;
        }
    }
}
