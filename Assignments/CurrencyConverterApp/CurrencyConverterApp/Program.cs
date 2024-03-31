using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            double USDtoRupeesRate = 277.58;
            double USDtoEuroRate = 0.93;
            double USDtoPoundRate = 0.79;

            Console.WriteLine("Enter amount in USD");
            double AmountinUSD = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose currency to convert to:");
            Console.WriteLine("1. Pakistani Rupees");
            Console.WriteLine("2. Euro");
            Console.WriteLine("3. British Pound");
            Console.WriteLine("Enter Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    double AmountinRupees = AmountinUSD * USDtoRupeesRate;
                    Console.WriteLine(AmountinUSD + " USD is Equal to " + AmountinRupees + " Rupees");
                    break;
                case 2:
                    double AmountinEuro = AmountinUSD * USDtoEuroRate;
                    Console.WriteLine(AmountinUSD + " USD is Equal to " + AmountinEuro + " Euros");
                    break;
                case 3:
                    double AmountinPound = AmountinUSD * USDtoPoundRate;
                    Console.WriteLine(AmountinUSD + " USD is Equal to " + AmountinPound + " Pounds");
                    break;
                default:
                    Console.WriteLine("Invalid Choice. Please try again!");
                    break;
            }

            Console.ReadKey();


        }
    }
