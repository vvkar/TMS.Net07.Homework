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
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();
            bool check = int.TryParse(input, out int number);

            while (check == false)
            {
                Console.WriteLine($"Ошибка ввода, '{input}' не является числом. Повторите ввод:");
                input = Console.ReadLine();
                check = int.TryParse(input, out number);
            }

            Console.WriteLine($"Введенное число - {number}");

            Console.WriteLine("Для выхода из программы введите цифру 0:");
            input = Console.ReadLine();
            check = int.TryParse(input, out number);

            while (check == false | number !=0)
            {
                if (check == false)
                {
                    Console.WriteLine("Введенная запись не является числовой. Для выхода из программы введите цифру 0:");
                    input = Console.ReadLine();
                    check = int.TryParse(input, out number);
                }
                else if (check == true && number!=0)
                {
                    Console.WriteLine("Вы ввели неверную цифру. Для выхода из программы введите цифру 0:");
                    input = Console.ReadLine();
                    check = int.TryParse(input, out number);
                }
                else if (check == true && number == 0)
                {
                    return;
                }

            }

        }
    }
}
