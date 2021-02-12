using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Net07.Homework.ConverterCalculator
{
    class Program
    {

        enum ExchangeSellCourses 
        {
            USD_to_BYN = 26590,
            EUR_to_BYN = 31630,
            RUB_to_BYN = 342,

            EUR_to_USD = 12120,
            EUR_to_RUB = 932300,
            USD_to_RUB = 774700,
        }

        enum ExchangeBuyCourses
        {
            BYN_to_USD = 26240,
            BYN_to_EUR = 31960,
            BYN_TO_RUB = 352,

            USD_to_EUR = 11940,
            RUB_to_EUR = 907600,
            RUB_to_USD = 754200
        }

        static void Main(string[] args)
        {
            ExchangeSellCourses SellCourse;
            ExchangeBuyCourses BuyCourse;

            string sourceCurrency;
            string targetCurrency;
            string amountInput;

            bool sellCheck;
            bool buyCheck;
            bool amountCheck;

            double amount;
            double amountAfterExchange;

            do
            {
                Console.Write("Input source currency (e.g. BYN, USD, EUR, RUB): ");
                sourceCurrency = Console.ReadLine().ToUpper();
                Console.Write("Input target currency (e.g. BYN, USD, EUR, RUB): ");
                targetCurrency = Console.ReadLine().ToUpper();
                Console.Write("Input amount you wich to exchange: ");
                amountInput = Console.ReadLine();

                string exchangeType = (sourceCurrency + "_to_" + targetCurrency); //concatination to use enum constants

                sellCheck = Enum.TryParse(exchangeType, out SellCourse);
                buyCheck = Enum.TryParse(exchangeType, out BuyCourse);
                amountCheck = double.TryParse(amountInput, out amount);

                bool inputCheck = (sellCheck && amountCheck) || (buyCheck && amountCheck); //checking if input values are correct
                if (!inputCheck)
                {
                    Console.WriteLine("Invalid input, try again!");                
                }
            }
            while (!(sellCheck||buyCheck));

            if (sellCheck)
            {
                amountAfterExchange = amount * ((int)SellCourse / 10000.0);
            }
            else
            {
                amountAfterExchange = amount * (10000.0/(int)BuyCourse);
            }
            Console.WriteLine($"{amountInput} {sourceCurrency} is equal to {amountAfterExchange:0.####} {targetCurrency}");

            Console.ReadKey();
        }
    }
}
