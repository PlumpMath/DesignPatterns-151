using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Strategy
{
    public class Context
    {
        private IStrategy strategy;

        public Context(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public IStrategy IStrategy
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }

        public int executeStrategy(int a, int b)
        {
            return this.strategy.execute(a, b);
        }
    }
}
