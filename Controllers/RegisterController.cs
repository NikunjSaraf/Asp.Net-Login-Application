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
    public class RegisterController : ApiController
    {
        private  IRegister register;
            
        public RegisterController()
        {
            register = new Business_Logic.RegisterManager();
        }

        [HttpPost]
        public IHttpActionResult Register(RegisterModel rm)
        {
            if (ModelState.IsValid)
            {
                return Ok(new Response { Status = (int)HttpStatusCode.OK, Message = Convert.ToString(HttpStatusCode.OK), Data = register.Register(rm) });
            }
            else
            {
                var errors = ModelState.Values.SelectMany(x => x.Errors).Select(x => x.ErrorMessage).ToList();
                return Ok(new Response { Status = (int)HttpStatusCode.BadRequest, Message = Convert.ToString(HttpStatusCode.BadRequest), Data = errors });
            }
        }
    }
}
