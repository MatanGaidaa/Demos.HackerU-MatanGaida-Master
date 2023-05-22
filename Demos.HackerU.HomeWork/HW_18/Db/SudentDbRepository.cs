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
            List<StudentModel> list = new List<StudentModel>();

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

            list = list.FindAll(course => course.CourseName == courseName);
            return list;
        }

        public StudentModel GetStudentById(int id)
        {
            StudentModel student = new StudentModel();
            List<StudentModel> list = new List<StudentModel>();
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

            student = list.Find(Id => Id.Id == id);

            return student;
        }

        public void UpDateStudentByID(int idNum, StudentModel studentToUpDate)
        {
            //			UPDATE Customers
            //SET ContactName = 'Alfred Schmidt', City = 'Frankfurt'
            //WHERE CustomerID = 1;
            string queryInsert = "UPDATE Student SET " +
                                 "FirstName=@firstName, " +
                                 "LastName =@lastName, " +
                                 "Email=@email, " +
                                 "CourseName=@courseName," +
                                 "Tel=@tel," +
                                 "City=@city," +
                                 "Address=@address," +
                                 "StartCourseDate=@startCourseDate," +
                                 "GradeAvg=@gradeAvg" +
                                 $" WHERE IdNum={idNum}";
            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(queryInsert, con);
                //Here we will insert the correct values into the placeholders via the commands
                //parameters
                cmd.Parameters.AddWithValue($"{idNum}", studentToUpDate.Id);
                cmd.Parameters.AddWithValue("@idNum", studentToUpDate.IdNum);
                cmd.Parameters.AddWithValue("@firstName", studentToUpDate.FirstName);
                cmd.Parameters.AddWithValue("@lastName", studentToUpDate.LastName);
                cmd.Parameters.AddWithValue("@email", studentToUpDate.Email);
                cmd.Parameters.AddWithValue("@courseName", studentToUpDate.CourseName);
                cmd.Parameters.AddWithValue("@tel", studentToUpDate.Tel);
                cmd.Parameters.AddWithValue("@city", studentToUpDate.City);
                cmd.Parameters.AddWithValue("@address", studentToUpDate.Address);
                cmd.Parameters.AddWithValue("@startCourseDate", studentToUpDate.StartCourseDate);
                cmd.Parameters.AddWithValue("@gradeAvg", studentToUpDate.GradeAvg);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudentByID(int id)
        {
            string queryDelete = "DELETE FROM Student WHERE id=@idParam";

            using (var con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(queryDelete, con);
                //Here we will insert the correct values into the placeholders via the commands
                //parameters

                cmd.Parameters.AddWithValue("@idParam", id);

                //INSERT/DELETE/UPDATE use ExecuteNonQuery
                cmd.ExecuteNonQuery();

            }
        }
        public void SaveLastStudentToFile(StudentModel lastStudentInList, StudentModel lastStudentInCourse)
        {

        }


    }
}
