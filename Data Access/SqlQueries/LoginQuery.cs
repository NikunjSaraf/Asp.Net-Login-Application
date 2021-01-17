using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginApplication.Models;

namespace LoginApplication.Data_Access.SqlQueries
{
    internal class LoginQuery
    {
        internal string Login(LoginModel lm)
        {
            RegisterModel rm = new RegisterModel();
            string query = string.Empty;
            query = "select * from dbo.RegisterTable where UserName='" + rm.UserName + "' and Password='" + rm.Password +" '";

            return query;
        } 
    }
}