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
        public int IntroMenuId {get;set;}
        public string IntroMenuTitleDefault {get;set;}
    }
    public class MenuTinTuc{
        public int NewCateId {get;set;}
        public string Title{get;set;}
    }
    
    }