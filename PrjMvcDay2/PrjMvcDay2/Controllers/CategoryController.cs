using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMvcDay2.Models;

namespace PrjMvcDay2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;

        //DI
        public CategoryController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult GetCategory()
        {
           List<Category> categories= db.Categories.ToList();
            return View(categories);
        }
        #region  display
        public IActionResult GetCategorywithscaff()
        {
            List<Category> categories= db.Categories.ToList();
            return View(categories);
          
        }

        #endregion

        #region Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("GetCategorywithscaff");
        }
        #endregion

        public IActionResult Delete(int id)
        {
            Category category = db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("GetCategorywithscaff");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category c)
        {
            Category category = db.Categories.Find(c.CategoryId);
            category.CategoryName = c.CategoryName;
            category.Description = c.Description;
            category.Picture = c.Picture;
            db.SaveChanges();
            return RedirectToAction("GetCategorywithscaff");
        }

        public IActionResult Display(int id)
        {
            Category category = db.Categories.Find(id);
            return View(category);
        }


    }

}
