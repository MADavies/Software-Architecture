using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace UnderCutters_Service.Respositories
{
    interface IUnderCuttersRepository
    {
        IEnumerable<Base> GetAllProducts();

        Base GetProduct(int id);
    }
}