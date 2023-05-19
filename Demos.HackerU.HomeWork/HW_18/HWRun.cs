using Demos.HackerU.HomeWork.HW_18.Db;
using Demos.HackerU.HomeWork.Inhheritance;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18
{
    public class HW18Run
    {
        public static void Run()
        {
            ISudentRepository studentRepo = new SudentDbRepository();

            //StudentModel studentModel1 = new StudentModel(2, 2, "Matan", "Gaida", "Matan@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            //StudentModel studentModel2 = new StudentModel(3, 3, "Roi", "Atar", "Roi@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            //StudentModel studentModel3 = new StudentModel(3, 3, "Roi", "Atar", "Roi@gmail.com", "C#", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            //StudentModel studentModel4 = new StudentModel(3, 3, "Roi", "Atar", "Roi@gmail.com", "C#", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            //StudentModel studentModel5 = new StudentModel(3, 3, "Roi", "Atar", "Roi@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            //StudentModel[] StudentArr = new StudentModel[] { studentModel1, studentModel2, studentModel3, studentModel4, studentModel5 };
            //foreach (var item in StudentArr)
            //{
            //    studentRepo.AddNewStudent(item);
            //}

            //var sudentList = studentRepo.GetAllStudents();

            //   studentRepo.GetAllStudentsByCours("C#");
            //  studentRepo.GetStudentById(1009);

            //StudentModel studentModel6 = new StudentModel(4, 3, "David", "Atar", "Roi@gmail.com", "DBFull", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            //studentRepo.UpDateStudentByID(4, studentModel6);
            //studentRepo.DeleteStudentByID(3);

            ShowMenu(studentRepo);

        }

        private static void ShowMenu(ISudentRepository studentRepo)
        {
            bool isContinue = true;
            while (isContinue)
                isContinue = NewMethod(studentRepo);
        }

        private static bool NewMethod(ISudentRepository studentRepo)
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("Insert New Student | (press 1)");
            Console.WriteLine("Show All Students | (press 2) ");
            Console.WriteLine("Show Students By Course Name | (press 3)");
            Console.WriteLine("Show Students By Id | (press 4)");
            Console.WriteLine("Update Student By Id | (press 5)");
            Console.WriteLine("Delete Student By Id | (press 6)");
            Console.WriteLine("Save Last Result to JSON File | (press 7)");
            Console.WriteLine("Exit | (press 8)");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    StudentModel studentModel = new StudentModel(2, 2, "Matan", "Gaida", "Matan@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
                    studentRepo.AddNewStudent(studentModel);
                    return true;
                case "2":
                    var sudentList = studentRepo.GetAllStudents();
                    foreach (var student in sudentList)
                    {
                        Console.Write($"Id: {student.Id}, IdNum: {student.IdNum}, Full Name: {student.FirstName} {student.LastName}, Email: {student.Email}, Course: {student.CourseName}, Tel: {student.Tel}, City: {student.City}, Address: {student.Address}, Date: {student.StartCourseDate}, Avg: {student.GradeAvg}");
                    }
                    return true;
                case "3":
                    sudentList = studentRepo.GetAllStudentsByCours("FullStack");
                    foreach (var student in sudentList)
                    {
                        Console.Write($"Id: {student.Id}, IdNum: {student.IdNum}, Full Name: {student.FirstName} {student.LastName}, Email: {student.Email}, Course: {student.CourseName}, Tel: {student.Tel}, City: {student.City}, Address: {student.Address}, Date: {student.StartCourseDate}, Avg: {student.GradeAvg}");
                    }
                    return true;

                case "4":
                    StudentModel student1 = studentRepo.GetStudentById(3);
                    Console.Write($"Id: {student1.Id}, IdNum: {student1.IdNum}, Full Name: {student1.FirstName} {student1.LastName}, Email: {student1.Email}, Course: {student1.CourseName}, Tel: {student1.Tel}, City: {student1.City}, Address: {student1.Address}, Date: {student1.StartCourseDate}, Avg: {student1.GradeAvg}");
                    return true;
                case "5":
                    StudentModel studentModel6 = new StudentModel(3, 3, "David", "Atar", "Roi@gmail.com", "DBFull", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
                    studentRepo.UpDateStudentByID(4, studentModel6);
                    return true;
                case "6":
                    studentRepo.DeleteStudentByID(4);
                    return true;

                case "7":
                    return false;
                default:
                    return true;
            }


            return true;
        }
    }
}
