using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using prjMVCDay4.MyModel;

namespace prjMVCDay4.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Registerform()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registerform(Register register)
        {
            if(ModelState.IsValid)
            {

            }
            return View();
        }
    }
}
