using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Inhheritance
{
    public class Employe : Person
    {
        public string Department;
        public int Salery;

        public Employe() : base()
        {
            Department = "No Department";
            Salery = 0;
        }



        public Employe(string department, int salery, string address, int age, string city, string name) : base(address, name, age, city)
        {
            Department = department;
            Salery = salery;
        }

        public new void DisplayInfoToConsole()
        {
            base.DisplayInfoToConsole();
            Console.WriteLine($"Employe:\nDepartment : {Department} ,Salery:{Salery}\n");

        }

    }
}
