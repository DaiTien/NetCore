using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class ThuVienVideoModel
    {
        public int lop_id { get; set; }
        public string lop_name { get; set; }
        public int khoi_id { get; set; }
        public List<GetViewThuVienVideo> getViews { get; set; }
    }
    public class GetViewThuVienVideo
    {
        public int lop_id { get; set; }
        public string lop_name { get; set; }
        public int khoi_id { get; set; }
    }
}
