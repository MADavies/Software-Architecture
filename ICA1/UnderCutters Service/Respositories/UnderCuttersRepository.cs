using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace UnderCutters_Service.Respositories
{
    /**
     * Repository that handles the retreival of data 
     * 
     */
    public class UnderCuttersRepository : IUnderCuttersRepository, IDisposable
    {
        public string WebApiUrl = "http://undercutters.azurewebsites.net/";

        public IEnumerable<Base> AccessWebData()
        {

            return null;
        }

        public IEnumerable<Base> GetAllProducts()
        {
            throw new NotImplementedException();
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