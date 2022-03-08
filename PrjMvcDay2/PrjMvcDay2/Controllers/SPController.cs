using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMvcDay2.Models;
using Microsoft.EntityFrameworkCore;

namespace PrjMvcDay2.Controllers
{
    public class SPController : Controller
    {
        private readonly NorthwindContext db;

        //DI
        public SPController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult TenProduct()
        {
            return View(db.Ten_Most_Expensive_Products.FromSqlRaw("[dbo].[Ten Most Expensive Products]"));
        }

        public IActionResult Order()
        {
            string? cid = "VINET";
            var data = db.CustOrdersOrders.FromSqlRaw("[dbo].[CustOrdersOrders] @p0", parameters: new[] { cid }).ToList();
            return View(data);
        }

    }
}
