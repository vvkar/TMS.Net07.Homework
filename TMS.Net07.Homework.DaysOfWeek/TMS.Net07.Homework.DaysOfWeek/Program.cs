using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        static void GetDayOfWeekMiddleLevel(string input)
        {            
            var date = Convert.ToDateTime(input);

            Console.WriteLine("Day of week mid lvl check: " + date.DayOfWeek);
            Console.WriteLine();
        }
        static void GetDayOfWeekHardLevel(string input)
        {
            string[] numbs = input.Split('.');
            int day = Convert.ToInt32(numbs[0]); 
            int month = Convert.ToInt32(numbs[1]);
            int year = Convert.ToInt32(numbs[2]) - 1;

            int days = year * 365 + year / 400 - year / 100 + year / 4;

            bool check = false;
            if ((year + 1) % 400 == 0 || ((year + 1) % 4 == 0 && (year + 1) % 100 != 0))
                check = true;

            for (int i = 1; i < month; i++)
            {
                if (i <= 7)
                {
                    if (i == 2 && check == true)
                        days += 29;
                    else if (i == 2 && check == false)
                        days += 28;
                    else if (i % 2 != 0)
                        days += 31;
                    else
                        days += 30;
                }
                else
                {
                    if (i % 2 != 0)
                        days += 30;
                    else
                        days += 31;
                }
            }
            days += day;
            DaysOfWeek Day = (DaysOfWeek)(days % 7);
            Console.WriteLine("Day of week hard lvl check: "+ Day);
            Console.WriteLine();
        }
        enum DaysOfWeek
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        static void Main(string[] args)
        {
           Console.Write("Please input date: ");
            do
            {
                string input = Console.ReadLine();

                if (input == "exit")
                    return;

                GetDayOfWeekMiddleLevel(input);
                GetDayOfWeekHardLevel(input);
                Console.Write("Try another date or input 'exit' to close the program: ");
            }
            while (true);
        }
    }
}
