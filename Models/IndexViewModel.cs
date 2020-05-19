using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class IndexSlideModel
    {
        public string RequestId { get; set; }
        public List<ClassImage> Image{ get; set; }
        // public List<ClassImage> Image{ get; set; }
    }
    public class ClassImage{
         public string ImageName{ get; set; }
    }
}
