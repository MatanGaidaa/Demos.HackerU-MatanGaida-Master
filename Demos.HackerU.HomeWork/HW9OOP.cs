using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demos.HackerU.HomeWork.Shapes;
namespace Demos.HackerU.HomeWork
{
    public class HW9OOP
    {
        public static void Run()
        {
            //--Polimorpism
            Shape s1 = new Circle(10, ShapeColor.White);
            Shape s2 = new Rectangles(10, 15, ShapeColor.White);
            Shape[] shapes = new Shape[] { s1, s2 };
            Shape s = shapes[0];
            //--Run Derived(Child) method from Base(Parent) Class 
            double resArea = s.CalculateArea();
            double resPerimeter = s.CalculatePerimeter();
            var areaRectangle = s2.Area;
            var perimeterRectangle = s2.Perimeter;

            var areaOfCircle = s1.Area;
            Console.WriteLine(s1);
            Console.WriteLine(s2);


        }
    }
}
