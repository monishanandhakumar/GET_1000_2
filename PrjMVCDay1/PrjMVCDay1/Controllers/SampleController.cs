using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMVCDay1.Models;

namespace PrjMVCDay1.Controllers
{
    //controller:collection of action methods
    public class SampleController : Controller
    {
        public IActionResult Hero()
        {
            return View();
        }

        public IActionResult Result()
        {
            return View();
        }

        //Normal Method
        public dynamic SIMethod(int p,int n ,int r)
        {
            int SI = (p * n * r) / 100;
            return SI;
        }

        //various return type of action method

        //viewresult-return only view 
        public ViewResult Information()
        {
            return View();
        }

        //contentresult --if we display set of string

        public ContentResult Data()
        {
            return Content("<h1>Lunch Break!!!</h1>","text/html");
        }

        //retun as json

        public JsonResult Persondata()
        {
            Person person = new Person();
            person.name = "Sai";
            person.city = "Chennai";
            return Json(person);
        }

        public IActionResult GetInfo()
        {
            Person person = new Person();
            person.name = "Sai";
            person.city = "Chennai";
            return Json(person);
            // return Content("<h1>Lunch Break!!!</h1>", "text/html");
            // return View();
        }
    }
}
