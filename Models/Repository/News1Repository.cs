using netCore.Models;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
namespace netCore.Repository
{
    public class News1Repository : INews1
    {
        private readonly ConnectionString _connectionString;

        public News1Repository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }

        public NewsModel1 GetNews2()
        {
            const string query = @"select * from tbnewscate where newscate_id=2";

            using (var conn = new SqlConnection(_connectionString.Value))
            {
                NewsModel1 newsModel1 = new NewsModel1();
                var result = conn.Query<NewsModel1>(query);
                newsModel1.newscate_title = result.FirstOrDefault().newscate_title.ToString();
                newsModel1.News = new List<ClassNews1>();
                ClassNews1 classNews2 = new ClassNews1();
                classNews2.NewsId = "1";
                classNews2.NewsTittle = "Những Hoạt Động Của Nhà Trường Để phòng Chống Virus n-CoV";
                classNews2.NewsContent = "COVID-19 đã làm thay đổi một phần nào đó cuộc sống hằng ngày của các bạn nhỏ Việt Nhật cũng như của các giáo viên. Trong những ngày nghỉ giáo viên Việt Nhật đã làm những gì nhỉ !?";
                classNews2.NewsImage = "/assets/anh_tintuc/pt40a0lh.5m2.jpg";
                newsModel1.News.Add(classNews2);
                return newsModel1;
            }
        }

    }
}