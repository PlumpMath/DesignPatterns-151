using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Cook
    {
        private PizzaBuilder _pizzaBuilder;

        public PizzaBuilder PizzaBuilder
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public void SetPizzaBuilder(PizzaBuilder pb)
        {
            _pizzaBuilder = pb;
        }

        public Pizza GetPizza()
        {
            return _pizzaBuilder.GetPizza();
        }

        public void ConstructPizza()
        {
            _pizzaBuilder.CreateNewPizzaProduct();
            _pizzaBuilder.BuildDough();
            _pizzaBuilder.BuildSauce();
            _pizzaBuilder.BuildTopping();
        }
    }
}
