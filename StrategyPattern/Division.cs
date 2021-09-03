using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern
{
    public class Division : IStrategy
    {
        public double Execute(double a, double b)
        {
            return a / b;
        }
    }
}
