using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW19_Q2
{
    public class MainRunHW19
    {
        public static void Run()
        {

            try
            {
                DataBaseContext db = new DataBaseContext();


                ManagerEmployee _managerEmployee = new ManagerEmployee() { ManagerName = "David" };
                _managerEmployee.Categorys = new List<CategoryEmployee>()
            {
                new CategoryEmployee{CategoryName="Electronic" ,Description="EEEEEE"},
                new CategoryEmployee{CategoryName="Sports" , Description="SSSSSS"},
                new CategoryEmployee{CategoryName="Art" ,Description="AAAAAA" }
            };

                db.managerEmployees.Add(_managerEmployee);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error:" + ex);
            }




        }
    }
}
