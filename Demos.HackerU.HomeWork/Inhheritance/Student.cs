using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Inhheritance
{
    public class Student : Person
    {
        public string StudyClass;
        public StudentType studentType;

        public Student() : base()
        {
            StudyClass = "No Class";
            studentType = StudentType.None;
        }


        public Student(string studyClass, string address, int age, string city, string name, StudentType type) : base(address, name, age, city)
        {
            StudyClass = studyClass;
            studentType = type;
        }


        public new void DisplayInfoToConsole()
        {
            base.DisplayInfoToConsole();
            Console.WriteLine($"Student:\nStudyClass :{StudyClass} ,Type :{studentType}\n");

        }


    }

    public enum StudentType
    {
        None,
        ComputerScience,
        physics,
        Biology

    }


}