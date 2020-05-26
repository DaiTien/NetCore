using Microsoft.AspNetCore.Mvc;
using netCore.Models;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
public class FooterViewComponent : ViewComponent
{
     
    public IViewComponentResult Invoke()
    {
          
                FooterViewModel footer = new FooterViewModel();
                footer.lienhe_title ="TRƯỜNG MẦM NON VIỆT NHẬT - CƠ SỞ 1";
                 footer.lienhe_address ="231/5 Lê Duẩn, Tân Chính, Thanh Khê, Đà Nẵng";
                 footer.lienhe_phone ="02363 827 272 123123";
                 footer.lienhe_map ="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d30674.169156878685!2d108.20539967388724!3d16.0514134390719!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3142184a3ae229f5%3A0xf364eb13cba7436f!2zVHLGsOG7nW5nIE3huqdtIG5vbiBWaeG7h3QgTmjhuq10!5e0!3m2!1svi!2s!4v1576159975537!5m2!1svi!2s";
            return View(footer);
    }
}