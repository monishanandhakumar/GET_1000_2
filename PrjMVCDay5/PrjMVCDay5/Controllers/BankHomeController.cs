using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMVCDay5.Controllers
{
    public class BankHomeController : Controller
    {
        public IActionResult BankIndex()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ConatctUs()
        {
            return View();
        }
    }
}
