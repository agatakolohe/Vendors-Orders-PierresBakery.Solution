using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using VendorsOrdersPierresBakery.Models;


namespace VendorsOrdersPierresBakery.Tests
{
    [TestClass]
    public class OrderTests : IDisposable
    {
        public void Dispose()
        {
            // Order.ClearAll();
        }

        [TestMethod]
        public void OrderConstructor_CreatesInstanceOfOrder_Order()
        {
            Order newOrder = new Order("orderTitle", "orderDescription", 1);
            Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
        [TestMethod]
        public void GetOrderTitle_ReturnsOrderTitle_OrderTitle()
        {
            string orderTitle = "test order title";
            string orderDescription = "test order description";
            int orderPrice = 1;
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

            string result = newOrder.OrderTitle;

            Assert.AreEqual(orderTitle, result);
        }
        [TestMethod]
        public void GetOrderDescription_ReturnsOrderDescription_OrderDescription()
        {
            string orderTitle = "test order title";
            string orderDescription = "test order description";
            int orderPrice = 1;
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

            string result = newOrder.OrderDescription;

            Assert.AreEqual(orderTitle, result);
        }


    }
}