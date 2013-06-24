using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Builder;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
            Cook cook = new Cook();
            cook.SetPizzaBuilder(hawaiianPizzaBuilder);
            cook.ConstructPizza();
            // create the product
            Pizza hawaiian = cook.GetPizza();

            PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
            cook.SetPizzaBuilder(spicyPizzaBuilder);
            cook.ConstructPizza();
            // create another product
            Pizza spicy = cook.GetPizza();
        }
    }
}
