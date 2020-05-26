using Microsoft.AspNetCore.Mvc;
using netCore.Models;
public class HeaderViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        MenuViewModel menu = new MenuViewModel();
        menu.Image1 = "abs";
            return View(menu);
    }
}