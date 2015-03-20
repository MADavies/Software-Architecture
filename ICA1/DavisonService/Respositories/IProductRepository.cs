using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DavisonModel;

namespace DavisonService.Respositories
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllFiltered(TypeEnum? type, int? id);
        Product GetDetails(int? id);
    }
}
