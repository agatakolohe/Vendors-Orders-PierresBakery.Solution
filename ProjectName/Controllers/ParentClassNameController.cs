using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
// using ProjectName.Models; <<change

namespace ProjectName.Controllers //change
{
    public class ClassNameController : Controller //change
    {
        // [HttpGet("/ParentObject")] //Display list of all ParentObjects
        // public ActionResult Index()
        // {
        // List<Category> allCategories = Category.GetAll(); //displaying all categories
        //     return View(allCategories);
        // }

        // [HttpGet("/ParentObject/new")] //user creates new ParentObject with form
        // public ActionResult New()
        // {
        //     return View();
        // }

        // [HttpPost("/ParentObject")] //Creates new ParentObject on server process form submission
        // public ActionResult Create(string categoryName) //accepts argument because it is referring to the contents in form 
        // {
        //     Category newCategory = new Category(categoryName); //create a new category
        //     return RedirectToAction("Index"); //sends the user back to the Index route
        // }

        // [HttpGet("/ParentObject/{id}")] //Display one specific ParentObject's details
        // public ActionResult Show(int id)
        // {
        //     Dictionary<string, object> model = new Dictionary<string, object>();
        //     Category selectedCategory = Category.Find(id);
        //     List<Item> categoryItems = selectedCategory.Items;
        //     model.Add("category", selectedCategory); //keys == "category" and "items"
        //     model.Add("items", categoryItems);
        //     return View(model); //view can only accept one model argument
        // }

    }
}