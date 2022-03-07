using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMvcDay2.Controllers
{
    public class DemoController : Controller
    {
        //Tempdata-- Dictionary --transfer the data from one action method to another action same controller and also in different 

       // helps to retain data in subsequent request
        public IActionResult Index()
        {
            TempData["WelcomeMessage"] = "GoodMorning!!";
                                    //actionmethod //controllername
            return RedirectToAction("Greetings", "Sample");
        }

        //Firstrequest
        public IActionResult One_Displayfruit()
        {

            List<string> Fruits = new List<string> { "Mango", "Orange", "Apple" };
            TempData["MyFruit"] = Fruits;
            TempData.Keep(); //retains tempdata in subsequent request
            return View();
        }

        //Secondrequest
        public IActionResult Two()
        {

            var getfruit = TempData["MyFruit"];
            return View(getfruit);
        }


    }
}
