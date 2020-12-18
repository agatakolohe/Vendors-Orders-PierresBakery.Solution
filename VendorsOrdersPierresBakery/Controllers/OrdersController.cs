using Microsoft.AspNetCore.Mvc;
using VendorsOrdersPierresBakery.Models;
using System.Collections.Generic;

namespace VendorsOrdersPierresBakery.Controllers
{
    public class OrdersController : Controller
    {

        [HttpGet("/vendors/{vendorId}/orders/new")]
        public ActionResult New(int vendorId)
        {
            Vendor vendor = Vendor.Find(vendorId);
            return View(category);
        }

        [HttpPost("/orders/delete")]
        public ActionResult Destroy()
        {
            Order.ClearAll();
            return View();
        }

        [HttpGet("/vendors/{vendorId}/orders/{orderId}")]
        public ActionResult Show(int vendorId, int orderId)
        {
            Order order = Order.Find(orderId);
            Vendor vendor = Vendor.Find(vendorId);
            Dictionary<string, object> model = new Dictionary<string, object>();
            model.Add("order", order);
            model.Add("vendor", vendor);
            return View(model);
        }
    }
}