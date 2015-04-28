using System.Collections.Generic;
using System.Net.Http;
using System.Diagnostics;
using Davison.Model;

namespace DavisonService.Respositories
{
    public class UnderCuttersRepository : IRepository
    {
        private HttpClient client;

        public UnderCuttersRepository()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri("http://under-cutters.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        }

        public IEnumerable<Product> GetAllProducts()
        {
            HttpResponseMessage response = client.GetAsync("api/product").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

        public IEnumerable<Product> GetAllFiltered(TypeEnum? type, int? id)
        {
            HttpResponseMessage response = client.GetAsync("api/product/" + type + "/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

        public Product GetProductDetails(string ean)
        {
            HttpResponseMessage response = client.GetAsync("api/product/" + ean).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Product>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

        public IEnumerable<Category> GetAllCat()
        {
            HttpResponseMessage response = client.GetAsync("api/category").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Category>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

        public Category GetCatDetails(int? id)
        {
            HttpResponseMessage response = client.GetAsync("api/category/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Category>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

        public IEnumerable<Brand> GetAllBrand()
        {
            HttpResponseMessage response = client.GetAsync("api/brand").Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Brand>>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

        public Brand GetBrandDetails(int? id)
        {
            HttpResponseMessage response = client.GetAsync("api/brand/" + id).Result;
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<Brand>().Result;
            }
            else
            {
                Debug.WriteLine("Index received a bad response from the web service.");
                return null;
            }
        }

    }
}