using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ASP.NET_CORE_DEMO.Controllers
{
    public class TodosController : Controller
    {
        private static List<TodoItem> _todoItems = new List<TodoItem>();
        public IActionResult Index()
        {
            return View(_todoItems);
        }

        [HttpPost]
        public IActionResult Add(string title)
        {
            var todoItem = new TodoItem { Id = _todoItems.Count + 1, Title = title, IsDone = false };
            _todoItems.Add(todoItem);
            return RedirectToAction("Index");
        }
    }
}


   
   