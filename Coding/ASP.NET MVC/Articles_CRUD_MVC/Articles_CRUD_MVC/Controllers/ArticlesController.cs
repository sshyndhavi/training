using Articles_CRUD_MVC.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;

namespace Articles_CRUD_MVC.Controllers
{
    public class ArticlesController : Controller
    {
        // GET: Articles
        public ActionResult Index()
        {
           
            
                ArticleModel model = new ArticleModel();
                DataTable dt = model.GetAllArticles();
                
            

            return View("Home",dt);
        }
        public ActionResult Insert()
        {
            return View("Create");
        }
        public ActionResult InsertRecord(FormCollection frm, string action)
        {
            if (action == "Submit")
            {
                ArticleModel model = new ArticleModel();
    
                int articleid = Convert.ToInt32(frm["articleid"]);
                string title = frm["title"];
                string content = frm["content"];
                int status = model.InsertArticle(articleid,title,content);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            }
        }

    }
}