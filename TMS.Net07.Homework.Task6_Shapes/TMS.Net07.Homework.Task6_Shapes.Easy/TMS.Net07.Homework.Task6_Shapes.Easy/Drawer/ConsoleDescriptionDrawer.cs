using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task6_Shapes.Easy
{
    class ConsoleDescriptionDrawer : Drawer
    {
        public override void Draw(Shape shape)
        {
            Console.WriteLine(shape.GetInfo());
        }
    }
}
