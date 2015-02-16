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
    public class BrandController : Controller
    {
        private StoreDb db = new StoreDb();
        public ActionResult Index()
        {
            //var brands = new List<Brand>().AsEnumerable(); // why do this?
            //HttpClient client = new HttpClient();
            //client.BaseAddress = new System.Uri("http://localhost:14584/");
            //client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
            //HttpResponseMessage response = client.GetAsync("api/brand").Result;
            //if (response.IsSuccessStatusCode)
            //{
            //    brands = response.Content.ReadAsAsync<IEnumerable<Brand>>().Result;
            //}
            //else
            //{
            //    Debug.WriteLine("Index received a bad response from the web service.");
            //}
            //return View(brands);
            var brands = db.Brands.Where(b => b.Active).ToList();
            return View(brands);
        }

        // GET: Brand/Details/5
        public ActionResult Details(int? id)
        {
            Brand brand = db.Brands.Find(id);
            if (brand == null)
            {
                return HttpNotFound();
            }
            return View(brand);
        }
    }
}