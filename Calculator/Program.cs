using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Simple Calculaor!");
            
            Calculator calculator = new Calculator();
            calculator.RunCalc();
        }
    }
}
