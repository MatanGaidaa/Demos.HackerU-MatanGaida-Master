using Demos.HackerU.HomeWork.Inhheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18
{
    public class FunctionsOpration
    {
        public static bool AddNewStudent()
        {
            bool isOk;
            Console.WriteLine("Id-Num: ");
            isOk = int.TryParse(Console.ReadLine(), out int idNum);
            while (!isOk)
            {
                Console.WriteLine("Error : Must be a number!\n");
                Console.WriteLine("Try Again\nId-Num: ");
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

            Console.WriteLine("Average: ");
            isOk = int.TryParse(Console.ReadLine(), out int avg);
            while (!isOk)
            {
                Console.WriteLine("Error : Must be a number!\n");
                Console.WriteLine("Try Again\nAverage: ");
                isOk = int.TryParse(Console.ReadLine(), out avg);
            }
            StudentModel studentModel = new StudentModel(idNum, firstName, lastName, email, courseName, phoneNumber, city, address, DateTime.Now, avg);

            return isOk;
        }
    }
}
