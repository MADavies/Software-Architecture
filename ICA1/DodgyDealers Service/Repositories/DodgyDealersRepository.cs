using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace DodgyDealers_Service.Repositories
{
    public class DodgyDealersRepository : IDodgyDealersRepository, IDisposable
    {
        public string WebApiUrl = "http://dodgydealers.azurewebsites.net/";

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