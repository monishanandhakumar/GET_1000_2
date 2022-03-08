using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PrjMVCDay1.Models;

namespace PrjMVCDay1.Controllers
{
    public class HRController : Controller
    {
        public IActionResult DisplayPerson()
        {
            Person person = new Person();
            person.name = "Abi";
            person.city = "Goa";
            return View(person);
        }

        public IActionResult ListofPerson()
        {
            List<Person> li = new List<Person>();
            li.Add(new Person { name = "Sasi", city = "Mumbai" });
            li.Add(new Person { name = "Lalitha", city = "Mumbai" });
            li.Add(new Person { name = "Arun", city = "Pune" });
            return View(li);
        }
        //Viewbag and View Data - To pass data from controller to view
        //viewbag-dynamic ,viewdata- dictionary
        public IActionResult GetMobile()
        {
            List<string> mobilename = new List<string>() {"Samsung","Oppo","one+" };

            ViewData["datamobile"] = mobilename;
            ViewBag.bagmobile = mobilename;

            return View();

        }

    }
}
