using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using practice.Models;
using Practice.Service.Interface;

namespace practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClass1 _class1;
        private readonly ITestService _testService;

        public HomeController(ILogger<HomeController> logger,
            IClass1 class1,
            ITestService testService)
        {
            this._logger = logger;
            this._class1 = class1;
            this._testService = testService;
        }

        public IActionResult Index()
        {
            _class1.Test();
            _testService.Test();
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
    }
}
