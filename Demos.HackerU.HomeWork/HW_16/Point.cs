using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demos.HackerU.HomeWork.HW_16
{
    public class Point
    {
        private int x;
        private int y;

        public int X { get { return x; } set { x = value; isEqual(); } }
        public int Y { get { return y; } set { y = value; isEqual(); } }

        public EventHandler<PointEqalsEventArgs> MyEventHandler = null;


        public Point()
        {
            x = 0;
            y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void isEqual()
        {
            if (x == y)
            {
                MyEventHandler?.Invoke(this, new PointEqalsEventArgs(x));
            }


        }


        public class PointEqalsEventArgs : EventArgs
        {

            public int Value { get; set; }

            public PointEqalsEventArgs(int value)
            {
                Value = value;
            }

        }
    }
}
