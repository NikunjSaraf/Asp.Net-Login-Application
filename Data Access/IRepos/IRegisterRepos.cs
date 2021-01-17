using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoginApplication.Models;

namespace LoginApplication.Data_Access.IRepos
{
    public interface IRegisterRepos
    {
        string Register(RegisterModel rm);
    }
}
