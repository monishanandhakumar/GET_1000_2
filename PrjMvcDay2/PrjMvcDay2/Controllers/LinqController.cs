using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMvcDay2.Models;
namespace PrjMvcDay2.Controllers
{
    public class LinqController : Controller
    {
        private readonly NorthwindContext db;

        //DI
        public LinqController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Getcatbyname()
        {
            //Query syntax
            var catname = (from c in db.Categories
                           orderby c.CategoryName
                                    select c.CategoryName).ToList();
            //Method syntax
            var c1 = (db.Categories.Select(ca => ca.CategoryName)).ToList();
            ViewBag.cname = catname;
            return View();
        }
        //display the customer from germany
        public IActionResult CustomerGermany()
        {
            //Query syntax
             ViewBag.cust = (from c in db.Customers
                        where c.Country == "germany"
                        select c).ToList();
            return View();
        }

       //display the employee whose region is notnull
        public IActionResult Employee()
        {
            //Query syntax
            ViewBag.employee = (from e in db.Employees
                            where e.Region !=null
                            select e).ToList();
            return View();
        }
        //display the customer info for orderid 10248
        public IActionResult Custorder()
        {
            //Query syntax
            ViewBag.Customer = (from o in db.Orders
                                join c in db.Customers
                                on o.CustomerId equals c.CustomerId
                                where o.OrderId == 10248
                                select c).ToList();
                        return View();
        }


    }
}
