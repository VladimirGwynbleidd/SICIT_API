using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace SICIT.API.UTILITIES
{
    public class HashPassword
    {
        public static string CreatePassword(string psw)
        {
            return FormsAuthentication.HashPasswordForStoringInConfigFile(psw, "md5");
        }
    }
}
