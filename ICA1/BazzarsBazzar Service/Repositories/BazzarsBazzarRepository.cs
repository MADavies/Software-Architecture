using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace BazzarsBazzar_Service.Repositories
{
    public class BazzarsBazzarRepository : IBazzarsBazzarRepository, IDisposable
    {
        public string WebApiUrl = "http://bazzasbazaar.cloudapp.net/Store.svc";

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