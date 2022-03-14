using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiThreetireArchitecture.Models;

namespace WebApiThreetireArchitecture.Services
{
    public interface IEmployeeRepository
    {
       Employee  GetEmployeebyidnotasync(int id); //normal method
        Task<string> GetEmployeebyid(int id); //Async
    }
}
