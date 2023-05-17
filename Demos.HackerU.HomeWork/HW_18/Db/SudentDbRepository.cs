using Demos.HackerU.HomeWork.Inhheritance;
using Microsoft.VisualBasic;
using Nest;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18.Db
{
    public class SudentDbRepository : ISudentRepository, ISudentDbRepository
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

        public void AddNewStudent(StudentModel student)
        {

        }
        public List<StudentModel> GetAllStudents()
        {
            return new List<StudentModel>();
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
