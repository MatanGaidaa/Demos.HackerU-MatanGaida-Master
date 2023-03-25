using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Shapes
{
    public abstract class Shape
    {
        //--fields
        private double _area; //--claculate data
        private double _perimeter; //--calculate data
        private ShapeColor _color; //-- info data

        /// <summary>
        /// Empty Ctor
        /// </summary>
        public Shape() : this(ShapeColor.White)
        {
            _area = 0;
            _perimeter = 0;

        }

        /// <summary>
        /// Full Ctor
        /// </summary>
        /// <param name="color"></param>
        public Shape(ShapeColor color)
        {
            _color = color;
        }

        /// <summary>
        /// Color Emum
        /// </summary>
        public ShapeColor Color { get => _color; set => _color = value; }


        public double Area
        {
            get { return CalculateArea(); }
        }

        public double Perimeter
        {
            get { return CalculatePerimeter(); }
        }

        public abstract double CalculateArea();
        public abstract double CalculatePerimeter();

        public override string ToString()
        {
            var area = string.Format("{0:0.000}", Area);
            return $" Color:{_color}  | Area={area}";
        }
    }

    public enum ShapeColor
    {
        Black,
        White,
        Blue,
        Green,
        Yellow,
        Red
    }
}
