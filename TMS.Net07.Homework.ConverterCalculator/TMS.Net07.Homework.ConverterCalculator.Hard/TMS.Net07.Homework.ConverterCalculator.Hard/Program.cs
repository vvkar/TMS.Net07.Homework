using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.ConverterCalculator.Hard
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operationSuccess;

            StringBuilder sbNumbers = new StringBuilder();
            StringBuilder sbOperators = new StringBuilder();

            ArrayList listNumbers = new ArrayList();
            ArrayList listOperators = new ArrayList();

            do
            {
                Console.Write("Input the calculation (e.g. '2+2', 'sqrt 4' etc): ");
                string input = Console.ReadLine().ToLower();
                input = input.Replace(" ", "");
                foreach (char c in input)   //check of each input elements
                {
                    if ((c >= '0' && c <= '9') || (c == '.' || c == ','))   //checking if an element is a number 
                    {
                        if (sbOperators.Length != 0)
                        {
                            listOperators.Add(sbOperators.ToString());
                            sbOperators.Clear();
                        }
                        sbNumbers = sbNumbers.Append(c);    //adding number to a numbers variable
                    }
                    else
                    {
                        if (sbNumbers.Length != 0)
                        {
                            listNumbers.Add(sbNumbers.ToString());
                            sbNumbers.Clear();
                        }
                        sbOperators = sbOperators.Append(c);    //adding operator (+, -, /, pow etc.) to an operators variable
                    }
                }
                listNumbers.Add(sbNumbers.ToString());  //adding last number to a list of numbers

                double[] numbers = new double[listNumbers.Count];
                int i = 0;
                foreach (object o in listNumbers)
                {
                    numbers[i] = double.Parse((string)o);   //parsing list elements to a double array
                    i++;
                }
                string[] operators = new string[listOperators.Count];
                i = 0;
                foreach (object o in listOperators)
                {
                    operators[i] = (string)o;   //parsing list elements to a string array
                    i++;
                }

                doCalculation(numbers, operators, out operationSuccess);
            }
            while (!operationSuccess);

            Console.ReadKey();
        }

        static void doCalculation(double[] x, string[] op, out bool check)
        {
            check = true;
            switch (op[0])
            {
                case "+":
                    Console.WriteLine($"Result: {x[0] + x[1]}");
                    break;
                case "-":
                    Console.WriteLine($"Result: {x[0] - x[1]}");
                    break;
                case "*":
                    Console.WriteLine($"Result: {x[0] * x[1]}");
                    break;
                case "/":
                    Console.WriteLine($"Result: {x[0] / x[1]}");
                    break;
                case "%":
                    Console.WriteLine($"Result: {x[0] % x[1]}");
                    break;
                case "sqr":
                    Console.WriteLine($"Result: {Math.Pow(x[0], 2)}");
                    break;
                case "sqrt":
                    Console.WriteLine($"Result: {Math.Sqrt(x[0])}");
                    break;
                case "pow":
                    Console.WriteLine($"Result: {Math.Pow(x[0], x[1])}");
                    break;
                default:
                    check = false;
                    Console.WriteLine("Incorrect operation sighn input, try again!");
                    break;
            }
        }
    }
}
