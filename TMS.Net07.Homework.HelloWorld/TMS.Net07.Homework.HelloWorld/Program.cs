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
            int number = int.Parse(input);
            Console.WriteLine($"Введенное число - {number}");

            Console.ReadKey();
        }
    }
}
