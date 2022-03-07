using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMvcDay2.Controllers
{
    public class SampleController : Controller
    {
        public IActionResult Greetings()
        {
            return View();
        }
    }
}
