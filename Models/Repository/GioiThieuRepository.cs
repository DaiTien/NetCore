using netCore.Models;
using System.Collections.Generic;
namespace netCore.Repository{
    public class GioiThieuRepository : IGioiThieu
    {
        public IndexGioiThieuModel GetGioiThieu()
        {
            IndexGioiThieuModel titleGioithieu = new IndexGioiThieuModel();
            titleGioithieu.Title = new List<ClassTitleCon>();
            titleGioithieu.Image1="/assets/images/editorimages/h2.jpg";
            titleGioithieu.Image2 ="/assets/images/editorimages/h1.jpg";
            titleGioithieu.Image3="/assets/images/editorimages/co-cau-bo-may-truong-viet-nhat.jpg";
            titleGioithieu.Image4="/assets/images/editorimages/h2(1).jpg";
            titleGioithieu.Image5="/assets/images/editorimages/h1(2).png";
            titleGioithieu.Image6="/assets/images/editorimages/h3(1).png";
            titleGioithieu.Image7="/assets/images/editorimages/h3_1.jpg";
            titleGioithieu.Image8="/assets/images/editorimages/h1.png";
            titleGioithieu.Image9="/assets/images/editorimages/h3(1).jpg";
            titleGioithieu.Image10="/assets/images/editorimages/h6.jpg";
            ClassTitleCon titleCon = new ClassTitleCon();
            titleCon.Con1="ĐỘI NGŨ GIÁO VIÊN";
            titleCon.Con2 ="CƠ CẤU HỆ THỐNG";
            titleCon.Con3 ="ĐỐI TÁC";
            titleCon.Con4 ="THÀNH TỰU";
            titleCon.Con5="CƠ SỞ VẬT CHẤT";
            titleGioithieu.Title.Add(titleCon);
            return titleGioithieu;
        }
    }
}