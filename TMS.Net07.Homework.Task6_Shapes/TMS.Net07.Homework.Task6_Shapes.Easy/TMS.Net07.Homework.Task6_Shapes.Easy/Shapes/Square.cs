using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class Square : Shape
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }

        public Square(Point point1, Point point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        public Square(Point point1, int length)
        {
            Point1 = point1;
            Point point2 = new Point(point1.X + length, point1.Y + length);
            Point2 = point2;
        }
        public override string GetInfo()
        {
            return $"{this.GetName()}, ({Point1.X},{Point1.Y}) ({Point2.X},{Point2.Y})";
        }

        public override string GetName()
        {
            return nameof(Square);
        }
    }
}
