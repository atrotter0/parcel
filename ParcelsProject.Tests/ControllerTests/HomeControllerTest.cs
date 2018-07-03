using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using ParcelsProject.Controllers;
using ParcelsProject.Models;

namespace ParcelsProject.Tests
{
    [TestClass]
    public class HomeControllerTest : IDisposable
    {
        public void Dispose()
        {
            Parcel.ClearAll();
        }

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
            ActionResult parcelResultsView = controller.ParcelResults("Devin", 10, 10, 10, 10);
            Assert.IsInstanceOfType(parcelResultsView, typeof(ViewResult));
        }

        [TestMethod]
        public void ParcelResults_HasCorrectModelType_Parcel()
        {
            ViewResult parcelResultsView = new HomeController().ParcelResults("Devin", 10, 10, 10, 10) as ViewResult;
            var result = parcelResultsView.ViewData.Model;
            Assert.IsInstanceOfType(result, typeof(List<Parcel>));
        }
    }
}
