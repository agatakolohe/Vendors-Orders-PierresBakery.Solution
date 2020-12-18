using Microsoft.AspNetCore.Mvc;
using VendorsOrdersPierresBakery.Models;
using System.Collections.Generic;

namespace VendorsOrdersPierresBakery.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}