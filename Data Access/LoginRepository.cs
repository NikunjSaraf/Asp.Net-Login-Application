using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using LoginApplication.Data_Access.IRepos;
using LoginApplication.Data_Access.SqlQueries;
using LoginApplication.Models;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace LoginApplication.Data_Access
{
    public class LoginRepository : ILoginRepos
    {

        public string Login(LoginModel lm)
        {
            //LoginQuery lq = new LoginQuery();
            //string query = lq.Login(lm);
            DataTable table = new DataTable();
            using (var con=new SqlConnection(ConfigurationManager.ConnectionStrings["LoginAppDB"].ConnectionString))
                using(var cmd=new SqlCommand(new LoginQuery().Login(lm),con ))
                using(var da=new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
               da.Fill(table);
            }

              return "Login Successfull "+ lm.Username;
            
        }
    }
}