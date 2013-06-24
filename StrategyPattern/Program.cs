using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Strategy;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
             Context context;
 
        // Three contexts following different strategies
        context = new Context(new Add());
        int resultA = context.executeStrategy(3,4);
 
        context = new Context(new Multiply());
        int resultB = context.executeStrategy(3,4);
 
        Console.WriteLine(string.Format("Result A : {0}",resultA));
        Console.WriteLine(string.Format("Result B : {0}", resultB));
      
        }
    }
}
