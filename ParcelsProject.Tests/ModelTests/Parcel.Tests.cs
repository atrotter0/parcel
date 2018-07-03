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

        [TestMethod]
        public void SetGetLength_SetsGetsLength_Int()
        {
            Parcel package = new Parcel();
            package.SetLength(50);
            Assert.AreEqual(50, package.GetLength());
        }

        [TestMethod]
        public void SetGetWidth_SetsGetsWidth_Int()
        {
            Parcel package = new Parcel();
            package.SetWidth(25);
            Assert.AreEqual(25, package.GetWidth());
        }

        [TestMethod]
        public void SetGetHeight_SetsGetsHeight_Int()
        {
            Parcel package = new Parcel();
            package.SetHeight(10);
            Assert.AreEqual(10, package.GetHeight());
        }

        [TestMethod]
        public void SetGetWeight_SetsGetsWeight_Int()
        {
            Parcel package = new Parcel();
            package.SetWeight(1000);
            Assert.AreEqual(1000, package.GetWeight());
        }

        [TestMethod]
        public void SetGetTotalVolume_SetsGetsTotalVolume_Int()
        {
            Parcel package = new Parcel();
            package.SetTotalVolume(1000);
            Assert.AreEqual(1000, package.GetTotalVolume());
        }

        [TestMethod]
        public void CalculateVolume_CalculatesVolume_Int()
        {
            Parcel package = new Parcel();
            package.SetHeight(20);
            package.SetWidth(50);
            package.SetLength(10);
            package.CalculateVolume();
            Assert.AreEqual(10000, package.GetTotalVolume());
        }

        [TestMethod]
        public void CalculateCost_CalculatesCost_Int()
        {
            Parcel package = new Parcel();
            package.SetTotalVolume(10000);
            package.SetWeight(1000);
            package.CalculateCost();
            Assert.AreEqual(110, package.GetCost());
        }

        [TestMethod]
        public void SaveGetAll_SavesGetsParcelList_List()
        {
            Parcel package01 = new Parcel();
            // package01.SaveParcel();
            Parcel package02 = new Parcel();
            // package02.SaveParcel();
            List<Parcel> compare = new List<Parcel> { package01, package02 };
            CollectionAssert.AreEqual(compare, Parcel.GetAll());
        }
    }
}
