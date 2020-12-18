using System.Collections.Generic;
using System;
using System.Globalization;

namespace VendorsOrdersPierresBakery.Models
{
    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public int OrderPrice { get; set; }
        public string OrderDate { get; set; }
        public int OrderId { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string orderTitle, string orderDescription, int orderPrice)
        {
            OrderTitle = orderTitle;
            OrderDescription = orderDescription;
            OrderPrice = orderPrice;
            _instances.Add(this);
            OrderId = _instances.Count;
        }
        public void GetOrderDate()
        {
            DateTime orderDate = DateTime.UtcNow;
            string orderDateWithFormat = orderDate.ToLongDateString();
            OrderDate = orderDateWithFormat;
        }

    }
}