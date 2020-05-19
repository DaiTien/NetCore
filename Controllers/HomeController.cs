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

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // IndexModel indexModel = new IndexModel();
            // indexModel.RequestId = "12345";
            // indexModel.Today = DateTime.Now;
            // indexModel.Con = new List<ClassCon>();
            // ClassCon classCon1 =new ClassCon();
            // classCon1.Con1="5678";
            // classCon1.Con2=DateTime.Now;
            // indexModel.Con.Add(classCon1);
            // ClassCon classCon =new ClassCon();
            // classCon.Con1="1235";
            // classCon.Con2=DateTime.Now;
            // indexModel.Con.Add(classCon);
            // return View(indexModel);
            IndexSlideModel indexSlideModel = new IndexSlideModel();
            indexSlideModel.RequestId = "1";
            indexSlideModel.Image = new List<ClassImage>();
            ClassImage classImage = new ClassImage();
            classImage.ImageName="/assets/images/anh_slide/slide1.jpg";
            indexSlideModel.Image.Add(classImage);
            ClassImage classImage2 = new ClassImage();
            classImage2.ImageName="/assets/images/anh_slide/slide2.jpg";
            indexSlideModel.Image.Add(classImage2);
            ClassImage classImage3 = new ClassImage();
            classImage3.ImageName="/assets/images/anh_slide/slide3.jpg";
            indexSlideModel.Image.Add(classImage3);
            ClassImage classImage4 = new ClassImage();
            classImage4.ImageName="/assets/images/anh_slide/slide4.jpg";
            indexSlideModel.Image.Add(classImage4);
            return View(indexSlideModel);
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
