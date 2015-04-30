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

        // POST: api/Order
        [ResponseType(typeof(Order))]
        public Order Post([FromBody]OrderRequest o)
        {
            return underCuttersRepository.PostOrder(o);
        }


    }
}
