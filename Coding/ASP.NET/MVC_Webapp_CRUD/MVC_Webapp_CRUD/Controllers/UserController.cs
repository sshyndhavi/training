using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_Webapp_CRUD.Models;
namespace MVC_Webapp_CRUD.Controllers
{
    public class UserController : Controller
    {
        ServicesContext db = new ServicesContext();
        // GET: User
        public ActionResult Index()
        {
            var data = db.user.ToList();
            return View(data);
        }
    }
}