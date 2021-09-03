using DesignPatterns.StrategyPattern;
using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorContext calculatorContext =new CalculatorContext();
            double a, b,result;
            char operation;
            Console.WriteLine("Enter the first number:\n");
            a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:\n");
            b = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please enter number of the operation (+: addition, -: subtraction, *: multiplication, /: division):\n");
            operation =Char.Parse(Console.ReadLine()) ;
            if (operation == '+')
            {
                calculatorContext.SetStrategy(new Addition());
            }
            if (operation == '-')
            {
                calculatorContext.SetStrategy(new Subtraction());
            }
            if (operation == '*')
            {
                calculatorContext.SetStrategy(new Muliplication());
            }
            if (operation == '/')
            {
                calculatorContext.SetStrategy(new Division());
            }
            result = calculatorContext.ExecuteStrategy(a, b);
            Console.WriteLine($"{a} {operation} {b} = {result}.");
            
        }
    }
}
