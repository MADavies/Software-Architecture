using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace UnderCutters_Service.Controllers
{
    public class UnderCuttersWebAPIController : ApiController
    {
        // GET: api/UnderCuttersWebAPI
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/UnderCuttersWebAPI/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UnderCuttersWebAPI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/UnderCuttersWebAPI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/UnderCuttersWebAPI/5
        public void Delete(int id)
        {
        }
    }
}
