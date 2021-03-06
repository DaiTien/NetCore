using netCore.Models;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data;
namespace netCore.Repository{
    public class GioiThieuRepository : IGioiThieu
    {
        private readonly ConnectionString _connectionString;

        public GioiThieuRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
        public IndexGioiThieuModel GetGioiThieu()
        {
            const string query = @"select * from IntroduceMenu";


            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var result = conn.Query<ClassTitleCon>(query);
                //
            IndexGioiThieuModel titleGioithieu = new IndexGioiThieuModel();
            titleGioithieu.Title2 = new List<ClassTitleCon>();
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
            // ClassTitleCon titleCon = new ClassTitleCon();
            // titleCon.Con1=result;
            // titleCon.Con2 ="CƠ CẤU HỆ THỐNG";
            // titleCon.Con3 ="ĐỐI TÁC";
            // titleCon.Con4 ="THÀNH TỰU";
            // titleCon.Con5="CƠ SỞ VẬT CHẤT";
            titleGioithieu.Title2 = result.ToList();
                //return result;
                return titleGioithieu;
            }
            //
        }
        public void GetGioiThieuII()
        {
            int intromenuId = 2;
            string intromenuTitle ="Giáo Viên";
            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@IntromenuId", intromenuId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@IntromenuTitle", intromenuTitle, dbType: DbType.String, direction: ParameterDirection.Input);
                var results = conn.QueryMultiple("uspGetGioiThieuData", parameters, commandType: CommandType.StoredProcedure);
                var intromenus = results.Read<GioiThieuII>();
                var introId = results.Read<int>();
                var introTitle = results.Read<string>();
            }

        }
    }
}