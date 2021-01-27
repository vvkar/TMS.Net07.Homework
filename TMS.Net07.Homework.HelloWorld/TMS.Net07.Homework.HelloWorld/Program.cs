using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:") ;
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out int number);

            while (check == false)
            {
                Console.WriteLine($"Ошибка ввода, '{input}' не является числом. Повторите ввод:");
                input = Console.ReadLine();
                check = int.TryParse(input, out number);
            }

            Console.WriteLine($"Введенное число - {number}");

            Console.ReadKey();
        }
    }
}
