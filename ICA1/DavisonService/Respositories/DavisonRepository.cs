using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using Davison.Model;

namespace DavisonService.Respositories
{
    public class DavisonRepository : IRepository
    {
        private Context db = new Context();
        public IEnumerable<Product> GetAllProducts()
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
        public Product GetProductDetails(string ean)
        {
            var product = db.Products.Where(p => p.Ean == ean).FirstOrDefault();
            return product;
        }

        public IEnumerable<Category> GetAllCat()
        {
            var categories = db.Categories.Where(c => c.Active).ToList();
            return categories;
        }

        public Category GetCatDetails(int? id)
        {
            var category = db.Categories.Find(id);
            return category;
        }

        public IEnumerable<Brand> GetAllBrand()
        {
            var brands = db.Brands.Where(b => b.Active).ToList();
            return brands;
        }

        public Brand GetBrandDetails(int? id)
        {
            var brand = db.Brands.Find(id);
            return brand;
        }
    }
}