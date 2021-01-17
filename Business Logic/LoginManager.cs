using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginApplication.Business_Logic.IManagers;
using LoginApplication.Models;
using LoginApplication.Data_Access.IRepos;

namespace LoginApplication.Business_Logic
{
    public class LoginManager : ILogin
    {
        private readonly ILoginRepos loginRepos;

        public LoginManager()
        {
            loginRepos = new Data_Access.LoginRepository();
        }

        public string Login(LoginModel lm)
        {
            return loginRepos.Login(lm);
        }
    }
}