using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StrategyPattern
{
   public interface IStrategy
    {
       double Execute(double a, double b);
    }
}
