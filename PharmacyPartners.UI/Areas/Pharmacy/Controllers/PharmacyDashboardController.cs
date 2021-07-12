using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using PaymentPartners.Infrastructure.Security.WebSecurity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyPartners.UI.Areas.Pharmacy.Controllers
{
    
    [Area("Pharmacy")]
    [Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
    public class PharmacyDashboardController : Controller
    {
        //private readonly IWebHostEnvironment webHost;WebBaseController

        //public PharmacyDashboardController(IWebHostEnvironment webHost): base(webHost)
        //{
        //    this.webHost = webHost;
        //}
        
        [Route("/pharmacy/dashboard", Name = "appdashboard")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
