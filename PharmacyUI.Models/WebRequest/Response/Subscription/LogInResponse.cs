using System;
using System.Collections.Generic;
using System.Text;

namespace PharmacyUI.Models.WebRequest.Response.Subscription
{
    public class LogInResponse :ResponseBuilder
    {
        public LogIn data { get; set; }
    }
    public class LogIn
    {
        public int id { get; set; }
        public string email { get; set; }
        public string firstName { set; get; }
    }
}
