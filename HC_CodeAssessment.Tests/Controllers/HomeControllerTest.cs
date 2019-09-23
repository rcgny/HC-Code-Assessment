using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HC_CodeAssessment;
using HC_CodeAssessment.Controllers;

namespace HC_CodeAssessment.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
