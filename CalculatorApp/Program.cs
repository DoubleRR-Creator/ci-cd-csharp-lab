using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine("Калькулейт: " + calc.Add(2, 3));
        }
    }
}