using Microsoft.VisualStudio.TestTools.UnitTesting;
using QuiryForum.Controllers;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuiryForum.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        [TestMethod()]
        public void Index_ReturnsViewResults()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.IsNotNull(result);

        }
    }
}