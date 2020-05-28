using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class ThuVienAnhModel
    {
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public int lop_id { get; set; }
        public string lop_name { get; set; }
        public int khoi_id { get; set; }
        public List<GetViewThuVienAnh> getViews { get; set; }
        public List<GetViewAnh> getViewAnhs { get; set; }
    }
    public class GetViewThuVienAnh
    {
        public int lop_id { get; set; }
        public string lop_name { get; set; }
        public int khoi_id { get; set; }
    }
     public class GetViewAnh
    {
        public int thuvienanh_id { get; set; }
        public string thuvienanh_image { get; set; }
       
    }

}
