using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public string GetInfo()
        {
            return $"({X}, {Y})";
        }

        public double GetDistance(Point target)
        {
            int width = this.X - target.X;
            int height = this.Y - target.Y;

            return Math.Sqrt(width * width + height * height);
        }
    }
}
