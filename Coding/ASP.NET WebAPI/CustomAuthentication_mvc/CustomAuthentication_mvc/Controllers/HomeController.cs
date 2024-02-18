using System;

namespace CustomAuthentication_mvc.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        private ActionResult View()
        {
            throw new NotImplementedException();
        }
    }
}