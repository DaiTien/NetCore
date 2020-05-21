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
    public class ThuVienController : Controller
    {
         private readonly ILogger<ThuVienController> _logger;

        public ThuVienController(ILogger<ThuVienController> logger)
        {
            _logger = logger;
        }
        public IActionResult ThuVienVideo()
        {
            return View();
        }
    }
}