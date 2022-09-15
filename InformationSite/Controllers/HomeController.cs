using InformationSite.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InformationSite.Controllers
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

        public IActionResult Electronics()
        {
            return View();
        }
        public IActionResult Gadgets()
        {
            return View();
        }
        public IActionResult News1()
        {
            return View();
        }
        public IActionResult News2()
        {
            return View();
        }
        public IActionResult News3()
        {
            return View();
        }
        public IActionResult News4()
        {
            return View();
        }
        public IActionResult News5()
        {
            return View();
        }
        public IActionResult News6()
        {
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
