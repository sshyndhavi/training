using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Integgrated_Authentication.Controllers
{
   
    public class HomeController : Controller
    {
        [OutputCache(Duration = 3600)]
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();

        }
        public ActionResult HandleError() 
        {
            return View();
        }
    }
}