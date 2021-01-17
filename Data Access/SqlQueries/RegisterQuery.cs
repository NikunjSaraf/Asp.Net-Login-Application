using LoginApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApplication.Data_Access.SqlQueries
{
    public class RegisterQuery
    {
        internal string Register(RegisterModel rm)
        {
            string query = string.Empty;
            query = @"
                    insert into dbo.RegisterTable values
                    (
                         '" + rm.FullName + @"'
                        ,'" + rm.Email + @"'
                        ,'" + rm.Password + @"'
                        ,'" + rm.UserName+ @"'

                    )
                    ";

            return query;
        }

    }
}