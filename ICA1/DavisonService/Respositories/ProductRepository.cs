using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using DavisonModel;

namespace DavisonService.Respositories
{
    public class ProductRepository : IProductRepository
    {
        private StoreDb db = new StoreDb();
        public IEnumerable<Product> GetAll()
        {
            var products = db.Products.Where(p => p.Active).ToList();
            return products;
        }
        public IEnumerable<Product> GetAllFiltered(TypeEnum? type, int? id)
        {
            IEnumerable<Product> products =
                db.Products.Where(p => p.Brand.Active && p.Active)
                    .Include(b => b.Brand)
                    .Where(s => s.Category.Active && s.Active)
                    .Include(c => c.Category);

            if (id != null)
            {
                if (type == TypeEnum.Brand)
                {
                    products = db.Products.Where(b => b.BrandId == id).ToList();
                }
                else if (type == TypeEnum.Category)
                {
                    products = db.Products.Where(c => c.CategoryId == id).ToList();
                }
            }
            return products;
        }
        public Product GetDetails(int? id)
        {
            var products = db.Products.Find(id);
            return products;
        }
    }
}