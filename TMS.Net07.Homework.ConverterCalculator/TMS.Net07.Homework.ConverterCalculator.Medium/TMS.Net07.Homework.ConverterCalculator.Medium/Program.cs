using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.ConverterCalculator.Medium
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operationSuccess;
            bool firstNumberCheck;
            bool secondNumberCheck;

            double firstNumber;
            double secondNumber;
            
            do
            {
                Console.Write("Input first number: ");
                string firstInput = Console.ReadLine();
                firstNumberCheck = double.TryParse(firstInput, out firstNumber);

                Console.Write("Input second number: ");
                string secondInput = Console.ReadLine();
                secondNumberCheck = double.TryParse(secondInput, out secondNumber);
                
                if(!firstNumberCheck || !secondNumberCheck)
                {
                    Console.WriteLine("Incorrect number input, try again!");
                }
            }
            while (!firstNumberCheck || !secondNumberCheck);

            do
            {
                Console.Write("Input the operation you wish to execute (e.g. +, -, *, /, %): ");
                string operation = Console.ReadLine();

                doCalculation(firstNumber, secondNumber, operation, out operationSuccess);
            }
            while  (!operationSuccess) ;

            Console.ReadKey();
        }

        static void doCalculation(double x, double y, string symbol, out bool check)
        {
            check = true;
            switch (symbol)
            {
                case "+":
                    Console.WriteLine ($"Result: {x + y}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {x - y}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {x * y}");
                    break;
                case "/":
                    Console.WriteLine($"Result: {x / y}");
                    break;
                case "%":
                    Console.WriteLine($"Result: {x % y}");
                    break;
                default:
                    check = false;
                    Console.WriteLine("Incorrect operation sighn input, try again!");
                    break;

            }
        }
    }
}
