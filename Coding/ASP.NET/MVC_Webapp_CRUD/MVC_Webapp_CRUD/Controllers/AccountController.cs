using MVC_Webapp_CRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_Webapp_CRUD.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User user) 
        {
            using (DBEntities db = new DBEntities())
            {
               var result= db.UserMasters.FirstOrDefault (x => x.UserId == user.UserName && x.Password == user.Password);
              
                if ( result != null)
                {
                    //Session["userid"] = user.UserName;
                    FormsAuthentication.SetAuthCookie(user.UserName, false);
                    return RedirectToAction ("Index","Home");
                }
                else
                {
                    TempData["msg"] = "Incorrect UserId/Password";
                }
            }
            return View();        
        }
        
        public ActionResult Logout()
        {   
            Session.Clear();
            Session.Abandon();
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }
    }
}