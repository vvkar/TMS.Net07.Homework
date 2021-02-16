using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class Rectangle : Square
    {
        public Rectangle(Point point1, Point point2) : base(point1, point2)
        {
            Point1 = point1;
            Point2 = point2;
        }
        public Rectangle(Point point1, int lenght, int height) : base(point1, lenght)
        {
            Point1 = point1;
            Point2.X = point1.X + lenght;
            Point2.Y = point1.Y + height;
        }

        public override string GetInfo()
        {
            return base.GetInfo();
        }
        public override string GetName()
        {
            return nameof(Rectangle);
        }
    }
}
