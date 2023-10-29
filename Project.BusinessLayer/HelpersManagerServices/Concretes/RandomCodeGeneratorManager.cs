using Project.BusinessLayer.HelpersManagerServices.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer.HelpersManagerServices.Concretes
{
    public class RandomCodeGeneratorManager : IRandomCodeGeneratorService
    {
        public DateTime codeExpiration;
        public int GenerateRandomCode()
        {
            if (DateTime.Now >= codeExpiration)
            {
                // Süre sınırlamasını aştıysanız, yeni bir kod oluşturmadan önce
                // codeExpiration'ı yenilemelisiniz.
                codeExpiration = DateTime.Now.AddMinutes(15);
            }
            Random random = new Random();
            int code = random.Next(100000, 999999);
            return code;
        }

        public int RandomCodeGenerator()
        {
            codeExpiration = DateTime.Now.AddMinutes(15);
            return GenerateRandomCode();
        }
    }
}
