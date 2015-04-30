using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using ViewModels;

namespace ICA1WebApplication.Controllers
{
    public class BrandController : Controller
    {
        public ActionResult Index()
        {
            var brands = new List<BrandVM>().AsEnumerable(); // why do this?
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:15063/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
            HttpResponseMessage response = client.GetAsync("api/brand").Result;
            if (response.IsSuccessStatusCode)
            {
                brands = response.Content.ReadAsAsync<IEnumerable<BrandVM>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
            }
            return View(brands);
        }

    }
}