using System;
using System.Collections.Generic;

namespace netCore.Models
{
    public class IndexGioiThieuModel
    {
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string Image5 { get; set; }
        public string Image6 { get; set; }
        public string Image7 { get; set; }
        public string Image8 { get; set; }
        public string Image9 { get; set; }
        public string Image10 { get; set; }

        // public DateTime Today{ get; set; }
        public List<ClassTitleCon> Title { get; set; }
        // public List<ClassImages> Image {get;set;}
    }
    public class ClassTitleCon
    {
         public string Con1 { get; set; }

        public string Con2{ get; set; }
        public string Con3{ get; set; }
        public string Con4{ get; set; }
        public string Con5{ get; set; }
    }
    // public class ClassImages{
    //     public string img1{get;set;}
    //     public string img2{get;set;}
    //     public string img3{get;set;}
    //     public string img4{get;set;}
        
    //     public string img5{get;set;}
    //     public string img6{get;set;}
    //     public string img7{get;set;}
    //     public string img8{get;set;}
    //     public string img9{get;set;}
        
    //     public string img10{get;set;}
    // }
}
