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
            videoClassName.NameFilter = ".Lo-p-1.1"
            return thuVienVideoModel; 
        }

    }
}