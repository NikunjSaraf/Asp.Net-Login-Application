using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LoginApplication.Business_Logic.IManagers;
using LoginApplication.Models;


namespace LoginApplication.Controllers
{
    public class LoginController : ApiController
    {
        private ILogin login;

        public LoginController()
        {
            login = new Business_Logic.LoginManager();
        }

        public IHttpActionResult Login(LoginModel lm)
        {
            if (ModelState.IsValid)
            {
                return Ok(new Response { Status = (int)HttpStatusCode.OK, Message = Convert.ToString(HttpStatusCode.OK), Data = login.Login(lm) });
            }
            else
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                return Ok(new Response { Status = (int)HttpStatusCode.BadRequest, Message = Convert.ToString(HttpStatusCode.BadRequest), Data =errors });
            }
        }

    }
}
