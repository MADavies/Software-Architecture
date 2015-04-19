using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;
using UnderCutters_Service.UnderCutters_Proxy;

namespace UnderCutters_Service.Respositories
{
    /**
     * Handles data brought back by UnderCutters web service proxy
     * 
     */
    public class UnderCuttersRepository : IUnderCuttersRepository, IDisposable
    {

        public IEnumerable<Base> AccessWebData()
        {

            return null;
        }

        public IEnumerable<Base> GetAllProducts()
        {
            UnderCuttersProxy proxy = new UnderCuttersProxy();
            IEnumerable<Product> underCuttersProducts = proxy.getUnderCuttersProducts(null);
            if (underCuttersProducts != null)
            {
                return underCuttersProducts;
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