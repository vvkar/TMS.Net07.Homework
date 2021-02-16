using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class Circle : Shape
    {
        public Point Point1 { get; set; }
        public int Radius1 { get; set; }

        public Circle(Point point1, int radius1)
        {
            Point1 = point1;
            Radius1 = radius1;
        }

        public override string GetInfo()
        {
            return $"{this.GetName()}, ({Point1.X},{Point1.Y}), radius {Radius1}";
        }

        public override string GetName()
        {
            return nameof(Circle);
        }
    }
}
