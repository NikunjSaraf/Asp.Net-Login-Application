using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginApplication.Business_Logic.IManagers;
using LoginApplication.Models;
using LoginApplication.Data_Access.IRepos;

namespace LoginApplication.Business_Logic
{
    public class RegisterManager : IRegister
    {
        private IRegisterRepos _registerRepos;

        public RegisterManager()
        {
            _registerRepos = new Data_Access.RegisterRepository();
        }
        public string Register(RegisterModel rm)
        {
            return _registerRepos.Register(rm);
        }
    }
}