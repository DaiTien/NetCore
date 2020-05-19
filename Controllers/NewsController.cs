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

        public NewsController(ILogger<NewsController> logger)
        {
            _logger = logger;
        }

        public IActionResult ThongBaoMoi()
        {
            NewsModel newsModel = new NewsModel();
            newsModel.NewsCateId ="1";
            newsModel.Tittle ="Thông Báo Mới";
            newsModel.News = new List<ClassCon>();
            ClassNews classNews = new ClassNews();
            classNews.NewsId = "1";
            classNews.NewsTittle="Thổng báo lịch nghỉ học hết ngày 15/03/2020";
            classNews.NewsContent="Do tình hình dịch covid-19 diễn biến phức tạp. Cho nên nhà trường cho toàn bộ học sinh nghỉ hết ngày 15/03/2020";
            classNews.NewsImage="~/assets/images/anh_tintuc/yskwqlve.1b0.jpg";
            classNews.News.Add(classNews);
             ClassNews classNews1 = new ClassNews();
            classNews1.NewsId = "2";
            classNews1.NewsTittle="Thông Báo Nghĩ Học";
            classNews1.NewsContent="Thực hiện công văn số 509/SGDĐT-CTrTT, ngày 28 tháng 02 năm 2020 của Sở Giáo dục và Đào tạo thành phố Đà Nẵng, Trường Việt Nhật xin thông báo học sinh tiếp tục nghỉ học đến hết ngày 08/3/2020 và một số nội dung cụ thể trong công văn 03/TB-VJIS của nhà trường.";
            classNews.NewsImage="~/assets/images/anh_tintuc/jiu1qmtv.zyz.jpg";
            classNews1.News.Add(classNews1);
           /* IndexModel indexModel = new IndexModel();
            indexModel.RequestId = "12345";
            indexModel.Today = DateTime.Now;
            indexModel.Con = new List<ClassCon>();
            ClassCon classCon1 =new ClassCon();
            classCon1.Con1="5678";
            classCon1.Con2=DateTime.Now;
            indexModel.Con.Add(classCon1);
            ClassCon classCon =new ClassCon();
            classCon.Con1="1235";
            classCon.Con2=DateTime.Now;
            indexModel.Con.Add(classCon);*/
            return View(newsModel);
        }
        public IActionResult TinTuc()
        {
            return View();
        }
     
    }
}
