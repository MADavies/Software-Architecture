using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using DavisonModel;

namespace ICA1WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private StoreDb db = new StoreDb();

        // GET: Product
        public ActionResult Index(TypeEnum? type, int? id)
        {
            var products = GetProducts(type, id);

            return View(products.ToList());
        }

        public IEnumerable<Product> GetProducts(TypeEnum? type, int? id)
        {
            IEnumerable<Product> products =
                db.Products.Where(p => p.Brand.Active && p.Active)
                    .Include(b => b.Brand)
                    .Where(s => s.Category.Active && s.Active)
                    .Include(c => c.Category);

            if (id != null)
            {
                if (type == TypeEnum.Brand)
                {
                    products = db.Products.Where(b => b.BrandId == id).ToList();
                }
                else if (type == TypeEnum.Category)
                {
                    products = db.Products.Where(c => c.CategoryId == id).ToList();
                }
            }
            return products;
        }

        // GET: Category/Details/5
        public ActionResult Details(int? id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }
    }
}