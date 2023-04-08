using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.Wpf
{

    /// <summary>
    /// 
    /// </summary>
    public interface IStudentsRepository
    {

        Student GetStudent(string id);

        /// <summary>
        /// Add New Student
        /// </summary>
        /// <param name="student"></param>
        void AddStudent(Student student);

        /// <summary>
        /// Update Student
        /// </summary>
        /// <param name="student"></param>
        void UpdateStudent(Student student);

        /// <summary>
        /// Remove Student
        /// </summary>
        /// <param name="id"></param>
        void RemoveStudent(string id);

        /// <summary>
        /// Get All Student
        /// </summary>
        /// <returns></returns>
        List<Student> GetAllStudents();




    }
}
