using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using netCore.Models;

namespace netCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IDemo _iDemo;

        public HomeController(ILogger<HomeController> logger, IDemo iDemo)
        {
            _logger = logger;
            _iDemo=iDemo;
        }

        public IActionResult Index()
        {
            IndexModelHome indexModelHome = new IndexModelHome();
            indexModelHome= _iDemo.GetDemoI();
             _iDemo.GetTeacher();
            return View(indexModelHome);
        }
        public IActionResult TinTuc()
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
    }
}
