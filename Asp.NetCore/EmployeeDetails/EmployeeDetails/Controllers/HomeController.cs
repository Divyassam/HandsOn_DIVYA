using EmployeeDetails.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult GetEmployeeList()
        {
            List<Employee> elist = new List<Employee>();
            Employee e = new Employee(1, "John", 10000, true);
            elist.Add(e);
            e = new Employee(2, "Smith", 5000, false);
            elist.Add(e);
            e = new Employee(3, "Mark", 5000, false);
            elist.Add(e);
            e = new Employee(4, "Mary", 5000, true);
            elist.Add(e);
            return View(elist);
        }
    }
}
