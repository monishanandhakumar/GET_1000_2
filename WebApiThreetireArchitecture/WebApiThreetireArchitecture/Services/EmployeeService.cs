using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiThreetireArchitecture.Models;

namespace WebApiThreetireArchitecture.Services
{
    public class EmployeeService:IEmployeeRepository
    {
        private readonly NorthwindContext db;
        public EmployeeService(NorthwindContext context)
        {
            db = context;
        }
        //normal way 
      public  Employee GetEmployeebyidnotasync(int id)
        {
            dynamic e = (from emp in db.Employees
                         where emp.EmployeeId == id
                         select emp.FirstName).FirstOrDefault();

            dynamic emp1 = db.Employees.Where(e => e.EmployeeId == id).Select(n => n.FirstName).FirstOrDefault();
            return emp1;
        }
        //Async way
        public async Task<string> GetEmployeebyid(int id)
        {
            dynamic e = (from emp in db.Employees
                         where emp.EmployeeId == id
                         select emp.FirstName).FirstOrDefault();

            dynamic emp1 = db.Employees.Where(e => e.EmployeeId == id).Select(n => n.FirstName).FirstOrDefault();
            return emp1;
        }
    }
}
