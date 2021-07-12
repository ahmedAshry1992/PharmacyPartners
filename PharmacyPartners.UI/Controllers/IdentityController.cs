using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PharmacyUI.DataProviders.IProviders;
using PharmacyUI.Models.WebRequest.Request.Subscription;
using PharmacyUI.Models.WebRequest.Response.Subscription;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace PharmacyPartners.UI.Controllers
{
    public class IdentityController : Controller
    {
        private readonly ISubscriptionProvider _subscriptionProvider;

        public IdentityController(ISubscriptionProvider subscriptionProvider)
        {
            _subscriptionProvider = subscriptionProvider;
        }
        [Route("/")]
        [Route("/signin", Name = "appsignin")]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        [Route("/")]
        [Route("/signin", Name = "appsignin")]
        public async Task<IActionResult> SignIn(LogInRequest request)
        {
            var response = await _subscriptionProvider.UserLogIn(request);
            if (response.success)
            {
                await ConfigureIdentity(response,false);
                return RedirectToRoute("appdashboard");
            }
                
            ViewBag.ValidationMessage = response.error;

            return View(request);
        }

        [Route("/signout", Name = "appsignout")]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToRoute("appsignin");
        }

        [Route("/register", Name = "appregister")]
        public async Task<IActionResult> Register()
        {
            return View();
        }

        [HttpPost]
        [Route("/register", Name = "appregisterr")]
        public async Task<IActionResult> Register(int i)
        {
            return View();
        }

        #region Private Region

        private async Task<bool> ConfigureIdentity(LogInResponse tempAuth, bool RememberMe = false)
        {
            var identityManager = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
            identityManager.AddClaim(new Claim(ClaimTypes.Email, tempAuth.data.email));
            identityManager.AddClaim(new Claim(ClaimTypes.Name, tempAuth.data.firstName));
            identityManager.AddClaim(new Claim(ClaimTypes.Actor, tempAuth.data.id.ToString()));

            var principleIdentity = new ClaimsPrincipal(identityManager);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principleIdentity, new AuthenticationProperties()
            {
                IsPersistent = RememberMe,
                IssuedUtc = DateTime.Now,
                ExpiresUtc = DateTime.Now.AddMonths(1)
            });

            return true;
        }

        #endregion
    }
}
