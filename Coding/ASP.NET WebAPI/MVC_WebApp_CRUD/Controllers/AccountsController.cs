using MVC_WebApp_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Xml;

namespace MVC_WebApp_CRUD.Controllers
{
    public class AccountsController : Controller
    {
        private readonly DBEntities db = new DBEntities();

        [HttpGet]

        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user)
        {
                var res = db.UserMasters.Where(a=> a.UserId==user.UserName && a.Password==user.Password);
                if(res.Count()!=0)
                {
                    Session["UserId"] = user.UserName;
                    return RedirectToAction("Index","Home");

                }
                else
                {
                    TempData["ErrorMsg"] = "Invalid UserId or Password";
                }

            





            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return View("Login");
        }
    }
}