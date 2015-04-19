using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;
using System.Diagnostics;
using System.Net.Http;

namespace DodgyDealers_Service.DodgyDealers_Proxy
{
    /**
     * Dodgy Dealers Webservice Proxy, gets data from Dodgy Dealers web service. 
     */
    public class DodgyDealersProxy
    {
        private HttpClient client;

        /**
         * Dodgy Dealers Proxy Constructor
         */ 
        public DodgyDealersProxy()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri("http://dodgydealers.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");
        }

    /**
     * Makes a Http Request to the Dodgy Dealers service to return product data.
     * Will return all data on products or data of a single product.
     */
        public IEnumerable<Product> getDodgyDealersProducts(int? id)
        {
            HttpResponseMessage response;

            if (id != null)
            {
                response = client.GetAsync("api/product/" + id).Result;

            }
            else
            {
                response = client.GetAsync("api/product").Result;
            }

            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync<IEnumerable<Product>>().Result;
            }
            else
            {
                Debug.WriteLine("Dodgy Dealers Proxy received a bad response " + response.StatusCode.ToString());
                return null;
            }
        }
    }

    
}