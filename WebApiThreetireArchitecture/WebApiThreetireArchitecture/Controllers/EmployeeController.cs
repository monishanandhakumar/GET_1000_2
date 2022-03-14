using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiThreetireArchitecture.Services;

namespace WebApiThreetireArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository dbemployeeRepository;
        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            dbemployeeRepository = employeeRepository;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeedeatils(int id)
        {
            dynamic employee = await dbemployeeRepository.GetEmployeebyid(id);
            return Ok(employee);

        }
    }
}
