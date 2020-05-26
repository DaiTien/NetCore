using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class MenuViewModel
    {
        
        //
        public string Image1 { get; set; }
        public string menu1 { get; set; }
        public string menu2 { get; set; }
        public string menu3 { get; set; }
        public string menu4 { get; set; }
        public List<MenuGioiThieu> menuGioiThieu {get;set;}
        public List<MenuTinTuc> menuTinTuc{get;set;}
    }
    public class MenuGioiThieu{
        public int intromenu_id {get;set;}
        public string intromenu_titledefault {get;set;}
    }
    public class MenuTinTuc{
        public int newscate_id {get;set;}
        public string newscate_title{get;set;}
    }
    
    }