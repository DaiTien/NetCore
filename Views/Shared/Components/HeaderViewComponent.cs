using Microsoft.AspNetCore.Mvc;
using netCore.Models;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
public class HeaderViewComponent : ViewComponent
{
    private readonly ConnectionString _connectionString;

        public HeaderViewComponent(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
    public IViewComponentResult Invoke()
    {
        MenuViewModel menu = new MenuViewModel();
        menu.Image1 = "Đăng nhập";
        menu.menu1 ="Trang Chủ";
        menu.menu2="Giới Thiệu";
        menu.menu3 ="Tin Tức";
        menu.menu4 ="Thư Viện";
        const string query = @"select * from tbintroducemenu";

            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var result = conn.Query<MenuGioiThieu>(query);
                //
                menu.menuGioiThieu = new List<MenuGioiThieu>();
                menu.menuGioiThieu = result.ToList();
            }
            const string query2 = @"select * from tbnewscate";

            using (var conn2 = new SqlConnection(_connectionString.Value))
            {
                var result2 = conn2.Query<MenuTinTuc>(query2);
                //
                menu.menuTinTuc = new List<MenuTinTuc>();
                menu.menuTinTuc = result2.ToList();
            }
        return View(menu);
    }
}