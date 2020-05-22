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
    public class NewsController : Controller
    {
        private readonly ILogger<NewsController> _logger;
        private INews _iNews;
         private INews1 _iNews1;

        public NewsController(ILogger<NewsController> logger, INews iNews, INews1 iNews1)
        {
            _logger = logger;
            _iNews = iNews;
            _iNews1 = iNews1;
        }

        public IActionResult ThongBaoMoi()
        {
            NewsModel newsModel = new NewsModel();
            newsModel = _iNews.GetNews1();
            return View(newsModel);
        }
          public IActionResult HoatDongSuKien()
        {
            NewsModel1 newsModel1 = new NewsModel1();
            newsModel1 = _iNews1.GetNews2();
            return View(newsModel1);
        }
    }
}
