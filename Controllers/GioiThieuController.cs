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

        private IGioiThieu _iGioithieu;
        public GioiThieuController(ILogger<GioiThieuController> logger, IGioiThieu iGioithieu)
        {
            _logger = logger;
            _iGioithieu = iGioithieu;
        }

        public IActionResult Index()
        {
            IndexGioiThieuModel titleGioithieu = new IndexGioiThieuModel();
            titleGioithieu= _iGioithieu.GetGioiThieu();
            _iGioithieu.GetGioiThieuII();
            return View(titleGioithieu);
        }
       
    }
}
