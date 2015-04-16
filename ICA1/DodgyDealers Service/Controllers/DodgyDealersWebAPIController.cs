using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DodgyDealers_Service.Controllers
{
    public class DodgyDealersWebAPIController : ApiController
    {
        // GET: api/DodgyDealersWebAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/DodgyDealersWebAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/DodgyDealersWebAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/DodgyDealersWebAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/DodgyDealersWebAPI/5
        public void Delete(int id)
        {
        }
    }
}
