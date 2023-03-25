
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.Shapes
{
    /// <summary>
    /// * Implement ILogger for both Rectangle 
    ///  public interface ILogger   
    //-void Log(string text, int level);
    // -void Log(string text, int level, string fileName);
    /// </summary>
    public class Rectangles : Shape
    {
        private int _height;
        private int _width;
        public int Height { get => _height; set => _height = value; }
        public int Width { get => _width; set => _width = value; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="height"></param>
        /// <param name="width"></param>
        /// <param name="color"></param>
        public Rectangles(int height, int width, ShapeColor color) : base(color)
        {
            _height = height;
            _width = width;
        }

        public Rectangles(int size, ShapeColor color) : base(color)
        {
            _height = size;
            _width = size;
        }


        /// <summary>
        /// 
        /// </summary>
        public override double CalculateArea()
        {
            return Width * Height;
        }

        public override double CalculatePerimeter()
        {
            return Height * 2 + Width * 2;
        }


        public override string ToString()
        {
            return $" Width:{Width} Height:{Height}" + base.ToString();
        }

    }
}
