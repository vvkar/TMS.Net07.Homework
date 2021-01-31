using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Please input date: ");
            do
            {
                string input = Console.ReadLine();

                if (input == "exit")
                    return;

                var date = Convert.ToDateTime(input);

                Console.WriteLine("Day of week: "+date.DayOfWeek);
                Console.WriteLine();
                Console.Write("Try another date or input 'exit' to close the program: ");            
            }
            while (true);
        }
    }
}
