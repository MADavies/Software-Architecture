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
    public class BrandController : ApiController
    {
        //private  BrandRepository brandRepository = new BrandRepository();

        // GET http://localhost:14584/api/brand/
        //[ResponseType(typeof(DavisonModel.Brand))]
        //public IEnumerable<Brand> GetBrands()
        //{
        //    return brandRepository.GetAll().Select(b => new Brand
        //    {
        //        Id = b.Id,
        //        Name = b.Name,
        //        Active = b.Active
        //    }).AsEnumerable();

        //    Brand brand = brandRepository.GetAll()
        //    .Select(b => new Brand
        //    {
        //        Id = b.Id,
        //        Name = b.Name,
        //        Active = b.Active
        //    }).AsEnumerable();
        //    if (brand == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(brand);
        //}
    }
}
