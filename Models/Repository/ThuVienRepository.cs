using System.Collections.Generic;
using System.Linq;
using Dapper;
using Microsoft.Data.SqlClient;
using netCore.Models;
using System.Data;
using NetCore.Models.DataModel;

namespace netCore.Repository {
    public class ThuVienRepository : IThuVienVideo {
        private readonly ConnectionString _connectionString;

        public ThuVienRepository (ConnectionString connectionString) {
            _connectionString = connectionString;
        }
        public ThuVienVideoModel GetThuVienVideoI () {

            const string query = @"select * from tblop";

            using (var conn = new SqlConnection (_connectionString.Value)) {
                var result = conn.Query<GetViewThuVienVideo> (query);

                ThuVienVideoModel thuVienVideoModel = new ThuVienVideoModel ();
                thuVienVideoModel.getViews = result.ToList ();
                return thuVienVideoModel;
            }
        }
        public void GetStudentInClassI() {
            int studentId = 1;
            string studentName = "trung nguyen";
            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@StudentId", studentId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@StudentName", studentName, dbType: DbType.String, direction: ParameterDirection.Input);
                var results = conn.Query<Student>("GetAllStudentInClass", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}