using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsOrdersPierresBakery.Models;

namespace VendorsOrdersPierresBakery.Tests
{
    [TestClass]
    public class VendorTests : IDisposable
    {
        public void Dispose()
        {
            Vendor.ClearAll();
        }

        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("test name", "test description");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        [TestMethod]
        public void GetVendorName_ReturnsVendorName_VendorName()
        {
            string vendorName = "test name";
            string vendorDescription = "test description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);

            string result = newVendor.VendorName;

            Assert.AreEqual(vendorName, result);
        }
        [TestMethod]
        public void GetVendorName_ReturnsVendorDescription_VendorDescription()
        {
            string vendorName = "test name";
            string vendorDescription = "test description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);

            string result = newVendor.VendorDescription;

            Assert.AreEqual(vendorDescription, result);
        }
        [TestMethod]
        public void GetVendorId_ReturnsVendorId_Int()
        {
            string vendorName = "test name";
            string vendorDescription = "test description";
            Vendor newVendor = new Vendor(vendorName, vendorDescription);

            int result = newVendor.VendorId;

            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void GetAll_ReturnsAllVendorObjects_VendorList()
        {
            string vendorName01 = "Flour Power";
            string vendorDescription01 = "flour vendor";
            string vendorName02 = "Sweet Treat";
            string vendorDescription02 = "sugar vendor";
            Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
            Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);
            List<Vendor> newVendorList = new List<Vendor> { newVendor01, newVendor02 };

            List<Vendor> result = Vendor.GetAll();

            CollectionAssert.AreEqual(newVendorList, result);
        }
        [TestMethod]
        public void Find_ReturnsCorrectVendor_Vendor()
        {
            string vendorName01 = "Flour Power";
            string vendorDescription01 = "flour vendor";
            string vendorName02 = "Sweet Treat";
            string vendorDescription02 = "sugar vendor";
            Vendor newVendor01 = new Vendor(vendorName01, vendorDescription01);
            Vendor newVendor02 = new Vendor(vendorName02, vendorDescription02);

            Vendor result = Vendor.Find(2);

            Assert.AreEqual(newVendor01, result);

        }

    }
}