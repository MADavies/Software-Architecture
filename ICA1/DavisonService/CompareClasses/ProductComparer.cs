using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DavisonService.ViewModels;

namespace DavisonService.CompareClasses
{
    public class ProductComparer : IEqualityComparer<ProdVM>
    {
        public bool Equals(ProdVM x, ProdVM y)
        {
            return x.EAN.Equals(y.EAN);
        }

        public int GetHashCode(ProdVM obj)
        {
            return obj.EAN.GetHashCode();
        }
    }
}