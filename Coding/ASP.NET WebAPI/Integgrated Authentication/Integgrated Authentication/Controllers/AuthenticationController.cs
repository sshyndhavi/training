using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;

namespace Integgrated_Authentication.Controllers
{
    public class AuthenticationController : Controller
    {
        // GET: Authentication
        
        
            public IActionResult Login(string returnUrl = "/")
            {
                var properties = new AuthenticationProperties { RedirectUri = returnUrl };
                return Challenge(properties, "Google");
            }

        private IActionResult Challenge(AuthenticationProperties properties, string v)
        {
            throw new NotImplementedException();
        }

        public IActionResult Logout()
            {
                return SignOut("Cookies", "Google");
            }

        private IActionResult SignOut(string v1, string v2)
        {
            throw new NotImplementedException();
        }
    }

    public interface IActionResult
    {
    }
}



