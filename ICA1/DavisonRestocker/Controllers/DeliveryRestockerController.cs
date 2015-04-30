using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Davison;
using System.Threading.Tasks;

namespace DavisonRestocker.Controllers
{
    public class DeliveryRestockerController : ApiController
    {
        private readonly Davison.Stocker.Stocker restocker;

        //Constructor
        public DeliveryRestockerController()
        {
            restocker = new Davison.Stocker.Stocker();
        }

        // GET api/DeliveryRestocker
        public IEnumerable<Davison.Stocker.Delivery> GetDelivery(string id)
        {
            return restocker.QueryDeliveriesByProduct(id);
        }

        //POST: api/DeliveryRestocker
        public async Task<bool> confirm([FromBody] Davison.Stocker.Delivery delivery) 
        {
            restocker.ConfirmDeliveryForProduct(delivery.Id);
            return true;
        }

        // GET: api/DeliveryRestocker
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DeliveryRestocker/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DeliveryRestocker
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DeliveryRestocker/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DeliveryRestocker/5
        public void Delete(int id)
        {
        }
    }
}
