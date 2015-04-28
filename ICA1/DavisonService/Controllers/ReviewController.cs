using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using DavisonService.Respositories;
using System.Web.Http.Description;
using DavisonService.ViewModels;

namespace DavisonService.Controllers
{
    public class ReviewController : ApiController
    {
        private ReviewRepository rRepository = new ReviewRepository();

        // GET: Review
        [ResponseType(typeof(ReviewVM))]
        public IEnumerable<ReviewVM> GetReviews()
        {

            var reviews = rRepository.GetAllReviews();

            return reviews;
        }
    }
}