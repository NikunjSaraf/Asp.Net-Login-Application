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
    public class RegisterRepository : IRegisterRepos
    {
        public string Register(RegisterModel rm)
        {
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.ConnectionStrings["LoginAppDB"].ConnectionString))
            using (var cmd = new SqlCommand(new RegisterQuery().Register(rm), con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }

            return rm.UserName + "Register Successfull";
        }
    }
}