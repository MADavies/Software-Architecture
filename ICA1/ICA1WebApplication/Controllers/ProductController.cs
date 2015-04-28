using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Security.AccessControl;
using System.Web.Mvc;
using DavisonService.ViewModels;

namespace ICA1WebApplication.Controllers
{
    public class ProductController : Controller
    {
        private HttpClient client;

        public ProductController()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:15063/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        }

        // GET: Product
        public ActionResult Index()
        {
            var products = new List<ProdVM>().AsEnumerable();
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

        //public ActionResult Details(string ean)
        //{
        //    var products = new List<ProdVM>().AsEnumerable();
        //    HttpResponseMessage response = client.GetAsync("api/product/" + ean).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        products = response.Content.ReadAsAsync<IEnumerable<ProdVM>>().Result;
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Index received a bad response from the web service.");
        //    }
        //    return View(products);
        //}
    }
}