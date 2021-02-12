using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.Task5.Fibonacci
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

            var buffer = new int[n+1];

            var res = Fibonacci(n, buffer); //calculating the N-th Fibonacci element

            Console.WriteLine($"The {n} Fibonacci number equals {res}");            

            Console.ReadKey();

        }

        public static int Fibonacci(int n, int [] buffer)   //why static?
        {
            if (n==0 || n==1)   //when recursion reaches first or zero element 
            {
                buffer[n] = n;  //first or zero element becomes 0 or 1 
                return n;       //ending of the recursion
            }
            if (buffer [n]==0)  //check if the N-th element is already written
            {
                buffer[n] = Fibonacci(n - 2, buffer) + Fibonacci(n - 1, buffer);    //recursion
            }
            return buffer[n];   //if the N-th element in buffer[n] already exist 
        }
    }
}
