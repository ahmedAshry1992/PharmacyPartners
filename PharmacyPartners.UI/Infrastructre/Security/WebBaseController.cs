using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentPartners.Infrastructure.Security.WebSecurity
{
    

    public class WebBaseController : Controller
    {
        public readonly IWebHostEnvironment _webHost;

        public string baseUrl => $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}{HttpContext.Request.PathBase}/";

        public WebBaseController(IWebHostEnvironment webHost)
        {
            _webHost = webHost;
        }
    }
}
