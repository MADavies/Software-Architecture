using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DavisonService.CompareClasses;
using ViewModels;

namespace DavisonService.Test.Comparer
{
    /// <summary>
    /// Summary description for ComparerTests
    /// </summary>
    [TestClass]
    public class ComparerTests
    {
        public ComparerTests()
        {
           
        }

        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void ProductCompare()
        {
            ProductComparer pc = new ProductComparer();
            ProdVM p1 = new ProdVM();
            ProdVM p2 = new ProdVM();

            p1.Id = 10;
            p1.Name = "franks Skin";
            p1.EAN = "23765273873";

            p2.Id = 10;
            p2.Name = "franks Skin";
            p2.EAN = "23765273873";

            Assert.IsTrue(pc.Equals(p1, p2));

        }

        [TestMethod]
        public void BrandCompare()
        {
            BrandComparer bc = new BrandComparer();
            BrandVM b1 = new BrandVM();
            BrandVM b2 = new BrandVM();

            b1.Id = 5;
            b1.Name = "Bobbers";

            b2.Id = 5;
            b2.Name = "Bobbers";

            Assert.IsTrue(bc.Equals(b1, b2));
        }

        [TestMethod]
        public void CategoryCompare()
        {
            CategoryComparer cc = new CategoryComparer();
            CatVM c1 = new CatVM();
            CatVM c2 = new CatVM();

            c1.Id = 1;
            c1.Name = "Squish";

            c2.Id = 1;
            c2.Name = "Squish";

            Assert.IsTrue(cc.Equals(c1, c2));
        }
    }
}
