using netCore.Models;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data;
namespace netCore.Repository
{
    public class ThuVienAnhRepository : IThuVienAnh
    {
        private readonly ConnectionString _connectionString;

        public ThuVienAnhRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
        public ThuVienAnhModel GetThuVienAnhI()
        {

            const string query = @"select * from tblop";
            const string query2 = @"select * from tbthuvienanhimage";

            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var result = conn.Query<GetViewThuVienAnh>(query);
                var result2 = conn.Query<GetViewAnh>(query2);
                ThuVienAnhModel thuVienAnhModel = new ThuVienAnhModel();
                thuVienAnhModel.getViews = result.ToList();
                thuVienAnhModel.getViewAnhs = result2.ToList();
                // thuVienAnhModel.Image1 = "/assets/images/thuvienanh/1sno51sc.cdm.jpg";
                // thuVienAnhModel.Image2 = "/assets/images/thuvienanh/2wyv2ufu.2rs.png";
                // thuVienAnhModel.Image3 = "/assets/images/thuvienanh/eeg4bwxg.1ee.jpg";
                return thuVienAnhModel;

            }
        }
        public void GetThuVienAnhImage()
        {
            int thuvienanh_id = 1;
            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var parameter = new DynamicParameters();
                parameter.Add("@thuvienanh_id", thuvienanh_id, DbType.Int32, ParameterDirection.Input);
                var result1 = conn.Query<GetViewAnh>("SelectAllThuVienAnh", parameter, commandType: CommandType.StoredProcedure);
            }
        }

    }
}