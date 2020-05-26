using Microsoft.AspNetCore.Mvc;
using netCore.Models;
using netCore.Repository;
public class ThuVienViewComponent : ViewComponent
{
         private IThuVienVideo _thuVienVideo;

        public ThuVienViewComponent( IThuVienVideo thuVienVideo)
        {
            _thuVienVideo = thuVienVideo;
        }
    public IViewComponentResult Invoke()
    {
        ThuVienVideoModel thuVienVideoModel = new ThuVienVideoModel();
            thuVienVideoModel= _thuVienVideo.GetThuVienVideoI();
            return View(thuVienVideoModel);
    }
}