using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using DavisonModel;

namespace DavisonService.Respositories
{
    public class BrandRepository : IBrandRepository
    {
        private StoreDb db = new StoreDb();
        
        public IEnumerable<Brand> GetAll()
        {
            var brands = db.Brands.Where(b => b.Active).ToList();
            return brands;
        }

        public Brand GetDetails(int? id)
        {
            var brand = db.Brands.Find(id);
            return brand;
        }
    }
}