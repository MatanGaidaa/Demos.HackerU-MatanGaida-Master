﻿namespace Demos.HackerU.HomeWork.HW_18.Db
{
    public interface ISudentRepository
    {
        bool AddNewStudent(StudentModel student);
        void DeleteStudentByID(int id);
        List<StudentModel> GetAllStudents();
        List<StudentModel> GetAllStudentsByCours(string courseName);
        StudentModel GetStudentById(int id);
        void SaveLastStudentToFile();
        void UpDateStudentByID(int id, StudentModel studentToUpDate);
    }
}