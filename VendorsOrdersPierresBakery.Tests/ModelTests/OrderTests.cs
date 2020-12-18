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
            Order.ClearAll();
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
            string orderDate = "Friday, December 18, 2020";
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

            newOrder.GetOrderDate();

            Assert.AreEqual(orderDate, newOrder.OrderDate);
        }

        [TestMethod]
        public void GetOrderId_ReturnsOrderId_Int()
        {
            string orderTitle = "test order title";
            string orderDescription = "test order description";
            int orderPrice = 1;
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);

            int result = newOrder.OrderId;

            Assert.AreEqual(1, result);
        }
        [TestMethod]
        public void GetAll_ReturnsAllOrderObjects_OrderList()
        {
            string orderTitle01 = "flour";
            string orderDescription01 = "order 10lbs of flour";
            int orderPrice01 = 1;
            string orderTitle02 = "sugar";
            string orderDescription02 = "order 10lbs of sugar";
            int orderPrice02 = 1;
            Order newOrder01 = new Order(orderTitle01, orderDescription01, orderPrice01);
            Order newOrder02 = new Order(orderTitle02, orderDescription02, orderPrice02);
            List<Order> newOrderList = new List<Order> { newOrder01, newOrder02 };

            List<Order> result = Order.GetAll();

            CollectionAssert.AreEqual(newOrderList, result);
        }



    }
}