using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using DavisonModel;

namespace DavisonService.Respositories
{
    interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category GetDetails(int? id);
    }
}
