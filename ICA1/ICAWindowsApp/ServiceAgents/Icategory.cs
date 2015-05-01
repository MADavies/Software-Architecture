using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ICAWindowsApp.Model;

namespace ICAWindowsApp.ServiceAgents
{
    interface Icategory
    {
        Task<IEnumerable<CategoryDTO>> GetCategory();

    }
}
