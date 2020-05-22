using netCore.Models;
using System.Collections.Generic;
namespace netCore.Repository
{
    public class News1Repository : INews1
    {
        public NewsModel1 GetNews2()
        {
            NewsModel1 newsModel1 = new NewsModel1();
            newsModel1.NewsCateId ="2";
            newsModel1.Tittle ="Hoạt động -Sự kiện";
            newsModel1.News = new List<ClassNews1>();
            ClassNews1 classNews2 = new ClassNews1();
            classNews2.NewsId = "1";
            classNews2.NewsTittle="Những Hoạt Động Của Nhà Trường Để phòng Chống Virus n-CoV";
            classNews2.NewsContent="COVID-19 đã làm thay đổi một phần nào đó cuộc sống hằng ngày của các bạn nhỏ Việt Nhật cũng như của các giáo viên. Trong những ngày nghỉ giáo viên Việt Nhật đã làm những gì nhỉ !?";
            classNews2.NewsImage="/assets/anh_tintuc/pt40a0lh.5m2.jpg";
            newsModel1.News.Add(classNews2);
            return newsModel1;
        }
      
    }
}