using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LengthConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Convert feet to inches");
            Console.WriteLine("2. Convert inches to feet");
            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter length in feet: ");
                    double Feet = Convert.ToDouble(Console.ReadLine());
                    double InchesfromFeet = ConvertFeetToInches(Feet);
                    Console.WriteLine(Feet + " feet is equal to " + InchesfromFeet + " inches.");
                    break;
                case 2:
                    Console.Write("Enter length in inches: ");
                    double Inches = Convert.ToDouble(Console.ReadLine());
                    double FeetfromInches = ConvertInchesToFeet(Inches);
                    Console.WriteLine(Inches + " inches is equal to " + FeetfromInches + " feet.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.ReadKey();
        }
        static double ConvertFeetToInches(double Feet)
        {
            return Feet * 12;
        }

        static double ConvertInchesToFeet(double Inches)
        {
            return Inches / 12;
        }

    }
}
