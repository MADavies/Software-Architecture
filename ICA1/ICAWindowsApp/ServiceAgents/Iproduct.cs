using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICAWindowsApp.Model;

namespace ICAWindowsApp.ServiceAgents
{
    interface Iproduct
    {

        Task<IEnumerable<ProductDTO>> GetProduct();
    }
}
