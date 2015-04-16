using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace BazzarsBazzar_Service.Repositories
{
    interface IBazzarsBazzarRepository
    {
        IEnumerable<Base> GetAllProducts();
    }
}