using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using DavisonModel;

namespace ICA1WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        private StoreDb db = new StoreDb();
        public ActionResult Index()
        {
            var categories = db.Categories.Where(c => c.Active).ToList();
            return View(categories);
        }

        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            Category category = db.Categories.Find(id);
            if (category == null)
            {
                return HttpNotFound();
            }
            return View(category);
        }
    }
}