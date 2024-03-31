using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first value");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter an Operator (+, -, /, *)");
            string op = Console.ReadLine();
            Console.WriteLine("Enter second value");
            int num2 = Convert.ToInt32(Console.ReadLine());


            if (op == "+")
            {
                int Ans1 = num1 + num2;
                Console.WriteLine("Answer: " + Ans1);
            }
            else if (op == "-")
            {
                int Ans2 = num1 - num2;
                Console.WriteLine("Answer: " + Ans2);
            }
            else if (op == "/")
            {
                int Ans3 = num1 / num2;
                Console.WriteLine("Answer: " + Ans3);
            }
            else if (op == "*")
            {
                int Ans4 = num1 * num2;
                Console.WriteLine("Answer: " + Ans4);
            }
            else
            {
                Console.WriteLine("Incorrect Value or Operator. Please try again!");
            }

            Console.ReadKey();
        }
    }
}
