using netCore.Models;
using System.Collections.Generic;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Linq;
using System.Data;
namespace netCore.Repository
{
    public class TrangChuRepository : IDemo
    {
        private readonly ConnectionString _connectionString;

        public TrangChuRepository(ConnectionString connectionString)
        {
            _connectionString = connectionString;
        }
        public IndexModelHome GetDemoI()
        {
            IndexModelHome indexModelHome = new IndexModelHome();
            indexModelHome.RequestId = "1";
            indexModelHome.Image = new List<ClassImage>();
            //add image slide
            ClassImage classImage = new ClassImage();
            classImage.ImageName = "/assets/images/anh_slide/slide1.jpg";
            indexModelHome.Image.Add(classImage);
            ClassImage classImage2 = new ClassImage();
            classImage2.ImageName = "/assets/images/anh_slide/slide2.jpg";
            indexModelHome.Image.Add(classImage2);
            ClassImage classImage3 = new ClassImage();
            classImage3.ImageName = "/assets/images/anh_slide/slide3.jpg";
            indexModelHome.Image.Add(classImage3);
            ClassImage classImage4 = new ClassImage();
            classImage4.ImageName = "/assets/images/anh_slide/slide4.jpg";
            indexModelHome.Image.Add(classImage4);
            // add 4 cấp 
            indexModelHome.ForLevels = new List<ClassForLevel>();
            ClassForLevel classForLevel1 = new ClassForLevel();
            classForLevel1.ImageName = "/assets/images/mamnon.jpg";
            classForLevel1.Icon = "fab fa-envira";
            classForLevel1.NameFL = "Mầm Non";
            const string query = @"select * from tbslide";

            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var result = conn.Query<IndexModelHome>(query);
                return indexModelHome;
                //return result;
            }
            //return indexModelHome;
        }
        public int GetDemoII()
        {
            return 0;
        }
        public void GetTeacher()
        {
            int teacherId = 1;
            string teacherName = "trung nguyen";
            using (var conn = new SqlConnection(_connectionString.Value))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@Id", teacherId, DbType.Int32, ParameterDirection.Input);
                parameters.Add("@Name", teacherName, dbType: DbType.String, direction: ParameterDirection.Input);
                var results = conn.Query<TeacherModel>("GetMixelData", parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}