using DavisonService.Models;
using DavisonService.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace DavisonService.Controllers
{
    public class OrderController : ApiController
    {
        private UnderCuttersRepository underCuttersRepository = new UnderCuttersRepository();

        // GET: api/Order
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Order/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Order
        [ResponseType(typeof(Order))]
        public Order Post([FromBody]OrderRequest o)
        {
            return underCuttersRepository.PostOrder(o);
        }

        // PUT: api/Order/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Order/5
        public void Delete(int id)
        {
        }
    }
}
