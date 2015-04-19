using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using DavisonModel;
using System.Diagnostics;

namespace UnderCutters_Service.UnderCutters_Proxy
{
    /**
     * UnderCutters Webservice Proxy, gets data from Undercutters webs ervice and passes it onto the repository. 
     */
    public class UnderCuttersProxy
    {
        private HttpClient client;

        /**
         * Undercutters proxy constructor. 
         */
        public UnderCuttersProxy()
        {
            client = new HttpClient();
            client.BaseAddress = new System.Uri("http://undercutters.azurewebsites.net/");
            client.DefaultRequestHeaders.Accept.ParseAdd("application/json");

        }

        /**
         * Makes a Http Request to the undercutters service to return product data.
         * Will return all data on products or data of a single product.
         */
        public IEnumerable<Product> getUnderCuttersProducts(int? id)
        {
            HttpResponseMessage response;

            if (id != null)
            {
                response = client.GetAsync("Api/product/" + id).Result;
            } 
            else 
            {
                response = client.GetAsync("Api/product").Result;
            }
            
            if (response.IsSuccessStatusCode)
            {
                return response.Content.ReadAsAsync <IEnumerable<Product>>().Result;
            }
            else
            {
                Debug.WriteLine("UnderCutters Proxy received a bad response " + response.ToString());
                return null;
            }
        }
    
    }
}