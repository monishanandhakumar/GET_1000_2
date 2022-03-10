using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjMVCDay5.Controllers
{
    public class BeneficiaryController : Controller
    {

       
        public IActionResult AddBeneficiary()
        {
            return View();
        }

        public IActionResult DeleteBeneficiary()
        {
            return View();
        }
    }
}
