using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace webApi_2_30.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public List<Employee> employees = new List<Employee>();
        public EmployeeController()
        {
            employees.Add(new Employee { Id = 1, Name = "Divya", Salary = 10000, /*Permanent = true, Department = new Department { Id = 1, Name = "IT" }, Skills = new List<Skill>() { new Skill { Id = 1, Name = "CSS" }, new Skill { Id = 2, Name = "HTML" } },DateOfBirth = new DateTime(1998, 10, 20) */ }
);
            employees.Add(new Employee { Id = 2, Name = "Dino", Salary = 25000, /*Permanent = true, Department = new Department { Id = 1, Name = "IT" }, Skills = new List<Skill>() { new Skill { Id = 1, Name = "CSS" }, new Skill { Id = 2, Name = "HTML" } },DateOfBirth = new DateTime(1998, 10, 20) */ });
        }
        // GET: api/<EmployeeController>
        [HttpGet]
        public IEnumerable<Employee> Get()
        {
            return employees;
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public Employee Get(int id)
        {
            return employees.Find(x=>x.Id==id);
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post([FromBody] Employee employee)
        {
            if (employee.Id>0)
            {
                employees.Add(employee);
                return Ok(employees);
            }
            else
                return BadRequest("Invalid employee id");
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Employee employee)
        {
            if(employee.Id<=0) return BadRequest("Invalid employee id");
            else if (!employees.Exists(x => x.Id == id)) return BadRequest("Invalid employee id");
            else
            {
                Employee data = employees.Find(x => x.Id == employee.Id);
                data.Name = employee.Name;
                data.Salary = employee.Salary;
                return Ok(employees.Find(x => x.Id == employee.Id));
            }
        }

    }
}
