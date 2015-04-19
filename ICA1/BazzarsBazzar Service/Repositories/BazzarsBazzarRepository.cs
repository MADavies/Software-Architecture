using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;
using BazzarsBazzar_Service.BazzasBazzarWCFService;

namespace BazzarsBazzar_Service.Repositories
{
    /**
     * Handles data brought back from BazzasBazzar WCF Service
     */ 
    public class BazzarsBazzarRepository : IBazzarsBazzarRepository, IDisposable
    {

        public IEnumerable<DavisonModel.Product> GetAllProducts()
        {
            StoreClient BazzarsClient = new StoreClient();
            BazzasBazzarWCFService.Product BazzasProducts = BazzarsClient.GetProductById(0);
            BazzarsClient.Close();
            return (IEnumerable<DavisonModel.Product>) BazzasProducts;
            
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