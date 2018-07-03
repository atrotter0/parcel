using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ParcelsProject.Models;

namespace ParcelsProject.Tests
{
    [TestClass]
    public class ParcelTest
    {
        [TestMethod]
        public void SetGetSender_SetsGetsSender_String()
        {
            Parcel package = new Parcel();
            package.SetSender("Frodo");
            Assert.AreEqual("Frodo", package.GetSender());
        }
    }
}
