using Demos.HackerU.HomeWork.Inhheritance;
using Microsoft.Data.SqlClient;
using Microsoft.VisualBasic;
using Nest;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18.Db
{
    public class SudentDbRepository : ISudentRepository
    {
        readonly string connectionString;

        public SudentDbRepository()
        {
            connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=HW18_DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False";
        }

        public SudentDbRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public bool AddNewStudent(StudentModel student)
        {
            int rowAffected = 0;
            string queryInsert = "INSERT INTO Student (IdNum,FirstName, LastName,Email,CourseName,Tel,City,Address,StartCourseDate,GradeAvg) " +
                                  "VALUES (@idNum,@firstName,@lastName,@email,@courseName,@tel,@city,@address,@startCourseDate,@gradeAvg)";

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(queryInsert, con);
                //Here we will insert the correct values into the placeholders via the commands
                //parameters

                cmd.Parameters.AddWithValue("@idNum", student.IdNum);
                cmd.Parameters.AddWithValue("@firstName", student.FirstName);
                cmd.Parameters.AddWithValue("@lastName", student.LastName);
                cmd.Parameters.AddWithValue("@email", student.Email);
                cmd.Parameters.AddWithValue("@courseName", student.CourseName);
                cmd.Parameters.AddWithValue("@tel", student.Tel);
                cmd.Parameters.AddWithValue("@city", student.City);
                cmd.Parameters.AddWithValue("@address", student.Address);
                cmd.Parameters.AddWithValue("@startCourseDate", student.StartCourseDate);
                cmd.Parameters.AddWithValue("@gradeAvg", student.GradeAvg);


                //INSERT/DELETE/UPDATE use ExecuteNonQuery
                rowAffected = cmd.ExecuteNonQuery();

            }
            return (rowAffected > 0);

        }
        public List<StudentModel> GetAllStudents()
        {

            List<StudentModel> list = new List<StudentModel>();
            //1) Create Connection using connectionstring
            var con = new SqlConnection(connectionString);
            try
            {
                //2) CREATE SQL COMMAND  
                string query = "SELECT * FROM Student";
                SqlCommand cmd = new SqlCommand(query, con);

                //3) Open Connection
                con.Open();

                //4) EXecute Command And Get Reader
                SqlDataReader dbReader = cmd.ExecuteReader();

                //5) Use Reader to read each row in a loop
                //true while row is not EOF of ROWS Data
                while (dbReader.Read()) //Single row for each iteration
                {

                    //If Value is Null
                    object emailVal = dbReader.GetString(4);
                    object email = (emailVal == DBNull.Value || emailVal == null) ? "" : emailVal;

                    object telVal = dbReader.GetString(6);
                    object tel = (telVal == DBNull.Value || telVal == null) ? "" : telVal;

                    StudentModel studentModel = new StudentModel
                    {
                        Id = dbReader.GetInt32(0),
                        IdNum = dbReader.GetInt32(1),
                        FirstName = dbReader.GetString(2),
                        LastName = dbReader.GetString(3),
                        Email = (string)email,
                        CourseName = dbReader.GetString(5),
                        Tel = (string)tel,
                        City = dbReader.GetString(7),
                        Address = dbReader.GetString(8),
                        StartCourseDate = dbReader.GetDateTime(9),
                        GradeAvg = (float)dbReader.GetDouble(10)
                    };
                    list.Add(studentModel);
                }

                dbReader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                if (con.State != ConnectionState.Closed)
                {
                    con.Close();
                }
            }

            return list;
        }

        public List<StudentModel> GetAllStudentsByCours(string courseName)
        {
            //Show Students in the same Course and grade avg in course
            return new List<StudentModel>();
        }

        public StudentModel GetStudentById()
        {
            return new StudentModel();
        }

        public void UpDateStudentByID(int id)
        {

        }

        public void DeleteStudentByID(int id)
        {

        }
        public void SaveLastStudenttoFile()
        {

        }


    }
}
