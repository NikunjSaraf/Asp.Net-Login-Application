using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApplication.Models;

namespace LoginApplication.Business_Logic.IManagers
{
   public interface ILogin
    {
        string Login(LoginModel lm);
    }
}
