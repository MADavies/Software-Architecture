using SocialService.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialService.Repository
{
    public class ReviewRepository
    {
        public IEnumerable<ReviewVM> GetAllReviews()
        {
            var courses = new List<ReviewVM>
            {
            new ReviewVM{Id=1, Rating=5, Description="Very Good"},
            new ReviewVM{Id=2, Rating=2, Description="ok"},
            new ReviewVM{Id=3, Rating=4, Description="Good"},
            new ReviewVM{Id=4, Rating=1, Description="Very Bad"},

            };
            return courses;

        }
    }
}