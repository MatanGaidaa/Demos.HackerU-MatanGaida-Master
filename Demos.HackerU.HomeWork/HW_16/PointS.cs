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
            PointsList pointsList = new PointsList();
            Point point = new Point();
            Point point1 = new Point(2, 7);

            point.MyEventHandler += Point_PointEquals;
            pointsList.PointAdded += Point_PointAdd;
            pointsList.PointRemove += Point_PointRemove;


            //Not EQUALES
            point.X = 1;
            point.Y = 7;

            //EQUALES
            point.X = 5;
            point.Y = 5;

            pointsList.AddPoint(point);
            pointsList.AddPoint(point1);
            pointsList.RemovePoint(5, 5);
        }
        public static void Point_PointEquals(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine("X and Y are EQUALES : " + eventArgs.Value);

        }
        public static void Point_PointAdd(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine($"New Point Is Added {eventArgs.X},{eventArgs.Y} ");

        }

        public static void Point_PointRemove(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine($"The x,y values removed ---> x={eventArgs.X} y={eventArgs.Y}");

        }

    }
}
