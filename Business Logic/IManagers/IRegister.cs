using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApplication.Models;


namespace LoginApplication.Business_Logic.IManagers
{
   internal interface IRegister
    {
        string Register(RegisterModel rm);
    }
}
