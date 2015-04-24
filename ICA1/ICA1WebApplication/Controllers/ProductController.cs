using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
//using Davison.Model;
using DavisonService.ViewModels;

namespace ICA1WebApplication.Controllers
{
    public class ProductController : Controller
    {
        //private Context db = new Context();

        // GET: Product
        public ActionResult Index()
        {
            var products = new List<ProdVM>().AsEnumerable();
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:15063/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
            HttpResponseMessage response = client.GetAsync("api/product").Result;
            if (response.IsSuccessStatusCode)
            {
                products = response.Content.ReadAsAsync<IEnumerable<ProdVM>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
            }
            return View(products);

        }

        // GET: Category/Details/5
        //public ActionResult Details(int? id)
        //{
        //    Product product = db.Products.Find(id);
        //    if (product == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(product);
        //}
    }
}