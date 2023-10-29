using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Concretes
{
    public class EmailContentManager : IEmailContentService
    {
        public string BuildLoginConfirmationEmail(string email)
        {
            return $@"
                <html>
            <head>
                <title>Congratulations</title>
            </head>
            <body>
                <h1>Congratulations, {email} !</h1>
                <p>You have successfully logged in to our portal.</p>
            </body>
            </html>
                ";
        }
    }
}


//{ LoginVMMail}