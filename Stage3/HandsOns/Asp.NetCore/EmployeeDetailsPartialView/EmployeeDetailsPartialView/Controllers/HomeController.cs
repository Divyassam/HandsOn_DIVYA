using EmployeeDetailsPartialView.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetailsPartialView.Controllers
{
    public class HomeController : Controller
    {
        private List<Employee> eList = new List<Employee>()
        {
                new Employee(1, "John", 10000, true),
                new Employee(2, "Smith", 5000, false),
                new Employee(3, "Mark", 5000, false),
                new Employee(4, "Mary", 5000, true),

            };
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(eList);
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
            return PartialView("_EmployeeList",eList);
        }
    }
}
