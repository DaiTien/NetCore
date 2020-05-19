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
            IndexGioiThieuModel titleGioithieu = new IndexGioiThieuModel();
            ClassTitleCon titleCon = new ClassTitleCon();
            titleCon.Con1="ĐỘI NGŨ GIÁO VIÊN";
            titleCon.Con2 ="CƠ CẤU HỆ THỐNG";
            titleCon.Con3 ="ĐỐI TÁC";
            titleCon.Con4 ="THÀNH TỰU";
            titleCon.Con5="CƠ SỞ VẬT CHẤT";
            titleGioithieu.Title.Add(titleCon);
            return View(titleGioithieu);
        }
       
    }
}
