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
         private IThuVienVideo _thuVienVideo;

        public ThuVienController(ILogger<ThuVienController> logger, IThuVienVideo thuVienVideo)
        {
            _logger = logger;
            _thuVienVideo = thuVienVideo;
        }
        public IActionResult ThuVienVideo()
        {
            ThuVienVideoModel thuVienVideoModel = new ThuVienVideoModel();
            thuVienVideoModel= _thuVienVideo.GetThuVienVideoI();
            return View(thuVienVideoModel);
        }
    }
}