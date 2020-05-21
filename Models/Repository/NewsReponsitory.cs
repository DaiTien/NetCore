using netCore.Models;
using System.Collections.Generic;
namespace netCore.Repository
{
    public class NewsRepository : INews
    {
        public NewsModel GetNews1()
        {
            NewsModel newsModel = new NewsModel();
            newsModel.NewsCateId ="1";
            newsModel.Tittle ="Thông Báo Mới";
            newsModel.News = new List<ClassNews>();
            ClassNews classNews = new ClassNews();
            classNews.NewsId = "1";
            classNews.NewsTittle="Thổng báo lịch nghỉ học hết ngày 15/03/2020";
            classNews.NewsContent="Do tình hình dịch covid-19 diễn biến phức tạp. Cho nên nhà trường cho toàn bộ học sinh nghỉ hết ngày 15/03/2020";
            classNews.NewsImage="/assets/images/anh_tintuc/yskwqlve.1b0.jpg";
            newsModel.News.Add(classNews);
             ClassNews classNews1 = new ClassNews();
            classNews1.NewsId = "2";
            classNews1.NewsTittle="Thông Báo Nghĩ Học";
            classNews1.NewsContent="Thực hiện công văn số 509/SGDĐT-CTrTT, ngày 28 tháng 02 năm 2020 của Sở Giáo dục và Đào tạo thành phố Đà Nẵng, Trường Việt Nhật xin thông báo học sinh tiếp tục nghỉ học đến hết ngày 08/3/2020 và một số nội dung cụ thể trong công văn 03/TB-VJIS của nhà trường.";
            classNews1.NewsImage="/assets/images/anh_tintuc/jiu1qmtv.zyz.jpg";
            newsModel.News.Add(classNews1);
       
            return newsModel;
        }
        public int GetNews2()
        {
            return 0;
        }
    }
}