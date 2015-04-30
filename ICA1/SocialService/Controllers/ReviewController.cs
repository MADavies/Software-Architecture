using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;
using SocialService.Repositories;
using SocialService.ViewModels;

namespace SocialService.Controllers
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