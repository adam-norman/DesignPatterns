using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern
{
   public class CalculatorContext
    {
        private  IStrategy strategy;

        public double ExecuteStrategy(double a, double b)
        {
            return this.strategy.Execute(a, b);
        }
        public void SetStrategy(IStrategy strategy)
        {
              this.strategy = strategy;
        }

    }
}
