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

        public NewsController(ILogger<NewsController> logger, INews iNews)
        {
            _logger = logger;
            _iNews = iNews;
        }

        public IActionResult ThongBaoMoi()
        {
            NewsModel newsModel = new NewsModel();
            newsModel = _iNews.GetNews1();
            return View(newsModel);
        }
    }
}
