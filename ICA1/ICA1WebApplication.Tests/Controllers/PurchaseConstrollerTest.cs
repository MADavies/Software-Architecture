using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ICA1WebApplication.Controllers;
using System.Web.Mvc;

namespace ICA1WebApplication.Tests.Controllers
{
    [TestClass]
    public class PurchaseConstrollerTest
    {
        [TestMethod]
        public void Purchase()
        {
            //Arrange
            PurchaseController controller = new PurchaseController();

            //Act
            ViewResult result = controller.Index() as ViewResult;

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
