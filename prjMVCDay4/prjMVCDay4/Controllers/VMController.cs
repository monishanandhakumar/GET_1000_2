using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prjMVCDay4.VM;
using prjMVCDay4.Models;

namespace prjMVCDay4.Controllers
{
    public class VMController : Controller
    {
        private readonly NorthwindContext db;
        public VMController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult CustomerOrder()
        {
            List<CustomerVM> li = new List<CustomerVM>();

            var customerlist = (from cust in db.Customers
                                join or in db.Orders
                                on cust.CustomerId equals or.CustomerId
                                select new { cust.CustomerId, cust.CompanyName, or.OrderId, or.OrderDate }).ToList();

            foreach(var item in customerlist)
            {
                CustomerVM cvm = new CustomerVM();
                cvm.CustomerID = item.CustomerId;
                cvm.CompanyName = item.CompanyName;
                cvm.OrderId = item.OrderId;
                cvm.OrderDate = item.OrderDate;

                li.Add(cvm);

            }
            return View(li);
        }
    }
}
