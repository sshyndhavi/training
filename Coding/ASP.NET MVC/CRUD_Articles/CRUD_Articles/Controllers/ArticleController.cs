using CRUD_Articles.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Articles.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Home()
        {
            ArticleModel model = new ArticleModel();
            DataTable dt = model.GetAllArticles();
            return View("Home",dt);
        }
        public ActionResult InsertArticle(FormCollection frm,string action)
        {
            if (action == "Submit")
            {
                ArticleModel model = new ArticleModel();
 
                string Title = frm["Title"];
                string Content = frm["content"];
                string PublishedDate = frm["PublishedDate"];
                string LastModifiedDate = frm["LastModifiedDate"];
                int AuthorId = Convert.ToInt32(frm["AuthorId"]);
                int CategoryId = Convert.ToInt32(frm["CategoryId"]);
                int status = model.InsertArticle(Title, Content, PublishedDate,LastModifiedDate,AuthorId,CategoryId) ;
                return RedirectToAction("Home");
            }
            else
            {
                return RedirectToAction("Home");
            }
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }
        public ActionResult UpdateArticle(FormCollection frm, string action)
        {
            if (action == "Submit")
            {
                ArticleModel model = new ArticleModel();
                int ArticleId = Convert.ToInt32(frm["ArticleId"]);
                string Title = frm["Title"];
                string Content = frm["content"];
                string PublishedDate = frm["PublishedDate"];
                string LastModifiedDate = frm["LastModifiedDate"];
                int AuthorId = Convert.ToInt32(frm["AuthorId"]);
                int CategoryId = Convert.ToInt32(frm["AuthorId"]);

                int status = model.UpdateArticle(ArticleId,Title, Content, PublishedDate, LastModifiedDate, AuthorId, CategoryId);
                return RedirectToAction("Home");
            }
            else
            {
                return RedirectToAction("Home");
            }
            
        }
        public ActionResult Delete(int ArticleId)
        { ArticleModel model = new ArticleModel();
            model.DeleteArticle(ArticleId);
            return RedirectToAction("Home");
        }
        [HttpGet]
        public ActionResult Edit()
        {
            return View("Edit");
        }
        public ActionResult Edit(int StudentID)
        {
            ArticleModel model = new ArticleModel();
            DataTable dt = model.GetArticleByArticleId((StudentID));
            return View("Edit", dt);
        }

    }


}
