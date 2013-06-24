using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class SpicyPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.dough = "pan baked";
        }

        public override void BuildSauce()
        {
            pizza.sauce = "hot";
        }

        public override void BuildTopping()
        {
            pizza.topping = "pepperoni + salami";
        }
    }
}
