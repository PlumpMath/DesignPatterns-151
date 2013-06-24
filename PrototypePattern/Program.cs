using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Prototype;


namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var prototype = new ConcretePrototype(1000);
           
            for (int i = 1; i < 1000; i++)
            {
                ConcretePrototype tempotype = prototype.Clone() as ConcretePrototype;
                tempotype.X *= i;
                
            }
        }
    }
}
