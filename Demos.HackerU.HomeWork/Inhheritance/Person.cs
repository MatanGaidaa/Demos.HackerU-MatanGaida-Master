using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Inhheritance
{
    public class Person
    {

        public string Address;
        public string Name;
        public int Age;
        public string City;

        public Person()
        {
            Address = "No Addres";
            Name = "No Name";
            Age = 0;
            City = "No City";
        }

        public Person(string address, string name, int age, string city)
        {
            Address = address;
            Name = name;
            Age = age;
            City = city;
        }
        public void DisplayInfoToConsole()
        {
            Console.WriteLine($"Person:\nName :{Name}\nAge :{Age}\nCity :{City}\nAddres :{Address}");
        }
    }
}
