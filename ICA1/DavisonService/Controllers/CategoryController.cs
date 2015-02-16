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
using System.Web.Script.Serialization;

namespace DavisonService.Controllers
{
    public class CategoryController : ApiController
    {
        private CategoryRepository categoryRepository = new CategoryRepository();

        // GET http://localhost:15063/api/category/5
        //[ResponseType(typeof(ViewModels.CatVM))]
        //public IHttpActionResult GetCategory()
        //{ //this needs to return the full list of categories
        //    ViewModels.CatVM categories = categoryRepository.GetAll()
        //    .Select(c => new ViewModels.CatVM()).FirstOrDefault();
        //    var jsonSerialiser = new JavaScriptSerializer();
        //    var json = jsonSerialiser.Serialize(categories);
        //    if (json == null)
        //    {
        //        return NotFound();
        //    }
        //    return Ok(json);
        //}

    }
}
