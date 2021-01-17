using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LoginApplication.Models
{
    public class Response
    {
        public string Message { get; set; }
        public int Status { get; set; }
        public dynamic Data { get; set; }

    }
}