using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DavisonService.Respositories;
using Davison.Model;

namespace DavisonService.Test.Repositories
{
    /// <summary>
    /// Summary description for DavisonRepoTest
    /// </summary>
    [TestClass]
    public class DavisonRepoTest
    {
        private DavisonRepository repo = new DavisonRepository();
        public DavisonRepoTest()
        {
            
        }

        [TestMethod]
        public void GetAllProductsTest()
        {
            var results = repo.GetAllProducts();

            Assert.IsNotNull(results);

        }
    }
}
