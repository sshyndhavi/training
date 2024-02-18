using System;

namespace CustomAuthentication_mvc.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
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