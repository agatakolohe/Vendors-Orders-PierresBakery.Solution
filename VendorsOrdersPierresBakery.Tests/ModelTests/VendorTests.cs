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
            Vendor newVendor = new Vendor("test name");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }
        [TestMethod]
        public void GetVendorName_ReturnsVendorName_VendorName()
        {
            string vendorName = "test name";
            Vendor newVendor = new Vendor(vendorName);

            string result = newVendor.VendorName;

            Assert.AreEqual(vendorName, result);
        }
    }
}