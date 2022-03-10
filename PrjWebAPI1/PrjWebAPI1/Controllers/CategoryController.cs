using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PrjWebAPI1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrjWebAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly NorthwindContext db;

        public CategoryController(NorthwindContext context)
        {
            db= context;
        }

        [HttpGet]

        public IActionResult Get()
        {
            
           var cat= db.Categories.ToList();

            if(cat != null)
            {
                return Ok(cat);
            }
           else
            {
                return NotFound("data not found");
            }

        }

        [HttpPost]

        public IActionResult AddCategory(Category category)
        {
            try
            {
                if(category ==null)
                {
                    return BadRequest("Category is null");
                }

                else
                {
                    db.Categories.Add(category);
                    db.SaveChanges();
                    return Ok("Record Added!!");
                }
            }

            catch(Exception e)
            {
                return Ok("Some Error Occured!!!");
            }
           
        }
    }
}
