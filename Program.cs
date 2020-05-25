namespace Fibonacci
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the fibonacci precision: ");
            string userInput = Console.ReadLine();

            int precision;
            while (!int.TryParse(userInput, out precision))
            {
                System.Console.WriteLine();

                System.Console.Write("enter a valid number: ");
                userInput = Console.ReadLine();

                System.Console.WriteLine();
            }

            Console.WriteLine(Fibonacci(precision));
        }

        private static string Fibonacci(int precision)
        {
            if (precision == 0)
            {
                return "0, 1";
            }

            return "0, 1, " + FibonacciStep(precision: precision);
        }

        private static string FibonacciStep(int precision, int fib1 = 0, int fib2 = 1)
        {
            if (precision == 1)
            {
                return (fib1 + fib2).ToString();
            }
            else
            {
                return $"{fib1 + fib2}, {FibonacciStep(precision - 1, fib2, fib1 + fib2)} ";
            }
        }
    }
}
