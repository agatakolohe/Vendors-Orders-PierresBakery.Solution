using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Globalization;
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

            Assert.AreEqual(orderDescription, result);
        }
        [TestMethod]
        public void GetOrderPrice_ReturnsOrderPrice_OrderPrice()
        {
            string orderTitle = "test order title";
            string orderDescription = "test order description";
            int orderPrice = 1;
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

            int result = newOrder.OrderPrice;

            Assert.AreEqual(orderPrice, result);
        }
        [TestMethod]
        public void GetOrderDate_ReturnsOrderDate_OrderDate()
        {
            string orderTitle = "test order title";
            string orderDescription = "test order description";
            int orderPrice = 1;
            string orderDate = "Monday, January 1, 0001";
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

            DateTime result = newOrder.OrderDate;
            string resultDateWithFormat = result.ToLongDateString();

            Assert.AreEqual(orderDate, resultDateWithFormat);
        }


    }
}