using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Abstracts
{
    public interface IEmailContentService
    {
        string BuildLoginConfirmationEmail(string email);
    }
}
