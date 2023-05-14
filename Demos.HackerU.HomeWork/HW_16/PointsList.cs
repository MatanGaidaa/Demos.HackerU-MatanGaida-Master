using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Demos.HackerU.HomeWork.HW_16.Point;

namespace Demos.HackerU.HomeWork.HW_16
{
    public class PointsList
    {
        private List<Point> points;

        public event EventHandler<PointEventArgs> PointAdded = null;

        public event EventHandler<PointEventArgs> PointRemove = null;

        public PointsList()
        {
            points = new List<Point>();
        }


        public void AddPoint(Point t)
        {
            points.Add(t);
            PointAdded.Invoke(this, new PointEventArgs(t.X, t.Y));
        }
        public void AddPoint(int x, int y)
        {
            Point p = new Point(x, y);
            AddPoint(p);
        }


        public void RemovePoint(int x, int y)//Remove point by x,y
        {
            Point toRemovdPoint = points.Find(pointList => pointList.X == x && pointList.Y == y);
            if (toRemovdPoint != null)
            {
                points.Remove(toRemovdPoint);
                PointRemove.Invoke(this, new PointEventArgs(x, y));
            }

        }
        public void RemovePoint(int index)//remove point by index
        {
            if (index >= 0 && index < points.Count)
            {
                Point point = points[index];
                points.RemoveAt(index);
                PointRemove.Invoke(this, new PointEventArgs(point.X, point.Y));
            }

        }


    }
}
