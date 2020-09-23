using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    public class Calculator
    {
        public void RunCalc()
        {
            string[] operations = new string[4] { "+", "-", "*", "/" };
            string operation;
            double firstNumber;
            double secondNumber;
            double answer;
            string reset;

            Console.WriteLine("Select an operation among +, -, *, or /");
            operation = GetOperation(operations);

            Console.WriteLine("Enter first number:");
            firstNumber = GetInput();

            Console.WriteLine("Enter second number:");
            secondNumber = GetInput();

            answer = Calculate(operation, firstNumber, secondNumber);
            Console.WriteLine($"Answer is {answer}");
            Console.WriteLine("Would you like to restart the calculator? If so, write 'y'.");
            reset = Console.ReadLine().ToLower();
            if(reset == "y")
            {
                RunCalc();
            }
            else
            {
                Environment.Exit(0);
            }
        }
        private string GetOperation(string[] operations)
        {
            string operation = Console.ReadLine();
            while(!operations.Contains(operation))
            {
                Console.WriteLine("Invalid type. Select again an operation among +, -, *, or /");
                operation = Console.ReadLine();
            }
            return operation;
        }
        public double GetInput()
        {
            double number;
            string input = Console.ReadLine();
            while (double.TryParse(input, out double x) == false)
            {
                Console.WriteLine("Try again. Enter only a number.");
                input = Console.ReadLine();
            }
            number = Double.Parse(input);
            return number;
        }
        public double Calculate(string oper, double x, double y)
        {
            double result;

            switch (oper)
            {
                case "+":
                    result = Addition(x, y);
                    return result;
                case "-":
                    result = Subtraction(x, y);
                    return result;
                default:
                    break;
            }
            return 0;
        }
        public static double Addition(double x, double y)
        {
            return x + y;
        }
        public static double Subtraction(double x, double y)
        {
            return x - y;
        }
        public static double Multiplication(double x, double y)
        {
            return x * y;
        }
        public static double Division(double x, double y)
        {
            return x / y;
        }

    }
}
