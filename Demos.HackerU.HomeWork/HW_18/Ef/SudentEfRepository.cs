using Demos.HackerU.HomeWork.HW_18.Db;
using Demos.HackerU.HomeWork.Inhheritance;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18.Ef
{
    public class SudentEfRepository : ISudentRepository
    {
        private static SudentEfRepository Instance = null;
        public SudentEfRepository()
        {

        }
        public static SudentEfRepository GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SudentEfRepository();
            }
            return Instance;
        }

        public bool AddNewStudent(StudentModel student)
        {
            int rowAffected = 0;
            using (StudentEfContext db = new StudentEfContext())
            {
                db.students.Add(student);
                rowAffected = db.SaveChanges();
            }
            return rowAffected > 0;
        }

        public void DeleteStudentByID(int id)
        {
            using (StudentEfContext db = new StudentEfContext())
            {
                var founStu = db.students.SingleOrDefault(x => x.Id == id);
                if (founStu != null)
                {
                    db.students.Remove(founStu);
                    db.SaveChanges();
                }
            }
        }

        public List<StudentModel> GetAllStudents()
        {
            var list = new List<StudentModel>();
            using (StudentEfContext db = new StudentEfContext())
            {
                list = db.students.ToList();
                return list;
            }

        }

        public List<StudentModel> GetAllStudentsByCours(string courseName)
        {
            var list = new List<StudentModel>();
            using (StudentEfContext db = new StudentEfContext())
            {
                list = db.students.Where(x => x.CourseName == courseName).ToList();
                return list;
            }
        }

        public StudentModel GetStudentById(int id)
        {
            StudentModel? student = new StudentModel();
            using (StudentEfContext db = new StudentEfContext())
            {
                student = db.students.SingleOrDefault(item => item.Id == id);
                return student;


            }
        }

        public void SaveLastStudentToFile()
        {
            throw new NotImplementedException();
        }

        public void UpDateStudentByID(int id, StudentModel studentToUpDate)
        {
            using (StudentEfContext db = new StudentEfContext())
            {
                var s1 = db.students.SingleOrDefault(item => item.Id == id);
                if (s1 != null)
                {
                    s1.Address = studentToUpDate.Address;                    s1.City = studentToUpDate.City;                    s1.Email = studentToUpDate.Email;                    s1.CourseName = studentToUpDate.CourseName;                    s1.Id = studentToUpDate.Id;                    s1.IdNum = s1.IdNum;                    s1.LastName = studentToUpDate.LastName;                    s1.FirstName = studentToUpDate.FirstName;                    s1.GradeAvg = studentToUpDate.GradeAvg;                    s1.StartCourseDate = studentToUpDate.StartCourseDate;                    s1.Tel = studentToUpDate.Tel;                    db.SaveChanges();
                }
            }
        }
    }
}
