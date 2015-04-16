using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace DodgyDealers_Service.Repositories
{
    interface IDodgyDealersRepository
    {
        IEnumerable<Base> GetAllProducts();

        Base GetProduct(int id);
    }
}