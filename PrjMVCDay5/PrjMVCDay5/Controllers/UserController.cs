using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMVCDay5.Models;

namespace PrjMVCDay5.Controllers
{
    //Attribute Routing
    [Route("Customer")]
    public class UserController : Controller
    {
       
        [Route("Register")]

        [HttpGet]
        public IActionResult UserRegister()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserRegister(User user)
        {
            return View();
        }

        [Route("id/{id:int?}")]

        public IActionResult Userbyid(int id)
        {
            return View();
        }

        [Route("user/{city=Mumbai}")]

        public IActionResult Userbycity(string city)
        {
            return View();
        }













        [HttpGet]
        public IActionResult UserLogin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserLogin(User user)
        {
            return View();
        }


    }
}
