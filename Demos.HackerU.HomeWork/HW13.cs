using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.HomeWork.ExceptionDemos;




namespace Demos.HackerU.HomeWork
{
    public class HW13
    {
        public static void Run()
        {
            try
            {
                ExceptionTest.ReadFromFile();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }



        }
    }
}
