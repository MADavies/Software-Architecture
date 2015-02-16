using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity.ModelConfiguration;
using DavisonService.Respositories;
using System.Web.Http.Description;
using DavisonModel;

namespace DavisonService.Controllers
{
    public class ProductController : ApiController
    {
        private ProductRepository productRepository = new ProductRepository();

        // GET http://localhost:15785/api/product/5
        [ResponseType(typeof(DavisonService.ViewModels.ProdVM))]
        public IHttpActionResult GetProduct(int id)
        {
            ViewModels.ProdVM product = productRepository.GetAll()
            .Where(p => p.Id == id)
            .Select(p => new ViewModels.ProdVM
            {
                Id = p.Id,
                EAN = p.EAN,
                CategoryId = p.CategoryId,
                BrandId = p.BrandId,
                Name = p.Name,
                Description = p.Description,
                Price = p.Price,
                StockLevel = p.StockLevel,
                Active = p.Active,
                Category = p.Category,
                Brand = p.Brand
            }).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }
    }
}
