using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18
{
    public class StudentModel
    {

        public int Id { get; set; }
        public int IdNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string CourseName { get; set; }
        public string? Tel { get; set; }
        public string City { get; set; }
        public string Address { get; set; }
        public DateTime StartCourseDate { get; set; }
        public float GradeAvg { get; set; }

        public StudentModel()
        {

        }
        public StudentModel(int idNum, string firstName, string lastName, string? email, string courseName, string? tel, string city, string address, DateTime startCourseDate, float gradeAvg)
        {

            IdNum = idNum;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CourseName = courseName;
            Tel = tel;
            City = city;
            Address = address;
            StartCourseDate = startCourseDate;
            GradeAvg = gradeAvg;
        }
        public StudentModel(int id, int idNum, string firstName, string lastName, string? email, string courseName, string? tel, string city, string address, DateTime startCourseDate, float gradeAvg)
        {
            Id = id;
            IdNum = idNum;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CourseName = courseName;
            Tel = tel;
            City = city;
            Address = address;
            StartCourseDate = startCourseDate;
            GradeAvg = gradeAvg;
        }
        public override string ToString()        {            return $"Id: {Id},\nIdNum: {IdNum},\nFirstName: {FirstName},\nLastName: {LastName},\nEmail: {Email},\nCourseName: {CourseName},\nTel: {Tel},\nCity: {City},\nAddress: {Address},\nStartCourseDate: {StartCourseDate},\nGradeAvg: {GradeAvg}\n";        }
    }
}
