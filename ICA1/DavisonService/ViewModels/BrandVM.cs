using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace DavisonService.ViewModels
{
    public class BrandVM
    {
        public virtual int Id { get; set; }
        [Display(Name = "Brand Name")]
        public virtual string Name { get; set; }
        public virtual bool Active { get; set; }
    }
}