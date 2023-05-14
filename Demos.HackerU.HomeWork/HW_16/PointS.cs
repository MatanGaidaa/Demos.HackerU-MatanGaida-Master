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
            #region Q 1+2
            PointsList pointsList = new PointsList();
            Point point = new Point();
            Point point1 = new Point(2, 7);

            point.MyEventHandler += Point_PointEquals;
            pointsList.PointAdded += Point_PointAdd;
            pointsList.PointAdded += Point_PointAdd2;
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
            #endregion

            #region Q3
            GlobalArray<int> globalInt = new GlobalArray<int>(5);
            globalInt.globalEvent += GlobalArray_AddItem;
            globalInt.AddOrUpdate(2, 6);

            GlobalArray<string> globaString = new GlobalArray<string>(5);
            globaString.globalEvent += GlobalArray_AddItem;
            globaString.AddOrUpdate(2, "Roi Atart");


            GlobalArray<bool> globaBool = new GlobalArray<bool>(5);
            globaBool.globalEvent += GlobalArray_AddItem;
            globaBool.AddOrUpdate(4, true);

            GlobalArray<Point> globaPoint = new GlobalArray<Point>(5);
            globaPoint.globalEvent += GlobalArray_AddItem;
            globaPoint.AddOrUpdate(4, point);
            #endregion
        }
        public static void Point_PointEquals(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine("X and Y are EQUALES : " + eventArgs.Value);

        }
        public static void Point_PointAdd(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine($"New Point Is Added {eventArgs.X},{eventArgs.Y} ");

        }

        public static void Point_PointAdd2(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine($"New Point Is Added {eventArgs.X},{eventArgs.Y} ");

        }

        public static void Point_PointRemove(object sender, PointEventArgs eventArgs)
        {

            Console.WriteLine($"The x,y values removed ---> x={eventArgs.X} y={eventArgs.Y}");

        }

        public static void GlobalArray_AddItem<T>(object sender, GlobalEventArgs<T> eventArgs)
        {

            Console.WriteLine($"New Item Was Added -----> Item : {eventArgs.item} | Index : {eventArgs.index}");

        }

    }
}
