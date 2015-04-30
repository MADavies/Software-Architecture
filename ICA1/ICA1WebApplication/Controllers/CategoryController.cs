using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web.Mvc;
using ViewModels;

namespace ICA1WebApplication.Controllers
{
    public class CategoryController : Controller
    {
        public ActionResult Index()
        {
            var catergories = new List<CatVM>().AsEnumerable();
            HttpClient client = new HttpClient();
            client.BaseAddress = new System.Uri("http://localhost:15063/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
            HttpResponseMessage response = client.GetAsync("api/category").Result;
            if (response.IsSuccessStatusCode)
            {
                catergories = response.Content.ReadAsAsync<IEnumerable<CatVM>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
            }

            return View(catergories);
        }

    }
}