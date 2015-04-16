using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonModel;

namespace UnderCutters_Service.Respositories
{
    public class UnderCuttersRepository : IUnderCuttersRepository, IDisposable
    {
        public IEnumerable<Base> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}