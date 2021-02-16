using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class Ellipse : Circle
    {
        public int Radius2 { get; set; }
        public Ellipse(Point point1, int radius1, int radius2) : base(point1, radius1)
        {
            Point1 = point1;
            Radius1 = radius1;
            Radius2 = radius2;
        }

        public override string GetInfo()
        {
            return $"{this.GetName()}, ({Point1.X},{Point1.Y}), width: {Radius1 * 2}, height {Radius2 * 2}";
        }
        public override string GetName()
        {
            return nameof(Ellipse);
        }
    }
}
