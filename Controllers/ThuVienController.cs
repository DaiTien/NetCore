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
         private IThuVienAnh _thuVienAnh;

        public ThuVienController(ILogger<ThuVienController> logger, IThuVienVideo thuVienVideo, IThuVienAnh thuVienAnh)
        {
            _logger = logger;
            _thuVienVideo = thuVienVideo;
            _thuVienAnh = thuVienAnh;
        }
        public IActionResult ThuVienVideo()
        {
            ThuVienVideoModel thuVienVideoModel = new ThuVienVideoModel();
            thuVienVideoModel= _thuVienVideo.GetThuVienVideoI();
            _thuVienVideo.GetStudentInClassI();
            return View(thuVienVideoModel);
        }
        public IActionResult ThuVienAnh()
        {
            ThuVienAnhModel thuVienAnhModel = new ThuVienAnhModel();
            thuVienAnhModel= _thuVienAnh.GetThuVienAnhI();
            _thuVienAnh.GetThuVienAnhImage();
            return View(thuVienAnhModel);
        }
        
    }
}