using Microsoft.AspNetCore.Mvc;
// using ProjectName.Models; <<change
using System.Collections.Generic;

namespace ProjectName.Controllers//change
{
    public class ChildClassNameController : Controller
    {

        // [HttpGet("/categories/{categoryId}/items/new")]//user creates the ChildObject example:Item in category. Category: Housework == Item:Mop the floors
        // public ActionResult New(int categoryId)
        // {
        //     Category category = Category.Find(categoryId);
        //     return View(category);
        // }

        // [HttpPost("/items/delete")] //deleting 
        // public ActionResult DeleteAll()
        // {
        //     Item.ClearAll();
        //     return View();
        // }
        // [HttpGet("/categories/{categoryId}/items/{itemId}")] //show both object
        // public ActionResult Show(int categoryId, int itemId)
        // {
        //     Item item = Item.Find(itemId);
        //     Category category = Category.Find(categoryId);
        //     Dictionary<string, object> model = new Dictionary<string, object>();
        //     model.Add("item", item);
        //     model.Add("category", category);
        //     return View(model);
        // }
    }
}