using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class Triangle : Shape
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public Point Point3 { get; set; }
        public Triangle(Point point1, Point point2, Point point3)
        {
            Point1 = point1;
            Point2 = point2;
            Point3 = point3;
        }
        public override string GetInfo()
        {
            return $"{this.GetName()}, ({Point1.X},{Point1.Y}) ({Point2.X},{Point2.Y}) ({Point3.X},{Point3.Y})";
        }
        public override string GetName()
        {
            return nameof(Triangle);
        }
    }
}
