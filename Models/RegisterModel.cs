﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApplication.Models
{
    public class RegisterModel
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }
}