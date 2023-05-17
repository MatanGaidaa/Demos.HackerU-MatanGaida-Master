using Demos.HackerU.HomeWork.HW_18.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_18
{
    public class HW18Run
    {
        public static void Run()
        {
            ISudentRepository studentRepo = new SudentDbRepository();
            StudentModel studentModel1 = new StudentModel(2, 2, "Matan", "Gaida", "Matan@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            StudentModel studentModel2 = new StudentModel(3, 3, "Roi", "Atar", "Roi@gmail.com", "FullStack", "0547580566", "Netanya", "bar-lev", DateTime.Now, 95);
            studentRepo.AddNewStudent(studentModel1);
            studentRepo.AddNewStudent(studentModel2);
            var sudentList = studentRepo.GetAllStudents();


        }

    }
}
