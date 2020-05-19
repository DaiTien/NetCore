using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class IndexModel
    {
        public string RequestId { get; set; }

        public DateTime Today{ get; set; }
        public List<ClassCon> Con { get; set; }
    }
    public class ClassCon
    {
         public string Con1 { get; set; }

        public DateTime Con2{ get; set; }
    }
}
