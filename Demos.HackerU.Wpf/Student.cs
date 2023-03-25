using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Demos.HackerU.Wpf
{
    public class Student
    {
        public  Student() 
        {
            Name = "<No Name>";
            Id = "<No ID>";
            Grade = 0;
        }

        public Student(string name, string id, int grade)
        {
            Name = name;
            Id = id;
            Grade = grade;
        }


        //Property
        public string Name { get; set; }
        public string Id { get;  set; }
        public int Grade { get; set; }

        public string ShowStudent()
        {
            string displayInfo = $"{Id}-{Name}-({Grade})";
            return displayInfo;
        }
        public  bool IsFailed()
        {
            return (Grade <= 55);
        }






    }
}
