using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class IndexGioiThieuModel
    {
        // public string RequestId { get; set; }

        // public DateTime Today{ get; set; }
        public List<ClassTitleCon> Title { get; set; }
    }
    public class ClassTitleCon
    {
         public string Con1 { get; set; }

        public string Con2{ get; set; }
        public string Con3{ get; set; }
        public string Con4{ get; set; }
        public string Con5{ get; set; }
    }
}
