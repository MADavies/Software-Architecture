using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavisonModel;

namespace DavisonService.Respositories
{
    interface IBrandRepository
    {
        IEnumerable<Brand> GetAll();
        Brand GetDetails(int? id);
    }
}
