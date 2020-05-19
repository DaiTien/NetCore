using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class NewsModel
    {
        public string NewsCateId { get; set; }
        public string Content{ get; set; }
        public string Tittle{ get; set; }
        public string Image{ get; set; }
        public List<ClassNews> News { get; set; }
    }
    public class ClassNews
    {
        public string NewsId { get; set; }
        public string NewsContent{ get; set; }
        public string NewsTittle{ get; set; }
        public string NewsImage{ get; set; }
}
