using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.FactorialFibonacci.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Input the number: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Input should be nonnegative!");
                }
            }
            while (n < 0);

            Console.WriteLine($"The {n} Fibonacci number is "+Fibonacci(n));

            Console.ReadKey();
        }

        static int Fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }                
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
