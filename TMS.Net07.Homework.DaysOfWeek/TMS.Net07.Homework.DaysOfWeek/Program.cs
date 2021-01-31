using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.DaysOfWeek
{
    class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        static void Main(string[] args)
        {
            DaysOfWeek day;
            Console.Write("Input day of week name you wish to translate: ");
            do
            {
                bool check = false;
                do
                {
                    string dayName = Console.ReadLine();
                    if (dayName == "exit")
                        return;

                    switch (dayName)
                    {
                        case "Monday":
                            day = DaysOfWeek.Monday;
                            check = true;
                            break;
                        case "Tuesday":
                            day = DaysOfWeek.Tuesday;
                            check = true;
                            break;
                        case "Wednesday":
                            day = DaysOfWeek.Wednesday;
                            check = true;
                            break;
                        case "thursday":
                            day = DaysOfWeek.Thursday;
                            check = true;
                            break;
                        case "Friday":
                            day = DaysOfWeek.Friday;
                            check = true;
                            break;
                        case "Saturday":
                            day = DaysOfWeek.Saturday;
                            check = true;
                            break;
                        case "Sunday":
                            day = DaysOfWeek.Sunday;
                            check = true;
                            break;
                        default:
                            Console.WriteLine("Invalid input, try again.");
                            day = 0;
                            break;
                    }
                }
                while (check == false);

                switch (day)
                {
                    case DaysOfWeek.Monday:
                        Console.WriteLine("Translate: Понедельник");
                        break;
                    case DaysOfWeek.Tuesday:
                        Console.WriteLine("Translate: Вторник");
                        break;
                    case DaysOfWeek.Wednesday:
                        Console.WriteLine("Translate: Среда");
                        break;
                    case DaysOfWeek.Thursday:
                        Console.WriteLine("Translate: Четверг");
                        break;
                    case DaysOfWeek.Friday:
                        Console.WriteLine("Translate: Пятница");
                        break;
                    case DaysOfWeek.Saturday:
                        Console.WriteLine("Translate: Суббота");
                        break;
                    case DaysOfWeek.Sunday:
                        Console.WriteLine("Translate: Воскресенье");
                        break;
                }
                Console.Write("Try another day or input 'exit' to close the program: ");
            }
            while (true);
        }
    }
}
