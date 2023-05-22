using Demos.HackerU.HomeWork.Inhheritance;
using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18
{
    public class FunctionsOpration
    {

        /// <summary>
        /// adding new stydent
        /// </summary>
        /// <returns></returns>
        public static StudentModel AddNewStudent()
        {
            bool isOk;
            Console.WriteLine("Id-Num: ");
            isOk = int.TryParse(Console.ReadLine(), out int idNum);
            while (!isOk)
            {
                Console.WriteLine("Error : Must be a number!");
                Console.Write("Try Again :)\nId-Num: ");
                isOk = int.TryParse(Console.ReadLine(), out idNum);
            }
            Console.WriteLine("First Name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Email Address: ");
            string email = Console.ReadLine();

            Console.WriteLine("Course Name: ");
            string courseName = Console.ReadLine();

            Console.WriteLine("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("City: ");
            string city = Console.ReadLine();

            Console.WriteLine("Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Average (Must be between 0-100): ");
            isOk = int.TryParse(Console.ReadLine(), out int avg);
            while (!isOk && avg > 0 && avg <= 100)
            {
                Console.WriteLine("Error : Must be a number! && between 0-100!");
                Console.Write("Try Again!\nAverage: ");
                isOk = int.TryParse(Console.ReadLine(), out avg);
            }
            StudentModel studentModel = new StudentModel(idNum, firstName, lastName, email, courseName, phoneNumber, city, address, DateTime.Now, avg);

            return studentModel;
        }


        public static string ShowAllStudents(List<StudentModel> allStudentsList)
        {
            int count = 1;
            var distinctList = allStudentsList
                     .GroupBy(s => s.CourseName)    // group by names
                     .Select(g => g.First());       // take the first group
            Console.WriteLine();
            Console.WriteLine("Courses Options:");
            Console.WriteLine("----------------");
            foreach (var item in distinctList)
            {
                Console.WriteLine($"{count}) {item.CourseName}");
                count++;
            }
            Console.Write("\nEnter Course Name:");
            string? courseEntered = Console.ReadLine();
            while (courseEntered == null || courseEntered == "")
            {
                Console.WriteLine("\nError: Cannot be Empty Try again!");
                Console.Write("Enter Course Name:");
                courseEntered = Console.ReadLine();
            }
            return courseEntered;
        }

        public static int GetStudentIdChecked(List<StudentModel> allStudentsList)
        {
            Console.Write("\nEnter Id:");
            bool isOk = int.TryParse(Console.ReadLine(), out int id);
            while (true)
            {
                if (!isOk)
                {
                    Console.WriteLine("\nError: Cannot be Empty Try again!");
                    Console.Write("Enter Id:");
                    isOk = int.TryParse(Console.ReadLine(), out id);
                }
                else
                {
                    var student = allStudentsList.SingleOrDefault(s => s.Id == id);
                    if (student == null)
                    {
                        Console.WriteLine("\nError: Id doesn't Exist Try again!");
                        Console.Write("Enter Id:");
                        isOk = int.TryParse(Console.ReadLine(), out id);
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return id;
        }

        public static StudentModel[]? SaveTOFileParam(StudentModel student)
        {
            StudentModel[]? st = new StudentModel[2] { null, null };
            if (st[0] == null)
            {
                st[0] = student;
            }
            else if (st[1] == null)
            {
                st[1] = student;
            }
            return st;
        }
    }
}
