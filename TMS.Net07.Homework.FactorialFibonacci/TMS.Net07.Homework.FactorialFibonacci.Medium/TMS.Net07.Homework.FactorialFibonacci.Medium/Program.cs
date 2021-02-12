using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.FactorialFibonacci.Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Please input the number: ");
                n = int.Parse(Console.ReadLine());
                if (n < 0)
                {
                    Console.WriteLine("Input shoud be nonnegative!");
                }
            }
            while (n < 0);

            Console.WriteLine($"Factorial of {n} equals "+GetFactorial(n));

            Console.ReadKey();
        }

        static int GetFactorial(int n)
        {
            if (n==0 || n==1)
            {
                return n;
            }
            return n * GetFactorial(n - 1);
        }
    }
}
