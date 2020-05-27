using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CO453_WebApplication.Models;

namespace CO453_WebApplication.Controllers
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

        [HttpGet]
        public IActionResult Customer()
        {
            Customer customer = new Customer
            {
                CustomerID = 1,
                FullName = "Eric",
                Address = "HP13 6XA",
                Email = "eric.man95@outlook.com",
                MobileNumber = "07123 456 789"
            };

            return View(customer);
        }

        [HttpPost]
        public IActionResult Customer(Customer customer)
        {
            // save to database
            ViewData["Customer"] = customer;
            ViewBag.Customer = customer;

            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
