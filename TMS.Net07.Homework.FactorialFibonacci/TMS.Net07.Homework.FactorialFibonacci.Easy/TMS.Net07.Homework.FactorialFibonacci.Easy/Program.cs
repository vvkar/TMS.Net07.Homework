using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.FactorialFibonacci.Easy
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int factorial = n;

            for (int i = n-1; i > 0; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);

            Console.ReadKey();
        }
    }
}
