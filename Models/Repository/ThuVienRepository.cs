using netCore.Models;
using System.Collections.Generic;
namespace netCore.Repository
{
    public class ThuVienRepository : IThuVienVideo
    {
        public ThuVienVideoModel GetThuVienVideoI()
        {
            ThuVienVideoModel thuVienVideoModel = new ThuVienVideoModel();
            thuVienVideoModel.RequestId = "1";
            thuVienVideoModel.Name = new List<VideoClassName>();
            VideoClassName videoClassName = new VideoClassName();
            videoClassName.NameFilter = ".Lo-p-1.1";
            videoClassName.NameClass ="Lớp 1.1";
            thuVienVideoModel.Name.Add(videoClassName);
            VideoClassName videoClassName1 = new VideoClassName();
            videoClassName1.NameFilter = ".Lo-p-1.2";
            videoClassName1.NameClass ="Lớp 1.2";
            thuVienVideoModel.Name.Add(videoClassName1);
            VideoClassName videoClassName2 = new VideoClassName();
            videoClassName2.NameFilter = ".Lo-p-1.3";
            videoClassName2.NameClass ="Lớp 1.3";
            thuVienVideoModel.Name.Add(videoClassName2);
            VideoClassName videoClassName3 = new VideoClassName();
            videoClassName3.NameFilter = ".Lo-p-1.4";
            videoClassName3.NameClass ="Lớp 1.4";
            thuVienVideoModel.Name.Add(videoClassName3);
            return thuVienVideoModel; 
        }

    }
}