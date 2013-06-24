using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class HawaiianPizzaBuilder : PizzaBuilder
    {
        public override void BuildDough()
        {
            pizza.dough = "cross";
        }

        public override void BuildSauce()
        {
            pizza.sauce = "mild";
        }

        public override void BuildTopping()
        {
            pizza.topping = "ham+pineapple";
        }
    }
}
