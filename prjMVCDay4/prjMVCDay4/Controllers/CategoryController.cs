using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prjMVCDay4.Models;

namespace prjMVCDay4.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;
        public CategoryController(NorthwindContext context)
        {
            db = context;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if(ModelState.IsValid)
            {
                db.Categories.Add(category);
                db.SaveChanges();
            }
           
           
            return View();
        }
    }
}
