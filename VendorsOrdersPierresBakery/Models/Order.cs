using System.Collections.Generic;

namespace VendorsOrdersPierresBakery.Models
{
    public class Order
    {
        public string OrderTitle { get; set; }
        public string OrderDescription { get; set; }
        public int OrderPrice { get; set; }
        public int OrderDate { get; set; }
        public int OrderId { get; }
        private static List<Order> _instances = new List<Order> { };

        public Order(string orderTitle, string orderDescription, int orderPrice, int orderDate)
        {
            OrderTitle = orderTitle;
            OrderDescription = orderDescription;
            OrderPrice = orderPrice;
            OrderDate = orderDate;
            _instances.Add(this);
            OrderId = _instances.Count;
        }

    }
}