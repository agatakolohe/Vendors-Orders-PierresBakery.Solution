using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsOrdersPierresBakery.Models;

namespace VendorsOrdersPierresBakery.Tests
{
    [TestClass]
    public class VendorTests
    {
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

            int result = newVendor.Id;

            Assert.AreEqual(1, result);
        }

    }
}