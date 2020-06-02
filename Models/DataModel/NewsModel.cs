using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class NewsModel
    {
        public string NewCateId { get; set; }
        public string Title{ get; set; }
        public List<ClassNews> News { get; set; }
    }
    public class ClassNews
    {
       
           public string news_id { get; set; }
        public string news_content{ get; set; }
        public string news_title{ get; set; }
        public string news_image{ get; set; }
           public string NewsId { get; set; }
        public string NewsContent{ get; set; }
        public string NewsTittle{ get; set; }
        public string NewsImage{ get; set; }
    }
      public class NewsModel1
    {
        public string newscate_id { get; set; }
        public string newscate_title{ get; set; }
        public List<ClassNews1> News { get; set; }
    }

     public class ClassNews1
    {
        public string NewsId { get; set; }
        public string NewsContent{ get; set; }
        public string NewsTittle{ get; set; }
        public string NewsImage{ get; set; }
    }
        public class GetNews
    {
        public string newscate_id { get; set; }
        public string newscate_title{ get; set; }
        public string news_id{ get; set; }
        public string news_title{ get; set; }
    }
}
