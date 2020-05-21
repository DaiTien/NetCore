using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class ThuVienVideoModel
    {
        public string RequestId { get; set; }
        public List<VideoClassName> Name {get;set;}
    }
    public class VideoClassName
    {
        public string NameFilter { set; get; }
        public string NameClass { set; get; }
    }
}
