using Demos.HackerU.HomeWork.HW_18.Db;
using Demos.HackerU.HomeWork.HW_18.Ef;
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
            //    ISudentRepository studentRepo = new SudentDbRepository();
            //    studentRepo = new SudentEfRepository();

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

            Display();

        }
        /// <summary>
        /// call db and ef chosse menu
        /// and call show menu func
        /// </summary>
        public static void Display()
        {
            string select = MainMenu();
            ShowMenu(select);
        }

        /// <summary>
        /// show manues options
        /// </summary>
        /// <returns>wich menu to show</returns>
        private static string MainMenu()
        {
            Console.WriteLine("\n--------------------------");
            Console.WriteLine("\nSQL Menu");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("Sql DB Menu | (press 1)");
            Console.WriteLine("Sql Ef Menu | (press 2) ");
            Console.Write("\r\nSelect an option: ");
            bool isContinue = true;
            string select = "";
            while (isContinue)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        isContinue = false;
                        return select = "1";
                    case "2":
                        isContinue = false;
                        return select = "2";
                    default:
                        Console.Write("\r\nSelect an option: ");
                        break;
                }
            }
            return select;
        }

        /// <summary>
        /// show the menu selected
        /// </summary>
        /// <param name="select"></param>
        private static void ShowMenu(string select)
        {
            bool isContinue = true;
            while (isContinue)
            {
                isContinue = Menus(select);
            }

        }

        /// <summary>
        /// peek a menu from the varible that was given
        /// </summary>
        /// <param name="select"></param>
        /// <returns></returns>
        private static bool Menus(string select)
        {
            switch (select)
            {
                case "1":
                    return SqlDb(new SudentDbRepository());
                case "2":
                    return SqlEF(SudentEfRepository.GetInstance());
                default:
                    return false;
            }
        }


        private static bool SqlEF(ISudentRepository studentEf)
        {
            ChoseData();
            switch (Console.ReadLine())
            {
                case "1":
                    StudentModel studentModel = new StudentModel(1, "Matan", "Gaida", "Matan@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
                    studentEf.AddNewStudent(studentModel);
                    return true;
                case "2":
                    var sudentList = studentEf.GetAllStudents();
                    foreach (var student in sudentList)
                    {
                        Console.WriteLine(student);
                    };
                    return true;
                case "3":
                    sudentList = studentEf.GetAllStudentsByCours("FullStack");
                    foreach (var student in sudentList)
                    {
                        Console.WriteLine("\n" + student);
                    }
                    return true;

                case "4":
                    Console.Write("\nEnter Id:");
                    int id = int.Parse(Console.ReadLine());
                    StudentModel student1 = studentEf.GetStudentById(id);
                    if (student1 != null)
                    {
                        Console.WriteLine("\n" + student1);
                    }
                    else
                    {
                        Console.WriteLine("\nstudent dont exist");
                    }

                    return true;
                case "5":
                    StudentModel studentModel6 = new StudentModel(3, 3, "David", "Atar", "Roi@gmail.com", "DBFull", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
                    studentEf.UpDateStudentByID(4, studentModel6);
                    return true;
                case "6":
                    studentEf.DeleteStudentByID(4);
                    return true;
                case "7":
                    studentEf.SaveLastStudentToFile();
                    return true;
                case "8":
                    Display();
                    return false;
                case "9":
                    return false;
                default:
                    return true;
            }
        }

        private static bool SqlDb(ISudentRepository studentDb)
        {
            ChoseData();
            switch (Console.ReadLine())
            {
                case "1":
                    //FunctionsOpration.AddNewStudent();
                    StudentModel studentModel = new StudentModel(2, "Matan", "Gaida", "Matan@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
                    studentDb.AddNewStudent(studentModel);
                    return true;
                case "2":
                    var sudentList = studentDb.GetAllStudents();
                    foreach (var student in sudentList)
                    {
                        Console.WriteLine(student);
                    };
                    return true;
                case "3":
                    sudentList = studentDb.GetAllStudentsByCours("FullStack");
                    foreach (var student in sudentList)
                    {
                        Console.WriteLine("\n" + student);
                    }
                    return true;

                case "4":
                    Console.Write("\nEnter Id:");
                    int id = int.Parse(Console.ReadLine());
                    StudentModel student1 = studentDb.GetStudentById(id);
                    if (student1 != null)
                    {
                        Console.WriteLine("\n" + student1);
                    }
                    else
                    {
                        Console.WriteLine("\nstudent dont exist");
                    }

                    return true;
                case "5":
                    StudentModel studentModel6 = new StudentModel(3, 3, "David", "Atar", "Roi@gmail.com", "DBFull", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
                    studentDb.UpDateStudentByID(4, studentModel6);
                    return true;
                case "6":
                    studentDb.DeleteStudentByID(4);
                    return true;
                case "7":
                    studentDb.SaveLastStudentToFile();
                    return true;
                case "8":
                    Display();
                    return false;
                case "9":
                    return false;
                default:
                    return true;
            }



        }

        private static void ChoseData()
        {

            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("Insert New Student | (press 1)");
            Console.WriteLine("Show All Students | (press 2) ");
            Console.WriteLine("Show Students By Course Name | (press 3)");
            Console.WriteLine("Show Students By Id | (press 4)");
            Console.WriteLine("Update Student By Id | (press 5)");
            Console.WriteLine("Delete Student By Id | (press 6)");
            Console.WriteLine("Save Last Result to JSON File | (press 7)");
            Console.WriteLine("Return to SQL Menu | (press 9)");
            Console.WriteLine("Exit | (press 8)");
            Console.Write("\r\nSelect an option: ");
        }
    }
}
