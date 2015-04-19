using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;
using DodgyDealers_Service.DodgyDealers_Proxy;

namespace DodgyDealers_Service.Repositories
{
    /**
     * Handles data brought back from Dodgy Dealers webservice proxy
     */ 
    public class DodgyDealersRepository : IDodgyDealersRepository, IDisposable
    {
        

        public IEnumerable<Base> GetAllProducts()
        {
            DodgyDealersProxy proxy = new DodgyDealersProxy();
            IEnumerable<Product> dodgyDealersProducts = proxy.getDodgyDealersProducts(null);
            if (dodgyDealersProducts != null)
            {
                return dodgyDealersProducts;
            }
            else
            {
                return null;
            }
        }

        public Base GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}