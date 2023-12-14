using ScottPlot.Plottable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiltrySplotowe
{
    public class Polygon
    {
        public List<Point> points = new List<Point>();

        public Polygon() { }

        public bool AddPointOrFinish(Point point)
        {
            int MARGIN_ERROR = 10;

            foreach (var el in points)
            {
                if (Math.Abs(el.X - point.X) < MARGIN_ERROR && Math.Abs(el.Y - point.Y) < MARGIN_ERROR) {
                    return true;
                }
            }

            points.Add(point);
            return false;
        }

        public void ClearPolygon()
        {
            points.Clear();
        }

        public static bool CheckIfInsidePolygon(int x, int y, List<Point> points)
        {
            int howMany = CountHowManyTimeIntersected(x, y, points);

            return howMany % 2 == 1;
        }

        public static int CountHowManyTimeIntersected(int x, int y, List<Point> points)
        {
            var copyPolygon = points.ToList();
            copyPolygon.Add(points[0]);

            Point? previousPoint = null;
            int howManyTimes = 0;

            foreach (var point in copyPolygon)
            {
                if (previousPoint != null)
                    if (TellIfIntersected(previousPoint.Value, point, x, y))
                        howManyTimes++;

                previousPoint = point;
            }

            return howManyTimes;
        }


        public static bool TellIfIntersected(Point point1, Point point2, int x, int y)
        {
            float x1 = point1.X;
            float y1 = point1.Y;
            float x2 = point2.X;
            float y2 = point2.Y;

            if (x < x1 && x < x2)  // line is on the right
            {
                if (y < Math.Max(y1, y2) && y >= Math.Min(y1, y2))
                    return true;
            }
            else if (x <= Math.Max(x1, x2) && x >= Math.Min(x1, x2) && y < Math.Max(y1, y2) && y >= Math.Min(y1, y2)) // point is in between
            {
                y = -y;
                (float a, float b) = CalculateLinearFunction(x1, y1, x2, y2);
                float valueY = a * x + b;

                if (a > 0 && y >= valueY)
                    return true;
                else if (a < 0 && y <= valueY)
                    return true;
            }

            return false;
        }

        public static (float, float) CalculateLinearFunction(float x1, float y1, float x2, float y2)
        {
            y1 = -y1; y2 = -y2;
            float a = (y2 - y1) / (x2 - x1);
            float b = y1 - a * x1;

            return (a, b);
        }

        public void movePolygon(int x, int y)
        {
            if (points.Count == 0) return;

            int offsetX = x - points[0].X;
            int offsetY = y - points[0].Y;

            var newList = new List<Point>();
            foreach (var el in points)
            {
                newList.Add(new Point(el.X + offsetX, el.Y + offsetY));
            }

            points = newList;
        }

    }
}
