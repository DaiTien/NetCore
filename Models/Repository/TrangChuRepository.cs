using netCore.Models;
using System.Collections.Generic;
namespace netCore.Repository
{
    public class TrangChuRepository : IDemo
    {
        public IndexModelHome GetDemoI()
        {
            IndexModelHome indexModelHome = new IndexModelHome();
            indexModelHome.RequestId = "1";
            indexModelHome.Image = new List<ClassImage>();
            //add image slide
            ClassImage classImage = new ClassImage();
            classImage.ImageName="/assets/images/anh_slide/slide1.jpg";
            indexModelHome.Image.Add(classImage);
            ClassImage classImage2 = new ClassImage();
            classImage2.ImageName="/assets/images/anh_slide/slide2.jpg";
            indexModelHome.Image.Add(classImage2);
            ClassImage classImage3 = new ClassImage();
            classImage3.ImageName="/assets/images/anh_slide/slide3.jpg";
            indexModelHome.Image.Add(classImage3);
            ClassImage classImage4 = new ClassImage();
            classImage4.ImageName="/assets/images/anh_slide/slide4.jpg";
            indexModelHome.Image.Add(classImage4);
            // add 4 cấp 
             indexModelHome.ForLevels = new List<ClassForLevel>();
             ClassForLevel classForLevel1 = new ClassForLevel();
             classForLevel1.ImageName ="/assets/images/mamnon.jpg";
             classForLevel1.Icon="fab fa-envira";
             classForLevel1.NameFL="Mầm Non";
            return indexModelHome;
        }
        public int GetDemoII()
        {
            return 0;
        }
    }
}