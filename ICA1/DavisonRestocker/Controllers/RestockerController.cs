using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Davison;



namespace DavisonRestocker.Controllers
{
    public class RestockerController : ApiController
    {
        private readonly Davison.Stocker.Stocker restocker;

        //Constructor
        public RestockerController()
        {
            restocker = new Davison.Stocker.Stocker();

        }

        // GET api/Restocker/{id}
        public Davison.Stocker.Product Get(string id)
        {
            return restocker.GetProduct(id);
        }

    }
}
