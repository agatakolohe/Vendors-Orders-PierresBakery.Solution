using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using VendorsOrdersPierresBakery.Models;

namespace VendorsOrdersPierresBakery.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor newVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index", "/");
        }

        [HttpGet("/vendors/{id}")]
        public ActionResult Show(int id)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor selectedVendor = Vendor.Find(id);
            List<Order> selectedVendorsOrders = selectedVendor.Orders;
            model.Add("vendor", selectedVendor);
            model.Add("orders", selectedVendorsOrders);
            return View(model);
        }

        [HttpPost("/vendors/{vendorId}/orders")]
        public ActionResult Create(int vendorId, string orderTitle, string orderDescription, int orderPrice)
        {
            Dictionary<string, object> model = new Dictionary<string, object>();
            Vendor foundVendor = Vendor.Find(vendorId);
            Order newOrder = new Order(orderTitle, orderDescription, orderPrice);
            newOrder.GetOrderDate();
            foundVendor.AddOrder(newOrder);
            List<Order> vendorsOrders = foundVendor.Orders;
            model.Add("orders", vendorsOrders);
            model.Add("vendor", foundVendor);
            return View("Show", model);
        }

    }
}