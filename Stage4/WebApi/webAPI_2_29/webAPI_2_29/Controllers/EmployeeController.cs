using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using webAPI_2_29.Filters;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webAPI_2_29.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomAuthFilter]
    public class EmployeeController : ControllerBase
    {
        public List<Employee> employees = new List<Employee>();
        public EmployeeController()
        {
            employees.Add(new Employee { Id = 1, Name = "Divya", Salary = 10000, Permanent = true, Department = new Department { Id = 1, Name = "IT" }, Skills = new List<Skill>() { new Skill { Id = 1, Name = "CSS" }, new Skill { Id = 2, Name = "HTML" } }, DateOfBirth = new DateTime(1998, 10, 20) }
);
        }
        private List<Employee> GetStandardEmployeeList()
        {
            return employees;
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public HttpResponseMessage Get()
        {         
            GetStandardEmployeeList();
            //throw new Exception();
            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        

        
    }
}
