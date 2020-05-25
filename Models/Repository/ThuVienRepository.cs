using netCore.Models;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
namespace netCore.Repository
{
    public class ThuVienRepository : IThuVienVideo
    {
        private readonly ConnectionString _connectionString;

        public ThuVienRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
        public ThuVienVideoModel GetThuVienVideoI()
        {

            const string query = @"select * from tblop";

            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var result = conn.Query<GetViewThuVienVideo>(query);

                ThuVienVideoModel thuVienVideoModel = new ThuVienVideoModel();
                thuVienVideoModel.getViews = result.ToList();
                return thuVienVideoModel;

            }
        }

    }
}