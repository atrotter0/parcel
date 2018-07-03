using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ParcelsProject.Controllers;
using ParcelsProject.Models;

namespace ParcelsProject.Tests
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void ParcelForm_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult parcelFormView = controller.ParcelForm();
            Assert.IsInstanceOfType(parcelFormView, typeof(ViewResult));
        }

        [TestMethod]
        public void ParcelResults_ReturnsCorrectView_True()
        {
            HomeController controller = new HomeController();
            ActionResult parcelResultsView = controller.ParcelResults();
            Assert.IsInstanceOfType(parcelResultsView, typeof(ViewResult));
        }

        [TestMethod]
        public void ParcelResults_HasCorrectModelType_Parcel()
        {
            ViewResult parcelResultsView = new HomeController().ParcelResults() as ViewResult;
            var result = parcelResultsView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(Parcel));
        }
    }
}
