using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SocialService.ViewModel
{
    public class ReviewVM
    {
        public virtual int Id { get; set; }
        public virtual int Rating { get; set; }
        public virtual string Description { get; set; }
    }
}