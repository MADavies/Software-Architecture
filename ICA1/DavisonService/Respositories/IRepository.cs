using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Davison.Model;

namespace DavisonService.Respositories
{
    interface IRepository
    {
        IEnumerable<Product> GetAllProducts();
        IEnumerable<Product> GetAllFiltered(TypeEnum? type, int? id);
        Product GetProductDetails(int? id);
        IEnumerable<Category> GetAllCat();
        Category GetCatDetails(int? id);
        IEnumerable<Brand> GetAllBrand();
        Brand GetBrandDetails(int? id);
    }
}