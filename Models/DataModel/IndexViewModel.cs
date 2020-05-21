using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class IndexModelHome
    {
        public string RequestId { get; set; }
        public List<ClassImage> Image{ get; set; }
        
        public List<ClassForLevel> ForLevels{get;set;}
    }
    public class ClassImage{
         public string ImageName{ get; set; }
    }
    public class ClassForLevel{
         public string ImageName{ get; set; }
         public string NameFL{ get; set; }
         public string Icon{ get; set; }
    }
}
