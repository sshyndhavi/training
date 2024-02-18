using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace log4net.Controllers
{
    public class HomeController : Controller
    {
        private ILog Logger = LogManager.GetLogger(typeof (HomeController));
        public ActionResult Index()
        {
            try
            {
                throw new Exception("Test");
            }
            catch(Exception ex)
            {
                Logger.Error("Error:",ex);
            }
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
    }
}