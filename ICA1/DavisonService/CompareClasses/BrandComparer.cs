using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonService.ViewModels;

namespace DavisonService.CompareClasses
{
    public class BrandComparer : IEqualityComparer<BrandVM>
    {
        public bool Equals(BrandVM x, BrandVM y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(BrandVM obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}