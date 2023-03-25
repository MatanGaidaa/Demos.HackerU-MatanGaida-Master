using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Shapes
{
    /// <summary>
    /// Implement Abstract Class
    /// </summary>
    public class Circle : Shape
    {
        private int _radius;
        public int Radius { get => _radius; set => _radius = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        public Circle(int radius, ShapeColor color) : base(color)
        {
            _radius = radius;
        }

        /// <summary>
        /// CalculateArea Override over Shape CalculateArea() abstract
        /// </summary>
        /// <returns></returns>
        public override double CalculateArea()
        {
            return Math.PI * (Math.Pow(Radius, 2));
        }

        /// <summary>
        /// CalculatePerimeter implementation over Shape abstract CalculatePerimeter
        /// </summary>
        /// <returns></returns>
        public override double CalculatePerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        /// <summary>
        /// Print all data (Shape+Circle) 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            //Color + Radius
            return $" Radius:{_radius}" + base.ToString();
        }


    }
}
