using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ViewModels;

namespace DavisonService.CompareClasses
{
    public class CategoryComparer : IEqualityComparer<CatVM>
    {
        public bool Equals(CatVM x, CatVM y)
        {
            return x.Name.Equals(y.Name);
        }

        public int GetHashCode(CatVM obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}