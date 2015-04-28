using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DavisonService.Respositories;
using System.Web.Http.Description;
using DavisonService.ViewModels;
using DavisonService.CompareClasses;

namespace DavisonService.Controllers
{
    public class BrandController : ApiController
    {
        private DavisonRepository davisonRepository = new DavisonRepository();
        private UnderCuttersRepository underCuttersRepository = new UnderCuttersRepository();

        // GET http://localhost:14584/api/brand/
        [ResponseType(typeof(BrandVM))]
        public IEnumerable<BrandVM> GetBrands()
        {
            var allBrands = new List<BrandVM>().AsEnumerable();
            var filteredBrands = new List<BrandVM>().AsEnumerable();

            var davisonBrands = davisonRepository.GetAllBrand().Select(b => new BrandVM
            {
                Id = b.Id,
                Name = b.Name,
                Active = b.Active
            }).AsEnumerable();

            var underCuttersBrands = underCuttersRepository.GetAllBrand().Select(b => new BrandVM
            {
                Id = b.Id,
                Name = b.Name,
                Active = b.Active
            }).AsEnumerable();

            allBrands = davisonBrands.Concat(underCuttersBrands);

            filteredBrands = allBrands.Distinct(new BrandComparer());

            return filteredBrands;
        }
    }
}
