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
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFactorial(n));

            Console.ReadKey();
        }

        static int GetFactorial(int n)
        {
            if (n==1)
            {
                return n;
            }
            return n * GetFactorial(n - 1);
        }
    }
}
