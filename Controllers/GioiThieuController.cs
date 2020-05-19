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
    public class GioiThieuController : Controller
    {
        private readonly ILogger<GioiThieuController> _logger;

        public GioiThieuController(ILogger<GioiThieuController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
       
    }
}
