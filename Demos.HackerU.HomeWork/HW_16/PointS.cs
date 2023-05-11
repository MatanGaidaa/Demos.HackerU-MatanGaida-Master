using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Demos.HackerU.HomeWork.HW_16.Point;

namespace Demos.HackerU.HomeWork.HW_16
{
    public class PointS
    {
        public static void Run()
        {
            Point point = new Point();
            point.MyEventHandler += Point_PointEquals;

            //Not EQUALES
            point.X = 1;
            point.Y = 7;

            //EQUALES
            point.X = 5;
            point.Y = 5;
        }
        public static void Point_PointEquals(object sender, PointEqalsEventArgs eventArgs)
        {
            
           Console.WriteLine("X and Y are EQUALES : " + eventArgs.Value);

        }
    }
}
