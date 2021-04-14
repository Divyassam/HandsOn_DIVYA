using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_3_31.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {

        private static readonly Employee[] Summaries = new[]
        {
            new Employee(){Id=1,Name="Divya",Salary=10000},new Employee(){Id=2,Name="Dino",Salary=25000}
        };

        [Authorize(Roles ="Admin,POC")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(Summaries.ToList());
        }

        [Authorize(Roles = "POC")]
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(Summaries[id]);
        }
    }
}
