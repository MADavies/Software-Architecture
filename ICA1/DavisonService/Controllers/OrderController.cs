using ViewModels;
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
        private DavisonRepository davisonRepository = new DavisonRepository();
        private UnderCuttersRepository underCuttersRepository = new UnderCuttersRepository();
        //private BazzasBazzarRepository bazzasBazzarRepository = new BazzasBazzarRepository();

        // POST: api/Order
        [ResponseType(typeof(Order))]
        public Order Post([FromBody]OrderRequest o)
        {
            switch (o.VendorID)
            {
                case 1:
                    return davisonRepository.PostOrder(o);
                    break;
                case 2:
                    return underCuttersRepository.PostOrder(o);
                    break;
                case 3:
                    //return bazzasBazzarRepository.PostOrder(o);
                    break;
            }
                   return null;
        }
    }
}
