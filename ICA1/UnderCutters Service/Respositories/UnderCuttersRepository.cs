using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;
using UnderCutters_Service.UnderCutters_Proxy;

namespace UnderCutters_Service.Respositories
{
    /**
     * Repository that handles the retreival of data 
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
            IEnumerable<Base> underCuttersProducts = proxy.getUnderCuttersProducts();
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