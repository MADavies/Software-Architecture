using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DavisonService.Respositories;
using System.Web.Http.Description;
using ViewModels;
using DavisonService.CompareClasses;

namespace DavisonService.Controllers
{
    public class CategoryController : ApiController
    {
        private DavisonRepository davisonRepository = new DavisonRepository();
        private UnderCuttersRepository underCuttersRepository = new UnderCuttersRepository();
        private BazzasBazzarRepository bazzasBazzarRepository = new BazzasBazzarRepository();

        // GET http://localhost:15063/api/category/
        [ResponseType(typeof(CatVM))]
        public IEnumerable<CatVM> GetCategories()
        {
            var allCategories = new List<CatVM>().AsEnumerable();
            var filteredCategories = new List<CatVM>().AsEnumerable();

            var davisonCategories = davisonRepository.GetAllCat()
                .Select(c => new CatVM
                {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                }).AsEnumerable();

            var underCuttersCategories = underCuttersRepository.GetAllCat()
                .Select(c => new CatVM
                {
                    Id = c.Id,
                    Name = c.Name,
                    Active = c.Active,
                }).AsEnumerable();

            var bazzasCategories = bazzasBazzarRepository.GetAllCat();

            allCategories = davisonCategories.Concat(underCuttersCategories);

            allCategories = allCategories.Concat(bazzasCategories);

            filteredCategories = allCategories.Distinct(new CategoryComparer());

            return filteredCategories;
        }
    }
}
