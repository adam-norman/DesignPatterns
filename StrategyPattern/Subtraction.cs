using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern
{
    public class Subtraction : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a - b;
        }
    }
}
